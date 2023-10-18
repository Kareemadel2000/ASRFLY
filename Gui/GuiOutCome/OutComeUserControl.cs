namespace ASRFLY.Gui.GuiOutCome;

public partial class OutComeUserControl : UserControl
{
    //variables
    private readonly IDataHelper<OutCome> _dataHelper;
    private readonly IDataHelper<SystemRecord> _dataHelperSystemRecord;
    private static OutComeUserControl _OutComeUserControl;
    private int RowId;
    private readonly LoadingForm loadingForm;
    private List<int> IdList = new List<int>();
    private string searchItem;
    private int ProjectId;

    //ctor
    public OutComeUserControl(int projectId)
    {
        InitializeComponent();
        ProjectId = projectId;
        _dataHelper = (IDataHelper<OutCome>)ConfigrationObjectManager.GetObject("OutCome");
        _dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.GetObject("SystemRecord");
        loadingForm = new LoadingForm();
        LaodData();
    }

    #region Events
    private void buttonAdd_Click(object sender, EventArgs e)
    {
        AddOutComeForm addOutComeForm = new AddOutComeForm(0, ProjectId, this);
        addOutComeForm.Show();
    }

    private void buttonEdit_Click(object sender, EventArgs e)
    {
        Edit();
    }

    private async void buttonDelete_Click(object sender, EventArgs e)
    {
        if (dataGridView1.RowCount > 0)
        {
            var DeleteResult = MassageCollection.ShowDeleteDialog();
            if (DeleteResult)
            {
                IdList.Clear();
                SetIdRowForDelete();
                loadingForm.Show();
                if (IdList.Count > 0)
                {
                    for (int i = 0; i < IdList.Count; i++)
                    {
                        RowId = IdList[i];
                        var result = await _dataHelper.DeleteAsync(RowId);
                        if (result == 1)
                        {
                            // Save SystemRecord
                            SystemRecord systemRecord = new SystemRecord
                            {
                                Title = "عملية حذف",
                                UserName = Settings.Default.UserName,
                                Details = "تم حذف عملية الصرف ذى الرقم التعريفي" + RowId.ToString(),
                                AddedDate = DateTime.Now,
                            };
                            await _dataHelperSystemRecord.AddAsync(systemRecord);
                            MassageCollection.ShowDeleteNotifications();
                        }
                        else
                        {
                            MassageCollection.ShowErrorServer();
                        }
                    }
                    LaodData();
                }
                else
                {
                    MassageCollection.ShowRquiredDeleteRow();
                }

                loadingForm.Hide();
            }
        }
        else
        {
            MassageCollection.ShowEmptyDataMassage();
        }
    }

    private async void buttonExport_Click(object sender, EventArgs e)
    {
        // Conver List of Data to DataTable
        DataTable table = new DataTable();
        loadingForm.Show();
        var data = await _dataHelper.GetAllDataAsync();
        using (var reader = ObjectReader.Create(data))
        {
            table.Load(reader);
        }
        loadingForm.Hide();

        //Re-Set Colunm
        DataTable dataTableArranged = SetDataTableColumns(table);

        //Export Data to as Sheet Excel
        ExportAsXlsxFile(dataTableArranged);
    }

    private void buttonSearch_Click(object sender, EventArgs e)
    {
        Search();
    }

    private void buttonUpdate_Click(object sender, EventArgs e)
    {
        LaodData();
    }

    private void textBoxSearch_TextChanged(object sender, EventArgs e)
    {
        Search();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        Edit();
    }

    private async void comboBoxPageNo_SelectedIndexChanged(object sender, EventArgs e)
    {
        loadingForm.Show();
        var data = await _dataHelper.GetAllDataAsync();
        var dataId = data.Select(x => x.Id).ToArray();
        int index = comboBoxPageNo.SelectedIndex;
        int IndexNoOfRow = index * Properties.Settings.Default.DataGridViewRowNo;

        dataGridView1.DataSource = data.Where(x => x.Id >= dataId[IndexNoOfRow] && x.ProjectId == ProjectId).Take(Properties.Settings.Default.DataGridViewRowNo).ToList();
        if (dataGridView1.DataSource == null)
        {
            MassageCollection.ShowErrorServer();
        }
        else
        {
            SetColumnsTitle();
        }
        loadingForm.Hide();
        data.Clear();
    }

    private void buttonOpen_Click(object sender, EventArgs e)
    {

    }


    #endregion

    #region Methods

