namespace ASRFLY.Gui.GuiInCome;

public partial class AddInComeForm : Form
{
    //variables
    private readonly int ID;
    private readonly InComeUserControl _InComeUserControl;
    private InCome inCome;
    private int CategoryId;
    private int SupplierId;
    private int ProjectId;
    private readonly IDataHelper<InCome> _dataHelper;
    private readonly IDataHelper<Customers> _dataHelperCustomers;
    private readonly IDataHelper<Categories> _dataHelperCategories;
    private readonly LoadingForm loadingForm;
    private readonly IDataHelper<SystemRecord> _dataHelperSystemRecord;


    //ctor
    public AddInComeForm(int Id, int ProjectId, InComeUserControl InComeUserControl)
    {
        InitializeComponent();
        _dataHelper = (IDataHelper<InCome>)ConfigrationObjectManager.GetObject("InCome");
        _dataHelperCustomers = (IDataHelper<Customers>)ConfigrationObjectManager.GetObject("Customers");
        _dataHelperCategories = (IDataHelper<Categories>)ConfigrationObjectManager.GetObject("Categories");
        _dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.GetObject("SystemRecord");
        loadingForm = new LoadingForm();
        _InComeUserControl = InComeUserControl;
        ID = Id;
        this.ProjectId = ProjectId;
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

    private async void linkLabelnewCateory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        AddCategoryForm addCategoryForm = new AddCategoryForm(0, new CategoryUserControl());
        var result = addCategoryForm.ShowDialog();
        if (result == DialogResult.OK)
        {
            // Get List Of Categories
            var ListCategories = await _dataHelperCategories.GetAllDataAsync();
            // Fill
            comboBoxCategory.DataSource = ListCategories.Select(x => x.Name).ToList();

            // Auto Complete
            AutoCompleteStringCollection autoCompleteStringCategory = new AutoCompleteStringCollection();
            autoCompleteStringCategory.AddRange(ListCategories.Select(x => x.Name).ToArray());
            comboBoxSupplier.AutoCompleteCustomSource = autoCompleteStringCategory;

            ListCategories.Clear();//Clear

        }
    }

