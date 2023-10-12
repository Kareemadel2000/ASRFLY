namespace ASRFLY.Gui.GuiSuppliers;

public partial class AddSuppliersForm : Form
{
    //variables
    private readonly int ID;
    private readonly SuppliersUserControl _categoryuserControl;
    private Suppliers suppliers;
    private readonly IDataHelper<Suppliers> _dataHelper;
    private readonly LoadingForm loadingForm;
    private readonly IDataHelper<SystemRecord> _dataHelperSystemRecord;


    //ctor
    public AddSuppliersForm(int Id, SuppliersUserControl categoryuserControl)
    {
        InitializeComponent();
        _dataHelper = (IDataHelper<Suppliers>)ConfigrationObjectManager.GetObject("Suppliers");
        _dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.GetObject("SystemRecord");
        loadingForm = new LoadingForm();
        _categoryuserControl = categoryuserControl;
        ID = Id;
        //_suppliers = suppliers;
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
                if (ID == 0)
                {
                    MassageCollection.ShowAddNotifications();
                }
                else
                {
                    MassageCollection.ShowUpdateNotifications();
                }
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
                if (ID == 0)
                {
                    MassageCollection.ShowAddNotifications();
                }
                else
                {
                    MassageCollection.ShowUpdateNotifications();
                }
            }
            else
            {
                MassageCollection.ShowErrorServer();
            }
            loadingForm.Hide();
        }
    }

    private void AddCategoryForm_Load(object sender, EventArgs e)
    {
        loadingForm.Show();
        SetFieldData();
        loadingForm.Hide();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {
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
        if (textBoxName.Text == string.Empty)
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
        suppliers = new Suppliers
        {
            Name = textBoxName.Text,
            Address = textBoxAddress.Text,
            PhoneNumber = textBoxPhoneNumber.Text,
            Email = textBoxEmail.Text,
            Details = richTextBoxDetails.Text,
            AddedDate = DateTime.Now
        };
        // Sumbit

        var result = await _dataHelper.AddAsync(suppliers);
        if (result == 1)
        {
            // Save SystemRecord
            SystemRecord systemRecord = new SystemRecord
            {
                Title = "أضافة مورد",
                UserName = Settings.Default.UserName,
                Details = "تمت أضافه مورد  " + suppliers.Name,
                AddedDate = DateTime.Now,
            };
            await _dataHelperSystemRecord.AddAsync(systemRecord);
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
        suppliers = new Suppliers
        {
            Id = ID,
            Name = textBoxName.Text,
            Address = textBoxAddress.Text,
            PhoneNumber = textBoxPhoneNumber.Text,
            Email = textBoxEmail.Text,
            Details = richTextBoxDetails.Text,
            AddedDate = DateTime.Now
        };
        // Sumbit

        var result = await _dataHelper.EditAsync(suppliers);
        if (result == 1)
        { // Save SystemRecord
            SystemRecord systemRecord = new SystemRecord
            {
                Title = "تعديل مورد ",
                UserName = Settings.Default.UserName,
                Details = "تم تعديل مورد  " + suppliers.Name,
                AddedDate = DateTime.Now,
            };
            await _dataHelperSystemRecord.AddAsync(systemRecord);
            _categoryuserControl.LaodData();
            return true;
        }
        else
        {
            return false;
        }

    }
    #endregion

    #region SetFieldData
    private async void SetFieldData()
    {
        if (ID > 0)
        {
            // Set Fields
            suppliers = await _dataHelper.FindAsync(ID);
            if (suppliers != null)
            {
                textBoxName.Text = suppliers.Name;
                textBoxAddress.Text = suppliers.Address;
                textBoxPhoneNumber.Text = suppliers.PhoneNumber;
                textBoxEmail.Text = suppliers.Email;
                textBoxBalance.Text = suppliers.Balance.ToString();
                richTextBoxDetails.Text = suppliers.Details;
            }
            else
            {
                MassageCollection.ShowErrorServer();
            }
        }
    }
    #endregion


    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }
}
