namespace ASRFLY.Gui.GuiProjects;

public partial class AddProjectsForm : Form
{
    //variables
    private readonly int ID;
    private readonly ProjectsUserControl _projectsUserControl;
    private Projects projects;
    private readonly IDataHelper<Projects> _dataHelper;
    private readonly IDataHelper<Customers> _dataHelperCustomers;
    private readonly LoadingForm loadingForm;
    private readonly IDataHelper<SystemRecord> _dataHelperSystemRecord;


    //ctor
    public AddProjectsForm(int Id, ProjectsUserControl projectsuserControl)
    {
        InitializeComponent();
        _dataHelper = (IDataHelper<Projects>)ConfigrationObjectManager.GetObject("Projects");
        _dataHelperCustomers = (IDataHelper<Customers>)ConfigrationObjectManager.GetObject("Customers");
        _dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.GetObject("SystemRecord");
        loadingForm = new LoadingForm();
        _projectsUserControl = projectsuserControl;
        ID = Id;
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
        projects = new Projects
        {
            Name = textBoxName.Text,
            Customer = comboBoxCustomer.Text,
            Address = textBoxAddress.Text,
            Company = textBoxComapany.Text,
            StartDate = dateTimePickerStartDate.Value,
            EndDate = dateTimePickerEndDate.Value,
            Details = richTextBoxDetails.Text,
            Income = Convert.ToDouble(textBoxIncome.Text),
            Outcome = Convert.ToDouble(textBoxOutcome.Text),
            Revenue = Convert.ToDouble(textBoxRevenue.Text),
            AddedDate = DateTime.Now
        };
        // Sumbit

        var result = await _dataHelper.AddAsync(projects);
        if (result == 1)
        {
            // Save SystemRecord
            SystemRecord systemRecord = new SystemRecord
            {
                Title = "أضافة مشروع",
                UserName = Settings.Default.UserName,
                Details = "تمت أضافه مشروع  " + projects.Name,
                AddedDate = DateTime.Now,
            };
            await _dataHelperSystemRecord.AddAsync(systemRecord);
            _projectsUserControl.LaodData();
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
        projects = new Projects
        {
            Id = ID,
            Name = textBoxName.Text,
            Customer = comboBoxCustomer.Text,
            Address = textBoxAddress.Text,
            Company = textBoxComapany.Text,
            StartDate = dateTimePickerStartDate.Value,
            EndDate = dateTimePickerEndDate.Value,
            Details = richTextBoxDetails.Text,
            Income = Convert.ToDouble(textBoxIncome.Text),
            Outcome = Convert.ToDouble(textBoxOutcome.Text),
            Revenue = Convert.ToDouble(textBoxRevenue.Text),
            AddedDate = DateTime.Now
        };
        // Sumbit

        var result = await _dataHelper.EditAsync(projects);
        if (result == 1)
        { // Save SystemRecord
            SystemRecord systemRecord = new SystemRecord
            {
                Title = "تعديل مشروع ",
                UserName = Settings.Default.UserName,
                Details = "تم تعديل مشروع  " + projects.Name,
                AddedDate = DateTime.Now,
            };
            await _dataHelperSystemRecord.AddAsync(systemRecord);
            _projectsUserControl.LaodData();
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
            // Get List Of Customers
            var ListCustomers = await _dataHelperCustomers.GetAllDataAsync();
            // Fill
            comboBoxCustomer.DataSource = ListCustomers.Select(x => x.Name).ToList();

            // Auto Complete
            AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
            autoCompleteString.AddRange(ListCustomers.Select(x => x.Name).ToArray());
            comboBoxCustomer.AutoCompleteCustomSource = autoCompleteString;

            ListCustomers.Clear();//Clear

            // Set Fields
            projects = await _dataHelper.FindAsync(ID);

            if (projects != null)
            {
                textBoxName.Text = projects.Name;
                comboBoxCustomer.Text = projects.Customer;
                textBoxAddress.Text = projects.Address;
                textBoxComapany.Text = projects.Company;
                dateTimePickerStartDate.Value = projects.StartDate;
                dateTimePickerEndDate.Value = projects.EndDate;
                richTextBoxDetails.Text = projects.Details;
                textBoxIncome.Text = projects.Income.ToString();
                textBoxOutcome.Text = projects.Outcome.ToString();
                textBoxRevenue.Text = projects.Revenue.ToString();
            }
            else
            {
                MassageCollection.ShowErrorServer();
            }
        }
    }
    #endregion
}
