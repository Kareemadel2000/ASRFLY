﻿namespace ASRFLY.Gui.GuiCategories;

public partial class CategoryUserControl : UserControl
{
    //variables
    private readonly IDataHelper<Categories> _dataHelper;
    private readonly IDataHelper<InCome> _dataHelperInCome;
    private readonly IDataHelper<OutCome> _dataHelperOutCome;
    private readonly IDataHelper<SystemRecord> _dataHelperSystemRecord;
    private static CategoryUserControl? _CategoryUserControl;
    private int RowId;
    private readonly LoadingForm loadingForm;
    private List<int> IdList = new List<int>();
    private string searchItem;
    private double Amount;

    //ctor
    public CategoryUserControl()
    {
        InitializeComponent();
        _dataHelper = (IDataHelper<Categories>)ConfigrationObjectManager.GetObject("Categories");
        _dataHelperInCome = (IDataHelper<InCome>)ConfigrationObjectManager.GetObject("InCome");
        _dataHelperOutCome = (IDataHelper<OutCome>)ConfigrationObjectManager.GetObject("OutCome");
        _dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.GetObject("SystemRecord");
        loadingForm = new LoadingForm();
        LaodData();
    }

    #region Events
    private void buttonAdd_Click(object sender, EventArgs e)
    {
        AddCategoryForm addCategoryForm = new AddCategoryForm(0, this);
        addCategoryForm.Show();
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
                                Details = "تم حذف صنف ذى الرقم التعريفي" + RowId.ToString(),
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
        loadingForm.Show();
        var data = await _dataHelper.GetAllDataAsync();
        DataTable table = new DataTable();
        using var reader = ObjectReader.Create(data);
        table.Load(reader);
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

        dataGridView1.DataSource = data.Where(x => x.Id >= dataId[IndexNoOfRow]).Take(Properties.Settings.Default.DataGridViewRowNo).ToList();
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


    #endregion

    #region Methods
    public static CategoryUserControl Instance()
    {
        return _CategoryUserControl ?? (new CategoryUserControl());
    }
    public async void LaodData()
    {
        loadingForm.Show();
        var data = await _dataHelper.GetAllDataAsync();
        //await Task.Run(() => UpdateData());
        dataGridView1.DataSource = data.Take(Properties.Settings.Default.DataGridViewRowNo).ToList();

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
        dataGridView1.Columns[1].HeaderText = "الاسم";
        dataGridView1.Columns[2].HeaderText = "النوع";
        dataGridView1.Columns[3].HeaderText = "التفاصيل";
        dataGridView1.Columns[4].HeaderText = "الرصيد";
        dataGridView1.Columns[5].HeaderText = "تاريخ الاضافة";
    }

    private void Edit()
    {
        if (dataGridView1.RowCount > 0)
        {
            // Get Id 
            RowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            AddCategoryForm addCategoryForm = new AddCategoryForm(RowId, this);
            addCategoryForm.Show();
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
        dataGridView1.DataSource = await _dataHelper.SearchAsync(searchItem);
        if (dataGridView1.DataSource == null)
        {
            MassageCollection.ShowErrorServer();
        }
        else
        {
            SetColumnsTitle();
        }
        loadingForm.Hide();
    }

    private DataTable SetDataTableColumns(DataTable table)
    {
        table.Columns["Id"].SetOrdinal(0);
        table.Columns["Id"].ColumnName = "المعرف";

        table.Columns["Name"].SetOrdinal(1);
        table.Columns["Name"].ColumnName = "الاسم";

        table.Columns["Type"].SetOrdinal(2);
        table.Columns["Type"].ColumnName = "النوع";

        table.Columns["Details"].SetOrdinal(3);
        table.Columns["Details"].ColumnName = "التفاصيل";

        table.Columns["Balance"].SetOrdinal(4);
        table.Columns["Balance"].ColumnName = "الرصيد";

        table.Columns["AddedDate"].SetOrdinal(5);
        table.Columns["AddedDate"].ColumnName = "تاريخ الاضافة";
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

    private void UpdateData()
    {
        //Get Data
        var CategoriesId = _dataHelper.GetAllData().Select(x => x.Id).ToList();
        // for Loops into categoriesId
        for (int i = 0; i < CategoriesId.Count; i++)
        {
            var CategoryId = CategoriesId[i];
            try
            {
                Amount = _dataHelperInCome.GetAllData()
               .Where(x => x.CategoryId == CategoryId)
               .Select(x => x.Amount)
               .ToArray()
               .Sum();
            }
            catch { }

            //Set Data
            Categories categories = _dataHelper.GetAllData()
                .Where(x => x.Id == CategoryId).First();
            categories.Balance = Amount;
            _dataHelper.Edit(categories);
        }

        for (int j = 0; j < CategoriesId.Count; j++)
        {
            var CategoryId = CategoriesId[j];
            try
            {
                Amount = _dataHelperOutCome.GetAllData()
               .Where(x => x.CategoryId == CategoryId)
               .Select(x => x.Amount)
               .ToArray()
               .Sum();
            }
            catch { }

            //Set Data
            Categories categories = _dataHelper.GetAllData()
                .Where(x => x.Id == CategoryId).First();
            categories.Balance = Amount;
            _dataHelper.Edit(categories);
        }
    }

    #endregion

    private async void CategoryUserControl_Leave(object sender, EventArgs e)
    {
        await Task.Run(() => UpdateData());
    }
}
