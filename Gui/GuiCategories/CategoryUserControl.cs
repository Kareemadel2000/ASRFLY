
namespace ASRFLY.Gui.GuiCategories;

public partial class CategoryUserControl : UserControl
{
    //variables
    private readonly IDataHelper<Categories> _dataHelper;
    private static CategoryUserControl _CategoryUserControl;
    private readonly LoadingForm loadingForm;
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
        MassageCollection.ShowEmptyDataMassage();
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {

    }

    private void buttonExport_Click(object sender, EventArgs e)
    {

    }

    private void buttonSearch_Click(object sender, EventArgs e)
    {

    }

    private void buttonUpdate_Click(object sender, EventArgs e)
    {
        LaodData();
    }

    private void textBoxSearch_TextChanged(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

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
    #endregion

   
}
