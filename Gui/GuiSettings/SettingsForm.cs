namespace ASRFLY.Gui.GuiSettings;

public partial class SettingsForm : Form
{
    private LoadingForm loading;
    private readonly bool firstStart;

    public SettingsForm(bool FirstStart)
    {
        InitializeComponent();
        SetGenralSettings();
        loading = new LoadingForm();
        firstStart = FirstStart;
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
        MessageBox.Show("تم حفظ الأعدادات بنجاح");
    }
    private void SetGenralSettings()
    {
        textBoxCompany.Text = Properties.Settings.Default.CompanyName;
        numericUpDownnotifications.Value = Convert.ToInt32(Properties.Settings.Default.HideNotificationInterval / 1000);
        numericUpDownDataRow.Value = Properties.Settings.Default.DataGridViewRowNo;

        // Save Picture 

        if (Properties.Settings.Default.CompanyLogo != string.Empty)
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
        MessageBox.Show("تم حفظ نص الاتصال بنجاح سيتم  أعد تشغيل البرنامج ");
        Application.Exit();

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

    private void SettingsForm_Activated(object sender, EventArgs e)
    {

    }

    private void radioButtonLocalConnections_CheckedChanged(object sender, EventArgs e)
    {
        textBoxUserName.Enabled = false;
        textBoxPassword.Enabled = false;
        numericUpDownTimeOut.Enabled = false;
    }

    private void radioButtonNetworkConnections_CheckedChanged(object sender, EventArgs e)
    {
        textBoxUserName.Enabled = true;
        textBoxPassword.Enabled = true;
        numericUpDownTimeOut.Enabled = true;
    }

    private void linkLabelImportImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Title = "أختار شعار المؤسسة";
        openFileDialog.RestoreDirectory = true;
        var result = openFileDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
            pictureBoxLogo.Image = Image.FromFile(openFileDialog.FileName);
        }
    }

    private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (firstStart == true)
        {
            Application.Exit();
        } 
    }
}