    private async void linkLabelnewCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        AddCustomersForm addCustomersForm = new AddCustomersForm(0, new CustomersUserControl());
        var result = addCustomersForm.ShowDialog();
        if (result == DialogResult.OK)
        {
            // Get List Of Customers
            var ListCustomers = await _dataHelperCustomers.GetAllDataAsync();
            // Fill
            comboBoxSupplier.DataSource = ListCustomers.Select(x => x.Name).ToList();

            // Auto Complete
            AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
            autoCompleteString.AddRange(ListCustomers.Select(x => x.Name).ToArray());
            comboBoxSupplier.AutoCompleteCustomSource = autoCompleteString;

            ListCustomers.Clear();//Clear

        }
    }

    private void AddInComeForm_Activated(object sender, EventArgs e)
    {
        //SetFieldData();
    }
    #endregion

    //Method 
    #region SavaData
    private async Task<bool> SavaData()
    {

        if (ID == 0)    //Add 
        {
            var CategoryName = comboBoxCategory.SelectedItem.ToString();
            var supplierName = comboBoxSupplier.SelectedItem.ToString();

            await Task.Run(() => SetCategoryID(CategoryName));
            await Task.Run(() => SetSupplierID(supplierName));
            return await AddData();
        }
        else        //Edit
        {
            var CategoryName = comboBoxCategory.SelectedItem.ToString();
            var supplierName = comboBoxSupplier.SelectedItem.ToString();

            await Task.Run(() => SetCategoryID(CategoryName));
            await Task.Run(() => SetSupplierID(supplierName));
            return await EditData();
        }

    }
    #endregion

    #region IsFiledsEmpty
    private bool IsFiledsEmpty()
    {
        if (textBoxAmount.Text == string.Empty ||
            comboBoxCategory.SelectedItem == null ||
            comboBoxSupplier.SelectedItem == null)
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
        inCome = new InCome
        {
            CategoryName = comboBoxCategory.SelectedItem.ToString(),
            SupplierName = comboBoxSupplier.SelectedItem.ToString(),
            RecNo = textBoxRecNo.Text,
            Detalis = richTextBoxDetails.Text,
            Amount = Convert.ToDouble(textBoxAmount.Text),
            InComeDate = dateTimePickerDate.Value,
            CategoryId = CategoryId,
            SupplierId = SupplierId,
            ProjectId = ProjectId,
        };
        // Sumbit

        var result = await _dataHelper.AddAsync(inCome);
        if (result == 1)
        {
            // Save SystemRecord
            SystemRecord systemRecord = new SystemRecord
            {
                Title = "أضافة عملية قبض",
                UserName = Settings.Default.UserName,
                Details = "تمت أضافه عملية قبض  " + inCome.CategoryName,
                AddedDate = DateTime.Now,
            };
            await _dataHelperSystemRecord.AddAsync(systemRecord);
            _InComeUserControl.LaodData();
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
        inCome = new InCome
        {
            Id = ID,
            CategoryName = comboBoxCategory.SelectedItem.ToString(),
            SupplierName = comboBoxSupplier.SelectedItem.ToString(),
            RecNo = textBoxRecNo.Text,
            Detalis = richTextBoxDetails.Text,
            Amount = Convert.ToDouble(textBoxAmount.Text),
            InComeDate = dateTimePickerDate.Value,
            CategoryId = CategoryId,
            SupplierId = SupplierId,
            ProjectId = ProjectId,
        };
        // Sumbit

        var result = await _dataHelper.EditAsync(inCome);
        if (result == 1)
        { // Save SystemRecord
            SystemRecord systemRecord = new SystemRecord
            {
                Title = "تعديل عملية قبض ",
                UserName = Settings.Default.UserName,
                Details = "تم تعديل عملية قبض  " + inCome.CategoryName,
                AddedDate = DateTime.Now,
            };
            await _dataHelperSystemRecord.AddAsync(systemRecord);
            _InComeUserControl.LaodData();
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
        // Get List Of Customers
        var ListCustomers = await _dataHelperCustomers.GetAllDataAsync();
        // Fill
        comboBoxSupplier.DataSource = ListCustomers.Select(x => x.Name).ToList();

        // Auto Complete
        AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
        autoCompleteString.AddRange(ListCustomers.Select(x => x.Name).ToArray());
        comboBoxSupplier.AutoCompleteCustomSource = autoCompleteString;

        ListCustomers.Clear();//Clear

        /////////////////////////////////////
        // Get List Of Categories
        var ListCategories = await _dataHelperCategories.GetAllDataAsync();
        // Fill
        comboBoxCategory.DataSource = ListCategories.Select(x => x.Name).ToList();

        // Auto Complete
        AutoCompleteStringCollection autoCompleteStringCategory = new AutoCompleteStringCollection();
        autoCompleteStringCategory.AddRange(ListCategories.Select(x => x.Name).ToArray());
        comboBoxSupplier.AutoCompleteCustomSource = autoCompleteStringCategory;

        ListCategories.Clear();//Clear

        if (ID > 0)
        {
            // Set Fields
            inCome = await _dataHelper.FindAsync(ID);

            if (inCome != null)
            {
                comboBoxCategory.SelectedItem = inCome.CategoryName;
                comboBoxSupplier.SelectedItem = inCome.SupplierName;
                textBoxRecNo.Text = inCome.RecNo;
                richTextBoxDetails.Text = inCome.Detalis;
                textBoxAmount.Text = inCome.Amount.ToString();
                dateTimePickerDate.Value = inCome.InComeDate;
                CategoryId = inCome.CategoryId;
                SupplierId = inCome.SupplierId;
                ProjectId = inCome.ProjectId;
            }
            else
            {
                MassageCollection.ShowErrorServer();
            }
        }
    }
    #endregion

    #region SetCategoryID
    private void SetCategoryID(string CategoryName)
    {
        CategoryId = _dataHelperCategories.GetAllData().Where(x => x.Name == CategoryName)
            .Select(x => x.Id).First();
    }
    #endregion

    #region SetSupplierID
    private void SetSupplierID(string supplierName)
    {
        SupplierId = _dataHelperCustomers.GetAllData().Where(x => x.Name == supplierName)
            .Select(x => x.Id).First();

    }
    #endregion

}
