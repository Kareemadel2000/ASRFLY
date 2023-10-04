namespace ASRFLY.Gui.GuiNotification;

public partial class NotificationForm : Form
{
    public NotificationForm()
    {
        InitializeComponent();
        timerNotifications.Interval = Settings.Default.HideNotificationInterval;
    }

    private void labelTitle_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void timerNotifications_Tick(object sender, EventArgs e)
    {
        Close();
    }
}
