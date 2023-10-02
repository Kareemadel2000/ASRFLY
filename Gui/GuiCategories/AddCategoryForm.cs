namespace ASRFLY.Gui.GuiCategories;

public partial class AddCategoryForm : Form
{
    private readonly int ID;
    private readonly CategoryUserControl _categoryuserControl;
    private Categories categories;
    private readonly IDataHelper<Categories> _dataHelper;
    private readonly LoadingForm loadingForm;


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

    }

    private async void buttonSave_Click(object sender, EventArgs e)
    {
        //Check field is Empty
        if (IsFiledsEmpty())
        {
            MassageCollection.ShowFieldsRquired();
        }
        else
        {
            if (ID == 0)    //Add 
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
                loadingForm.Show();
                var result = await _dataHelper.AddAsync(categories);
                if (result == 1)
                {
                    //toast
                }
                else
                {
                    MassageCollection.ShowErrorServer();
                }
                loadingForm.Close();
            }
            else        //Edit
            {

            }
        }
    }
    #endregion

    //Method 
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

}
