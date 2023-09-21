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
    #endregion


}