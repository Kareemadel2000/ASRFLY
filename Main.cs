namespace ASRFLY;

public partial class Main : Form
{
    private readonly PageManager pageManager;
    public Main()
    {
        InitializeComponent();
        pageManager = new PageManager(this);
        // UserRolesManager.Register("checkBoxHome", false);
        // UserRolesManager.Register("checkBoxCategories", false);
        // load Home page 
        pageManager.LoadPage(HomeUserControl.Instance());
        //SetRoles();
    }

    #region Events
    private void buttonHome_Click(object sender, EventArgs e)
    {
        // load Home page 
        pageManager.LoadPage(HomeUserControl.Instance());
    }
    private void buttonCategory_Click(object sender, EventArgs e)
    {
        // load Categories page 
        pageManager.LoadPage(CategoryUserControl.Instance());
    }
    private void buttonCustomers_Click(object sender, EventArgs e)
    {
        // load Customers page 
        pageManager.LoadPage(CustomersUserControl.Instance());
    }
    private void buttonSuppliers_Click(object sender, EventArgs e)
    {
        // load Suppliers page 
        pageManager.LoadPage(SuppliersUserControl.Instance());
    }
    private void buttonProjects_Click(object sender, EventArgs e)
    {
        // load Prpjects page 
        pageManager.LoadPage(ProjectsUserControl.Instance());
    }
    private void buttonUsers_Click(object sender, EventArgs e)
    {
        // load Users page 
        pageManager.LoadPage(UsersControl.Instance());
    }

    private void SetRoles()
    {
        if (!UserRolesManager.GetRole("checkBoxHome"))
        {
            buttonHome.Visible = false;
        }
        //if (!UserRolesManager.GetRole("checkBoxCategories"))
        //{
        //    buttonCategory.Visible = false;
        //}
    }
    #endregion


    private void buttonSettings_Click(object sender, EventArgs e)
    {
        Gui.GuiSettings.SettingsForm settingsForm = new Gui.GuiSettings.SettingsForm(false);
        settingsForm.Show();
    }

    private void Main_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void buttonLogOut_Click(object sender, EventArgs e)
    {
        UserLogInForm logInForm = new UserLogInForm();
        logInForm.Show();
        Hide();
    }
}