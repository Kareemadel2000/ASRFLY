namespace ASRFLY.Gui.GuiUsers;

public partial class UserLogInForm : Form
{
    //variables
    private readonly int ID;
    private readonly UsersControl _userControl;
    private Users users;
    private readonly IDataHelper<Users> _dataHelper;
    private readonly IDataHelper<UsersRoles> _dataHelperUsersRoles;
    private readonly LoadingForm loadingForm;
    private readonly IDataHelper<SystemRecord> _dataHelperSystemRecord;
    private Dictionary<string, bool> ListOfRoles = new Dictionary<string, bool>();


    //ctor
    public UserLogInForm()
    {
        InitializeComponent();
        _dataHelper = (IDataHelper<Users>)ConfigrationObjectManager.GetObject("Users");
        _dataHelperUsersRoles = (IDataHelper<UsersRoles>)ConfigrationObjectManager.GetObject("UsersRoles");
        _dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.GetObject("SystemRecord");
        loadingForm = new LoadingForm();
    }

    #region Events

    private async void buttonSave_Click(object sender, EventArgs e)
    {
        if (IsFiledsEmpty())
        {
            MassageCollection.ShowFieldsRquired();
        }
        else
        {
            var userName = textBoxUserName.Text;
            var password = textBoxPassword.Text;
            loadingForm.Show();
            var UserLoginResult = await Task.Run(() => LogIn(userName, password));
            if (UserLoginResult == 1)
            {
                Main main = new Main();
                main.Show();
                Hide();
            }
            else if (UserLoginResult == 2)
            {
                MassageCollection.ShowErrorServer();
            }
            else
            {
                MessageBox.Show("هناك خطأ في معلومات تسجيل الدخول");
            }
            loadingForm.Hide();
        }
    }
    #endregion

    //Method 

    #region IsFiledsEmpty
    private bool IsFiledsEmpty()
    {
        if (textBoxUserName.Text == string.Empty
            || textBoxPassword.Text == string.Empty)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    #endregion

    #region LogIn
    private int LogIn(string UserName, string Password)
    {
        try
        {
            // Check
            Users? user = _dataHelper.GetAllData().Where(x => x.UserName == UserName && x.Password == Password).FirstOrDefault();
            if (user != null)
            {
                Properties.Settings.Default.UserName = user.FullName;
                Properties.Settings.Default.Save();
                // Get Roles
                var ListRoles = _dataHelperUsersRoles.GetAllData().Where(x => x.UserId == user.Id);

                // Loops Into List Of  UsersRole  and Set Roles 
                UserRolesManager.ClearRoles();
                foreach (var item in ListOfRoles)
                {
                    UserRolesManager.Register(item.Key, item.Value);
                }

                // Save SystemRecord
                SystemRecord systemRecord = new SystemRecord
                {
                    Title = "تسجيل دخول",
                    UserName = Settings.Default.UserName,
                    Details = "تم تسجيل دخول المستخدم " + user.UserName,
                    AddedDate = DateTime.Now
                };
                _dataHelperSystemRecord.Add(systemRecord);
                return 1;
            }
            else
            {
                return 0;
            }
        }
        catch
        {
            return 2;
        }

    }
    #endregion

    private void UserLogInForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}
