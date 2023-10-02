namespace ASRFLY.Gui.GuiCategories;

public partial class AddCategoryForm : Form
{
    //variables
    private readonly int ID;
    private readonly CategoryUserControl _categoryuserControl;
    private Categories categories;
    private readonly IDataHelper<Categories> _dataHelper;
    private readonly LoadingForm loadingForm;
    private bool IsSaveDataSuccess;
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
    private void buttonSaveAndClose_Click(object sender, EventArgs e)
    {
        if (!SavaData())
        {
            Close();
        }
        IsSaveDataSuccess = false;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        SavaData();
        IsSaveDataSuccess = false;
    }
    #endregion

    //Method 
    #region SavaData
    private bool SavaData()
    {
        //Check field is Empty
        if (IsFiledsEmpty())
        {
            MassageCollection.ShowFieldsRquired();

        }
        else
        {
            loadingForm.Show();
            if (ID == 0)    //Add 
            {
                AddData();
            }
            else        //Edit
            {
                EditData();
            }
            loadingForm.Hide();
        }
        return IsSaveDataSuccess;
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
    private async void AddData()
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
            //toast
            _categoryuserControl.LaodData();
            IsSaveDataSuccess = true;
            MessageBox.Show("تمت عملية الاضافه بنجاح..");
        }
        else
        {
            MassageCollection.ShowErrorServer();
        }

    }
    #endregion

    #region EditData
    private async void EditData()
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
            //toast
            MessageBox.Show("تمت عملية التعديل بنجاح..");
            IsSaveDataSuccess = true;
        }
        else
        {
            MassageCollection.ShowErrorServer();
        }

    }
    #endregion
}