    public async void LaodData()
    {
        loadingForm.Show();
        var data = await _dataHelper.GetAllDataAsync();
        dataGridView1.DataSource = data.Where(x => x.ProjectId == ProjectId).Take(Properties.Settings.Default.DataGridViewRowNo).ToList();

        // Add Number of page into ComboBox

        comboBoxPageNo.Items.Clear();
        double value = (Convert.ToDouble(data.Count) / Convert.ToDouble(Properties.Settings.Default.DataGridViewRowNo));
        var NoOfPage = (int)Math.Round(value, MidpointRounding.AwayFromZero);

        for (int i = 0; i < NoOfPage; i++)
        {
            comboBoxPageNo.Items.Add(i);
        }

        if (dataGridView1.DataSource == null)
        {
            MassageCollection.ShowErrorServer();
        }
        else
        {
            SetColumnsTitle();
        }
        loadingForm.Hide();
        data.Clear();
    }
    private void SetColumnsTitle()
    {
        dataGridView1.Columns[0].HeaderText = "المعرف";
        dataGridView1.Columns[1].HeaderText = "الصنف";
        dataGridView1.Columns[2].HeaderText = "المورد";
        dataGridView1.Columns[3].HeaderText = "تاريخ الصرف";
        dataGridView1.Columns[4].HeaderText = "رقم الوصل";
        dataGridView1.Columns[5].HeaderText = "المبلغ";
        dataGridView1.Columns[6].HeaderText = "التفاصيل";

        // Hide 
        dataGridView1.Columns[7].Visible = false;
        dataGridView1.Columns[8].Visible = false;
        dataGridView1.Columns[9].Visible = false;
        dataGridView1.Columns[10].Visible = false;
        dataGridView1.Columns[11].Visible = false;
        dataGridView1.Columns[12].Visible = false;


    }

    private void Edit()
    {
        if (dataGridView1.RowCount > 0)
        {
            // Get Id 
            RowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            AddOutComeForm addOutComeForm = new AddOutComeForm(RowId, ProjectId, this);
            addOutComeForm.Show();
        }
        else
        {
            MassageCollection.ShowEmptyDataMassage();
        }
    }

    private void SetIdRowForDelete()
    {
        foreach (DataGridViewRow row in dataGridView1.Rows)
        {
            if (row.Selected)
            {
                IdList.Add(Convert.ToInt32(row.Cells[0].Value));
            }
        }
    }

    public async void Search()
    {
        loadingForm.Show();
        searchItem = textBoxSearch.Text;
        var data = await _dataHelper.SearchAsync(searchItem);
        dataGridView1.DataSource = data.Where(x=>x.ProjectId == ProjectId).ToList();
        if (dataGridView1.DataSource == null)
        {
            MassageCollection.ShowErrorServer();
        }
        else
        {
            SetColumnsTitle();
        }
        data.Clear();
        loadingForm.Hide();
    }

    private DataTable SetDataTableColumns(DataTable table)
    {
        table.Columns["Id"].SetOrdinal(0);
        table.Columns["Id"].ColumnName = "المعرف";

        table.Columns["CategoryName"].SetOrdinal(1);
        table.Columns["CategoryName"].ColumnName = "اسم الصنف";

        table.Columns["SupplierName"].SetOrdinal(2);
        table.Columns["SupplierName"].ColumnName = "المورد";

        table.Columns["OutComeDate"].SetOrdinal(3);
        table.Columns["OutComeDate"].ColumnName = "تاريخ الصرف";

        table.Columns["RecNo"].SetOrdinal(4);
        table.Columns["RecNo"].ColumnName = "رقم الوصل";

        table.Columns["Amount"].SetOrdinal(5);
        table.Columns["Amount"].ColumnName = "المبلغ";

        table.Columns["Detalis"].SetOrdinal(6);
        table.Columns["Detalis"].ColumnName = "التفاصيل";

       
        table.Columns.Remove("Categories");
        table.Columns.Remove("CategoryId");
        table.Columns.Remove("Suppliers");
        table.Columns.Remove("SupplierId");
        table.Columns.Remove("Projects");
        table.Columns.Remove("ProjectId");
        table.AcceptChanges();

        return table;
    }
    private void ExportAsXlsxFile(DataTable dataTableArranged)
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Title = "تصدير البيانات علي شكل أكسل";
        saveFileDialog.DefaultExt = "xlsx";
        saveFileDialog.AddExtension = true;
        saveFileDialog.Filter = "Excel File (.xlsx)|*.xlsx";
        saveFileDialog.RestoreDirectory = true;
        var result = saveFileDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            try
            {
                using (XLWorkbook xlWorkbook = new XLWorkbook())//Create Excel File 
                {
                    xlWorkbook.AddWorksheet(dataTableArranged, "Data");//Add Sheet
                    using (MemoryStream stream = new MemoryStream())
                    {
                        xlWorkbook.SaveAs(stream);
                        File.WriteAllBytes(saveFileDialog.FileName, stream.ToArray());
                    }
                }
                //System.Diagnostics.Process.Start(saveFileDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    #endregion

}
