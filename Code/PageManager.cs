namespace ASRFLY.Code;

public class PageManager
{
    private readonly Main _main;

    public PageManager(Main main)
    {
        _main = main;
    }
    public void LoadPage(UserControl PageUserControl)
    {
        // Load old page
        var oldPage = _main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
        if (oldPage != null)
        {
            _main.panelContainer.Controls.Remove(oldPage);
            oldPage.Dispose();
        }

        // Load New  page
        PageUserControl.Dock=DockStyle.Fill;
        _main.panelContainer.Controls.Add(PageUserControl);
        
    }
}
