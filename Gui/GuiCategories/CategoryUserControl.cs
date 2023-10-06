﻿namespace ASRFLY.Gui.GuiCategories;

public partial class CategoryUserControl : UserControl
{
    //variables
    private readonly IDataHelper<Categories> _dataHelper;
    private static CategoryUserControl _CategoryUserControl;
    private int RowId;
    private readonly LoadingForm loadingForm;
    private List<int> IdList = new List<int>();
    private string searchItem;

    //ctor
    public CategoryUserControl()
    {
        InitializeComponent();
        _dataHelper = (IDataHelper<Categories>)ConfigrationObjectManager.GetObject("Categories");
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
    #endregion

    #region Methods
    public static CategoryUserControl Instance()
    {
        return _CategoryUserControl ?? (new CategoryUserControl());
    }
    public async void LaodData()
    {
        loadingForm.Show();
        dataGridView1.DataSource = await _dataHelper.GetAllDataAsync();
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
    #endregion


}
