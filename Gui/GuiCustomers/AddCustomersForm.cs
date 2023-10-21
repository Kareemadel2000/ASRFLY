namespace ASRFLY.Gui.GuiCustomers;

public partial class AddCustomersForm : Form
{
    //variables
    private readonly int ID;
    private readonly CustomersUserControl _categoryuserControl;
    private Customers customers;
    private readonly IDataHelper<Customers> _dataHelper;
    private readonly LoadingForm loadingForm;
    private readonly IDataHelper<SystemRecord> _dataHelperSystemRecord;


    //ctor
    public AddCustomersForm(int Id, CustomersUserControl categoryuserControl)
    {
        InitializeComponent();
        _dataHelper = (IDataHelper<Customers>)ConfigrationObjectManager.GetObject("Customers");
        _dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.GetObject("SystemRecord");
        loadingForm = new LoadingForm();
        _categoryuserControl = categoryuserControl;
        ID = Id;
        //_customers = customers;
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
                    this.DialogResult = DialogResult.OK;
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
                    this.DialogResult = DialogResult.OK;
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
        customers = new Customers
        {
            Name = textBoxName.Text,
            Address = textBoxAddress.Text,
            PhoneNumber = textBoxPhoneNumber.Text,
            Email = textBoxEmail.Text,
            Details = richTextBoxDetails.Text,
            AddedDate = DateTime.Now
        };
        // Sumbit

        var result = await _dataHelper.AddAsync(customers);
        if (result == 1)
        {
            // Save SystemRecord
            SystemRecord systemRecord = new SystemRecord
            {
                Title = "أضافة عميل",
                UserName = Settings.Default.UserName,
                Details = "تمت أضافه عميل  " + customers.Name,
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
        customers = new Customers
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

        var result = await _dataHelper.EditAsync(customers);
        if (result == 1)
        { // Save SystemRecord
            SystemRecord systemRecord = new SystemRecord
            {
                Title = "تعديل عميل ",
                UserName = Settings.Default.UserName,
                Details = "تم تعديل عميل  " + customers.Name,
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
            customers = await _dataHelper.FindAsync(ID);
            if (customers != null)
            {
                textBoxName.Text = customers.Name;

                textBoxAddress.Text = customers.Address;
                textBoxPhoneNumber.Text = customers.PhoneNumber;
                textBoxEmail.Text = customers.Email;
                textBoxBalance.Text = customers.Balance.ToString();
                
                richTextBoxDetails.Text = customers.Details;
            }
            else
            {
                MassageCollection.ShowErrorServer();
            }
        }
    }
    #endregion

   
}
