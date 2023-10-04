namespace ASRFLY.Gui.GuiCategories;

public partial class AddCategoryForm : Form
{
    //variables
    private readonly int ID;
    private readonly CategoryUserControl _categoryuserControl;
    private Categories categories;
    private readonly IDataHelper<Categories> _dataHelper;
    private readonly LoadingForm loadingForm;

    //ctor
    public AddCategoryForm(int Id, CategoryUserControl categoryuserControl)
    {
        InitializeComponent();
        _dataHelper = (IDataHelper<Categories>)ConfigrationObjectManager.GetObject("Categories");
        loadingForm = new LoadingForm();
        _categoryuserControl = categoryuserControl;
        ID = Id;
        //_categories = categories;
    }

    #region Events
    private async void buttonSaveAndClose_Click(object sender, EventArgs e)
    {
        if (IsFiledsEmpty())
        {
            MassageCollection.ShowFieldsRquired();
        }
        else
        {
            loadingForm.Show();
            if (await SavaData())
            {
                Close();
            }
            else
            {
                MassageCollection.ShowErrorServer();
            }
            loadingForm.Hide();
        }
    }

    private async void buttonSave_Click(object sender, EventArgs e)
    {

        if (IsFiledsEmpty())
        {
            MassageCollection.ShowFieldsRquired();
        }
        else
        {
            loadingForm.Show();
            if (await SavaData())
            {

            }
            else
            {
                MassageCollection.ShowErrorServer();
            }
            loadingForm.Hide();
        }
    }
    #endregion

    //Method 
    #region SavaData
    private async Task<bool> SavaData()
    {

        if (ID == 0)    //Add 
        {
            return await AddData();
        }
        else        //Edit
        {
            return await EditData();
        }

    }
    #endregion

    #region IsFiledsEmpty
    private bool IsFiledsEmpty()
    {
        if (textBoxName.Text == string.Empty || comboBoxType.Text == string.Empty)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    #endregion

    #region AddData
    private async Task<bool> AddData()
    {
        // Set Data 
        categories = new Categories
        {
            Name = textBoxName.Text,
            Type = comboBoxType.SelectedItem.ToString()!,
            Details = richTextBoxDetails.Text,
            AddedDate = DateTime.Now
        };
        // Sumbit

        var result = await _dataHelper.AddAsync(categories);
        if (result == 1)
        {
            _categoryuserControl.LaodData();
            return true;
        }
        else
        {
            return false;
        }

    }
    #endregion

    #region EditData
    private async Task<bool> EditData()
    {
        // Set Data 
        categories = new Categories
        {
            Id = ID,
            Name = textBoxName.Text,
            Type = comboBoxType.SelectedItem.ToString()!,
            Details = richTextBoxDetails.Text,
            AddedDate = DateTime.Now
        };
        // Sumbit

        var result = await _dataHelper.EditAsync(categories);
        if (result == 1)
        {
            _categoryuserControl.LaodData();
            return true;
        }
        else
        {
            return false;
        }

    }
    #endregion
}
