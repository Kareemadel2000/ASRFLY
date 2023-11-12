namespace ASRFLY.Gui.GuiHome;

public partial class HomeUserControl : UserControl
{
    private static HomeUserControl _homeUserControl;
    public HomeUserControl()
    {
        InitializeComponent();
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
}
