namespace ASRFLY.Gui.GuiHome;

public partial class HomeUserControl : UserControl
{
    private static HomeUserControl _homeUserControl;
    public HomeUserControl()
    {
        InitializeComponent();
    }
    public static HomeUserControl Instance()
    {
        return _homeUserControl ?? (new HomeUserControl());
    }

    private void buttonAddCategory_Click(object sender, EventArgs e)
    {
        
    }
}
