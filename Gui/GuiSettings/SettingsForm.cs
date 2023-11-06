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
        
    }
}
