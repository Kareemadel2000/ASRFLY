using ASRFLY.Gui.GuiCategories;

namespace ASRFLY;

public partial class Main : Form
{
    private readonly PageManager pageManager;
    public Main()
    {
        InitializeComponent();
        pageManager = new PageManager(this);

        // load Home page 
        pageManager.LoadPage(HomeUserControl.Instance());

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

    #endregion




}