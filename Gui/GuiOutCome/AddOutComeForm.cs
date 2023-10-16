namespace ASRFLY.Gui.GuiOutCome;

public partial class AddOutComeForm : Form
{
    //variables
    private readonly int ID;
    private readonly OutComeUserControl _outComeUserControl;
    private OutCome outCome;
    private int CategoryId;
    private int SupplierId;
    private int ProjectId;
    private readonly IDataHelper<OutCome> _dataHelper;
    private readonly IDataHelper<Suppliers> _dataHelperSuppliers;
    private readonly IDataHelper<Categories> _dataHelperCategories;
    private readonly LoadingForm loadingForm;
    private readonly IDataHelper<SystemRecord> _dataHelperSystemRecord;


    //ctor
    public AddOutComeForm(int Id, int ProjectId, OutComeUserControl outComeuserControl)
    {
        InitializeComponent();
        _dataHelper = (IDataHelper<OutCome>)ConfigrationObjectManager.GetObject("OutCome");
        _dataHelperSuppliers = (IDataHelper<Suppliers>)ConfigrationObjectManager.GetObject("Suppliers");
        _dataHelperCategories = (IDataHelper<Categories>)ConfigrationObjectManager.GetObject("Categories");
        _dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.GetObject("SystemRecord");
        loadingForm = new LoadingForm();
        _outComeUserControl = outComeuserControl;
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
        outCome = new OutCome
        {
            CategoryName = comboBoxCategory.SelectedItem.ToString(),
            SupplierName = comboBoxSupplier.SelectedItem.ToString(),
            RecNo = textBoxRecNo.Text,
            Detalis = richTextBoxDetails.Text,
            Amount = Convert.ToDouble(textBoxAmount.Text),
            OutComeDate = dateTimePickerDate.Value,
            CategoryId = CategoryId,
            SupplierId = SupplierId,
            ProjectId = ProjectId,
        };
        // Sumbit

        var result = await _dataHelper.AddAsync(outCome);
        if (result == 1)
        {
            // Save SystemRecord
            SystemRecord systemRecord = new SystemRecord
            {
                Title = "أضافة عملية صرف",
                UserName = Settings.Default.UserName,
                Details = "تمت أضافه عملية صرف  " + outCome.CategoryName,
                AddedDate = DateTime.Now,
            };
            await _dataHelperSystemRecord.AddAsync(systemRecord);
            _outComeUserControl.LaodData();
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
        outCome = new OutCome
        {
            Id = ID,
            CategoryName = comboBoxCategory.SelectedItem.ToString(),
            SupplierName = comboBoxSupplier.SelectedItem.ToString(),
            RecNo = textBoxRecNo.Text,
            Detalis = richTextBoxDetails.Text,
            Amount = Convert.ToDouble(textBoxAmount.Text),
            OutComeDate = dateTimePickerDate.Value,
            CategoryId = CategoryId,
            SupplierId = SupplierId,
            ProjectId = ProjectId,
        };
        // Sumbit

        var result = await _dataHelper.EditAsync(outCome);
        if (result == 1)
        { // Save SystemRecord
            SystemRecord systemRecord = new SystemRecord
            {
                Title = "تعديل عملية صرف ",
                UserName = Settings.Default.UserName,
                Details = "تم تعديل عملية صرف  " + outCome.CategoryName,
                AddedDate = DateTime.Now,
            };
            await _dataHelperSystemRecord.AddAsync(systemRecord);
            _outComeUserControl.LaodData();
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
        // Get List Of Suppliers
        var ListSuppliers = await _dataHelperSuppliers.GetAllDataAsync();
        // Fill
        comboBoxSupplier.DataSource = ListSuppliers.Select(x => x.Name).ToList();

        // Auto Complete
        AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
        autoCompleteString.AddRange(ListSuppliers.Select(x => x.Name).ToArray());
        comboBoxSupplier.AutoCompleteCustomSource = autoCompleteString;

        ListSuppliers.Clear();//Clear

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
            outCome = await _dataHelper.FindAsync(ID);

            if (outCome != null)
            {
                comboBoxCategory.SelectedItem = outCome.CategoryName;
                comboBoxSupplier.SelectedItem = outCome.SupplierName;
                textBoxRecNo.Text = outCome.RecNo;
                richTextBoxDetails.Text = outCome.Detalis;
                textBoxAmount.Text = outCome.Amount.ToString();
                dateTimePickerDate.Value = outCome.OutComeDate;
                CategoryId = outCome.CategoryId;
                SupplierId = outCome.SupplierId;
                ProjectId = outCome.ProjectId;
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
        SupplierId = _dataHelperSuppliers.GetAllData().Where(x => x.Name == supplierName)
            .Select(x => x.Id).First();

    }
    #endregion

}
