﻿namespace ASRFLY.Gui.GuiProjects;

public partial class ProjectsUserControl : UserControl
{
    //variables
    private readonly IDataHelper<Projects> _dataHelper;
    private readonly IDataHelper<InCome> _dataHelperInCome;
    private readonly IDataHelper<OutCome> _dataHelperOutCome;
    private readonly IDataHelper<SystemRecord> _dataHelperSystemRecord;
    private static ProjectsUserControl? _ProjectsUserControl;
    private int RowId;
    private readonly LoadingForm loadingForm;
    private List<int> IdList = new List<int>();
    private string searchItem;
    private double InComeAmount;
    private double OutComeAmount;
    private List<int> ListOfProjectsId = new List<int>();

    //ctor
    public ProjectsUserControl()
    {
        InitializeComponent();
        _dataHelper = (IDataHelper<Projects>)ConfigrationObjectManager.GetObject("Projects");
        _dataHelperInCome = (IDataHelper<InCome>)ConfigrationObjectManager.GetObject("InCome");
        _dataHelperOutCome = (IDataHelper<OutCome>)ConfigrationObjectManager.GetObject("OutCome");
        _dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.GetObject("SystemRecord");
        loadingForm = new LoadingForm();
        LaodData();
    }

    #region Events
    private void buttonAdd_Click(object sender, EventArgs e)
    {
        AddProjectsForm addProjectsForm = new AddProjectsForm(0, this);
        addProjectsForm.Show();
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
                                Details = "تم حذف المشروع ذى الرقم التعريفي" + RowId.ToString(),
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
        ProjectExplor();
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

    private void buttonOpen_Click(object sender, EventArgs e)
    {
        ProjectExplor();
    }


    #endregion

    #region Methods
    public static ProjectsUserControl Instance()
    {
        return _ProjectsUserControl ?? (new ProjectsUserControl());
    }

    private void ProjectExplor()
    {
        if (dataGridView1.RowCount > 0)
        {
            // Get Id 
            RowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProjectManagmentForm projectManagmentForm = new ProjectManagmentForm(RowId);
            projectManagmentForm.Show();
        }
        else
        {
            MassageCollection.ShowEmptyDataMassage();
        }
    }

    public async void LaodData()
    {
        loadingForm.Show();
        var data = await _dataHelper.GetAllDataAsync();
        ListOfProjectsId = data.Select(x => x.Id).ToList();
        await Task.Run(() => UpdateData(ListOfProjectsId));

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
        dataGridView1.Columns[2].HeaderText = "العميل";
        dataGridView1.Columns[3].HeaderText = "العنوان";
        dataGridView1.Columns[4].HeaderText = "الشركةالمنفذة";
        dataGridView1.Columns[5].HeaderText = "بداية المشروع";
        dataGridView1.Columns[6].HeaderText = "نهاية المشروع";
        dataGridView1.Columns[7].HeaderText = "التفاصيل";
        dataGridView1.Columns[8].HeaderText = "المقبوضات";
        dataGridView1.Columns[9].HeaderText = "المصروفات";
        dataGridView1.Columns[10].HeaderText = "الارباح";
        dataGridView1.Columns[11].HeaderText = "تاريخ الاضافة";

        // Hide cloumn
        dataGridView1.Columns[3].Visible = false;
        dataGridView1.Columns[4].Visible = false;
        dataGridView1.Columns[5].Visible = false;
        dataGridView1.Columns[6].Visible = false;
        dataGridView1.Columns[7].Visible = false;
    }

    private void Edit()
    {
        if (dataGridView1.RowCount > 0)
        {
            // Get Id 
            RowId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            AddProjectsForm addProjectsForm = new AddProjectsForm(RowId, this);
            addProjectsForm.Show();
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

        table.Columns["Customer"].SetOrdinal(2);
        table.Columns["Customer"].ColumnName = "العميل";

        table.Columns["Address"].SetOrdinal(3);
        table.Columns["Address"].ColumnName = "العنوان";

        table.Columns["Company"].SetOrdinal(4);
        table.Columns["Company"].ColumnName = "الشركةالمنفذة";

        table.Columns["StartDate"].SetOrdinal(5);
        table.Columns["StartDate"].ColumnName = "بداية المشروع";

        table.Columns["EndDate"].SetOrdinal(6);
        table.Columns["EndDate"].ColumnName = "نهاية المشروع";

        table.Columns["Details"].SetOrdinal(7);
        table.Columns["Details"].ColumnName = "التفاصيل";

        table.Columns["Income"].SetOrdinal(8);
        table.Columns["Income"].ColumnName = "المقبوضات";

        table.Columns["Outcome"].SetOrdinal(9);
        table.Columns["Outcome"].ColumnName = "المصروفات";

        table.Columns["Revenue"].SetOrdinal(10);
        table.Columns["Revenue"].ColumnName = "الارباح";

        table.Columns["AddedDate"].SetOrdinal(11);
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

    private void UpdateData(List<int> ListOfProjectsId)
    {
        //Get Data
        // for Loops into projectsId 
        for (int i = 0; i < ListOfProjectsId.Count; i++)
        {
            var ProjectId = ListOfProjectsId[i];
            try
            {
                //  InComeAmount
                InComeAmount = _dataHelperInCome.GetAllData()
               .Where(x => x.ProjectId == ProjectId)
               .Select(x => x.Amount)
               .ToArray().Sum();

                // OutComeAmount
                OutComeAmount = _dataHelperOutCome.GetAllData()
               .Where(x => x.ProjectId == ProjectId)
               .Select(x => x.Amount)
               .ToArray().Sum();
            }
            catch { }

            //Set Data
            Projects projects = _dataHelper.GetAllData()
                .Where(x => x.Id == ProjectId).First();
            projects.Income = InComeAmount;
            projects.Outcome = OutComeAmount;
            projects.Revenue = InComeAmount - OutComeAmount;
            _dataHelper.Edit(projects);
        }
    }

    #endregion
}
