using ASRFLY.Gui.GuiSettings;

namespace ASRFLY;

public partial class StartForm : Form
{
    private readonly IDataHelper<Users> _dataHelper;
    public StartForm()
    {
        InitializeComponent();
        _dataHelper = (IDataHelper<Users>)ConfigrationObjectManager.GetObject("Users");
    }

    private async void CheckCon()
    {
        ApplicationDBContext dB = new ApplicationDBContext();
        if (await dB.Database.CanConnectAsync())
        {
            labelstate.Text = "جارى الاتصال بقاعدة البيانات ";
            var data = await _dataHelper.GetAllDataAsync();
            if (data.Count > 0)
            {
                // Login form
                UserLogInForm logInForm = new UserLogInForm();
                logInForm.Show();
                Hide();
            }
            else
            {
                // Add form
                AddUserForm userForm = new AddUserForm(0, new UsersControl(), true);
                userForm.Show();
                Hide();
            }
        }
        else
        {
            var result = MessageBox.Show("هناك خطا في الاتصال بقاعدة البيانات , أضغط نعم لضبط الاتصال أو لا للخروج من البرنامج", "خطا في الاتصال",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SettingsForm settingsForm = new SettingsForm(true);
                settingsForm.Show();
            }
            else
            {
                Application.Exit();
            }
        }

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        CheckCon();
    }
}
