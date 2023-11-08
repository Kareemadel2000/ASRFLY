namespace ASRFLY.Gui.GuiSettings;

public partial class SettingsForm : Form
{
    public SettingsForm()
    {
        InitializeComponent();
        SetGenralSettings();
    }

    private void buttonSaveSettings_Click(object sender, EventArgs e)
    {
        SaveGenralSettings();
    }

    private void SaveGenralSettings()
    {
        Properties.Settings.Default.CompanyName = textBoxCompany.Text;
        Properties.Settings.Default.HideNotificationInterval = Convert.ToInt32(numericUpDownnotifications.Value);
        Properties.Settings.Default.DataGridViewRowNo = Convert.ToInt32(numericUpDownDataRow.Value);

        // Save Picture 
        using MemoryStream stream = new MemoryStream();
        {
            pictureBoxLogo.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            Properties.Settings.Default.CompanyLogo = Convert.ToBase64String(stream.ToArray());
        }

        // Save string Data 
        Properties.Settings.Default.Save();
    }
    private void SetGenralSettings()
    {
        textBoxCompany.Text = Properties.Settings.Default.CompanyName;
        numericUpDownnotifications.Value = Properties.Settings.Default.HideNotificationInterval;
        numericUpDownDataRow.Value = Properties.Settings.Default.DataGridViewRowNo;

        // Save Picture 

        if (Properties.Settings.Default.CompanyLogo != null)
        {
            var ImageAsByte = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo);
            using MemoryStream stream = new MemoryStream(ImageAsByte);
            pictureBoxLogo.Image = Image.FromStream(stream);

        }
    }

    private void buttonSaveConnections_Click(object sender, EventArgs e)
    {
        var Server = textBoxServer.Text;
        var DataBase = textBoxDataBase.Text;
        var TimOut = numericUpDownTimeOut.Value;
        var UserName = textBoxUserName.Text;
        var Password = textBoxPassword.Text;
        if (radioButtonLocalConnections.Checked == true)
        {
            // Local con
            SetLocalConnection(Server, DataBase);
        }
        else
        {
            // NetWork con
            SetNetWorkConnection(Server, DataBase, TimOut, UserName, Password);
        }
    }

    // Local con And NetWork con
    private void SetNetWorkConnection(string server, string dataBase, decimal timOut, string userName, string password)
    {
        var ConString = @"Server=" + server + ";Database=" + dataBase + ";User Id= " + userName + ";Password=" + password + "; Timeout=" + timOut + "";
        Properties.Settings.Default.SqlServerConString = ConString;
        Properties.Settings.Default.Save();
    }

    private void SetLocalConnection(string server, string dataBase)
    {
        var ConString = @"Server=" + server + ";Database=" + dataBase + ";Trusted_Connection=True;TrustServerCertificate=True;";
        Properties.Settings.Default.SqlServerConString = ConString;
        Properties.Settings.Default.Save();
    }
}
