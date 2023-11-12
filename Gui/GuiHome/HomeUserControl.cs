using ASRFLY.Core.Entityes;

namespace ASRFLY.Gui.GuiHome;

public partial class HomeUserControl : UserControl
{
    private static HomeUserControl _homeUserControl;
    private int ProjectId;
    private readonly IDataHelper<Projects> _dataHelper;

    public HomeUserControl()
    {
        InitializeComponent();
        _dataHelper = (IDataHelper<Projects>)ConfigrationObjectManager.GetObject("Projects");
        //SetRoles();
        SetGenralSettings();
        SetHello();
    }
    public static HomeUserControl Instance()
    {
        return _homeUserControl ?? (new HomeUserControl());
    }

    private void SetRoles()
    {
        if (!UserRolesManager.GetRole("checkBoxAccessCategory"))
        {
            buttonAddCategory.Visible = false;
        }
        //if (!UserRolesManager.GetRole("checkBoxCategories"))
        //{
        //    buttonCategory.Visible = false;
        //}
    }
    private void SetGenralSettings()
    {
        labelCompanyName.Text = Properties.Settings.Default.CompanyName;

        // Save Picture 

        if (Properties.Settings.Default.CompanyLogo != string.Empty)
        {
            var ImageAsByte = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo);
            using MemoryStream stream = new MemoryStream(ImageAsByte);
            pictureBoxLogo.Image = Image.FromStream(stream);

        }
    }

    private void SetHello()
    {
        labelWellcome.Text = "مرحبا بك " + Properties.Settings.Default.UserName;
    }

    private void buttonAddCategory_Click(object sender, EventArgs e)
    {
        AddCategoryForm addCategoryForm = new AddCategoryForm(0, new CategoryUserControl());
        addCategoryForm.Show();
    }

    private void buttonAddCustomers_Click(object sender, EventArgs e)
    {
        AddCustomersForm addCustomersForm = new AddCustomersForm(0, new CustomersUserControl());
        addCustomersForm.Show();
    }

    private void buttonAddSuppliers_Click(object sender, EventArgs e)
    {
        AddSuppliersForm addSuppliersForm = new AddSuppliersForm(0, new SuppliersUserControl());
        addSuppliersForm.Show();
    }

    private void buttonAddProjects_Click(object sender, EventArgs e)
    {
        AddProjectsForm addProjectsForm = new AddProjectsForm(0, new ProjectsUserControl());
        addProjectsForm.Show();
    }

    private void buttonAddUsers_Click(object sender, EventArgs e)
    {
        AddUserForm addCategoryForm = new AddUserForm(0, new UsersControl(), false);
        addCategoryForm.Show();
    }

    private void labelCompanyName_Click(object sender, EventArgs e)
    {

    }

    private async void HomeUserControl_Load(object sender, EventArgs e)
    {
        // Get List Of Suppliers
        var ListOfProject = await _dataHelper.GetAllDataAsync();
        // Fill
        comboBoxProject.DataSource = ListOfProject.Select(x => x.Name).ToList();

        // Auto Complete
        AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
        autoCompleteString.AddRange(ListOfProject.Select(x => x.Name).ToArray());
        comboBoxProject.AutoCompleteCustomSource = autoCompleteString;

        ListOfProject.Clear();//Clear
    }

    private void comboBoxProject_SelectedIndexChanged(object sender, EventArgs e)
    {
        var projectName = comboBoxProject.SelectedItem.ToString();
        ProjectId = _dataHelper.GetAllData().Where(x => x.Name == projectName).Select(x => x.Id).FirstOrDefault();

    }

    private void buttonAddOutput_Click(object sender, EventArgs e)
    {
        if (ProjectId > 0)
        {
            AddOutComeForm addOutComeForm = new AddOutComeForm(0, ProjectId, new OutComeUserControl(ProjectId));
            addOutComeForm.Show();
        }
        else
        {
            MessageBox.Show("أختار المشروع لطفا");
        }
    }

    private void buttonAddInput_Click(object sender, EventArgs e)
    {
        if (ProjectId > 0)
        {
            AddInComeForm addInComeForm = new AddInComeForm(0, ProjectId, new InComeUserControl(ProjectId));
            addInComeForm.Show();
        }
        else
        {
            MessageBox.Show("أختار المشروع لطفا");
        }
    }
}
