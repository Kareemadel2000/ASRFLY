namespace ASRFLY.Gui.GuiHome;

public partial class HomeUserControl : UserControl
{
    private static HomeUserControl _homeUserControl;
    public HomeUserControl()
    {
        InitializeComponent();
        //SetRoles();
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
}
