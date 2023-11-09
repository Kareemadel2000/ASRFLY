namespace ASRFLY.Gui.GuiUsers;

public partial class AddUserForm : Form
{
    //variables
    private readonly int ID;
    private readonly UsersControl _userControl;
    private readonly bool firstStart;
    private Users users;
    private readonly IDataHelper<Users> _dataHelper;
    private readonly IDataHelper<UsersRoles> _dataHelperUsersRoles;
    private readonly LoadingForm loadingForm;
    private readonly IDataHelper<SystemRecord> _dataHelperSystemRecord;
    private Dictionary<string, bool> ListOfRoles = new Dictionary<string, bool>();


    //ctor
    public AddUserForm(int Id, UsersControl userControl, bool FirstStart)
    {
        InitializeComponent();
        _dataHelper = (IDataHelper<Users>)ConfigrationObjectManager.GetObject("Users");
        _dataHelperUsersRoles = (IDataHelper<UsersRoles>)ConfigrationObjectManager.GetObject("UsersRoles");
        _dataHelperSystemRecord = (IDataHelper<SystemRecord>)ConfigrationObjectManager.GetObject("SystemRecord");
        loadingForm = new LoadingForm();
        _userControl = userControl;
        firstStart = FirstStart;
        ID = Id;
        //_users = users;
    }

    #region Events
    private async void buttonSaveAndClose_Click(object sender, EventArgs e)
    {
        if (IsFiledsEmpty())
        {
            MassageCollection.ShowFieldsRquired();
        }
        else
        {
            loadingForm.Show();
            if (await SavaData())
            {
                if (ID == 0)
                {
                    this.DialogResult = DialogResult.OK;
                    MassageCollection.ShowAddNotifications();
                }
                else
                {
                    MassageCollection.ShowUpdateNotifications();
                }
                if (firstStart == true)
                {
                    MessageBox.Show("أعد تشغيل البرنامج مرة اخرى");
                    Application.Exit();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                MassageCollection.ShowErrorServer();
            }
            loadingForm.Hide();
        }
    }

    private async void buttonSave_Click(object sender, EventArgs e)
    {
        if (IsFiledsEmpty())
        {
            MassageCollection.ShowFieldsRquired();
        }
        else
        {
            loadingForm.Show();
            if (await SavaData())
            {
                if (ID == 0)
                {
                    MassageCollection.ShowAddNotifications();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MassageCollection.ShowUpdateNotifications();
                }
            }
            else
            {
                MassageCollection.ShowErrorServer();
            }
            loadingForm.Hide();
        }
    }

    private void AddCategoryForm_Load(object sender, EventArgs e)
    {
        loadingForm.Show();
        SetFieldData();
        loadingForm.Hide();
        if (firstStart == true)
        {
            buttonSave.Visible = false;
        }
    }

    private void AddUserForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (firstStart == true)
        {
            Application.Exit();
        }
    }
    #endregion

    //Method 
    #region SavaData
    private async Task<bool> SavaData()
    {

        if (ID == 0)    //Add 
        {
            return await AddData();
        }
        else        //Edit
        {
            return await EditData();
        }

    }
    #endregion

    #region IsFiledsEmpty
    private bool IsFiledsEmpty()
    {
        if (textBoxName.Text == string.Empty
            || textBoxUserName.Text == string.Empty
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

    #region AddData
    private async Task<bool> AddData()
    {
        // Set Data 
        users = new Users
        {
            FullName = textBoxName.Text,
            UserName = textBoxUserName.Text,
            Password = textBoxPassword.Text,
            Email = textBoxEmail.Text,
            Phone = textBoxPhoneNumber.Text,
            AddedDate = DateTime.Now
        };
        // Sumbit

        var result = await _dataHelper.AddAsync(users);
        if (result == 1)
        {
            // Add Roles
            var data = await _dataHelper.GetAllDataAsync();
            var userid = data.Select(x => x.Id).LastOrDefault();
            SetRoles();

            // Loops Into List Of  UsersRole 
            for (int i = 0; i < ListOfRoles.Count; i++)
            {
                UsersRoles usersRoles = new UsersRoles
                {
                    UserId = userid,
                    Key = ListOfRoles.Keys.ToList()[i],
                    Value = ListOfRoles.Values.ToList()[i]
                };
                await _dataHelperUsersRoles.AddAsync(usersRoles);
            }

            // Save SystemRecord
            SystemRecord systemRecord = new SystemRecord
            {
                Title = "أضافة مستخدم",
                UserName = Settings.Default.UserName,
                Details = "تمت أضافه مستخدم  " + users.UserName,
                AddedDate = DateTime.Now,
            };
            await _dataHelperSystemRecord.AddAsync(systemRecord);
            _userControl.LaodData();
            return true;
        }
        else
        {
            return false;
        }

    }

    private void SetRoles()
    {
        ListOfRoles.Clear();
        ListOfRoles.Add(checkBoxHome.Name, checkBoxHome.Checked);
        ListOfRoles.Add(checkBoxCategories.Name, checkBoxCategories.Checked);
        ListOfRoles.Add(checkBoxCustomer.Name, checkBoxCustomer.Checked);
        ListOfRoles.Add(checkBoxSupplier.Name, checkBoxSupplier.Checked);
        ListOfRoles.Add(checkBoxProjects.Name, checkBoxProjects.Checked);
        ListOfRoles.Add(checkBoxUsers.Name, checkBoxUsers.Checked);
        ListOfRoles.Add(checkBoxSetting.Name, checkBoxSetting.Checked);
        ListOfRoles.Add(checkBoxSystemRecord.Name, checkBoxSystemRecord.Checked);

        // ////////// 
        ListOfRoles.Add(checkBoxAccessCategory.Name, checkBoxAccessCategory.Checked);
        ListOfRoles.Add(checkBoxAccessSupplier.Name, checkBoxAccessSupplier.Checked);
        ListOfRoles.Add(checkBoxAccessCustomer.Name, checkBoxAccessCustomer.Checked);
        ListOfRoles.Add(checkBoxAccessProject.Name, checkBoxAccessProject.Checked);
        ListOfRoles.Add(checkBoxAccessUser.Name, checkBoxAccessUser.Checked);
        ListOfRoles.Add(checkBoxAccessOutCome.Name, checkBoxAccessOutCome.Checked);
        ListOfRoles.Add(checkBoxAccessInCome.Name, checkBoxAccessInCome.Checked);

        // ////////// 

        ListOfRoles.Add(checkBoxAdd.Name, checkBoxAdd.Checked);
        ListOfRoles.Add(checkBoxDelete.Name, checkBoxDelete.Checked);
        ListOfRoles.Add(checkBoxEdit.Name, checkBoxEdit.Checked);
        ListOfRoles.Add(checkBoxExport.Name, checkBoxExport.Checked);
        ListOfRoles.Add(checkBoxSearch.Name, checkBoxSearch.Checked);
        ListOfRoles.Add(checkBoxExplor.Name, checkBoxExplor.Checked);


    }
    #endregion

    #region EditData
    private async Task<bool> EditData()
    {
        // Set Data 
        users = new Users
        {
            Id = ID,
            FullName = textBoxName.Text,
            UserName = textBoxUserName.Text,
            Password = textBoxPassword.Text,
            Email = textBoxEmail.Text,
            Phone = textBoxPhoneNumber.Text,
            AddedDate = DateTime.Now
        };
        // Sumbit

        var result = await _dataHelper.EditAsync(users);
        if (result == 1)
        {
            // Add Roles
            var rolesData = await _dataHelperUsersRoles.GetAllDataAsync();
            var ListOfRolseId = rolesData.Where(x => x.UserId == ID).Select(x => x.Id).ToList();
            // Loops into ListOfRolseId ==> Delete
            for (int j = 0; j < ListOfRolseId.Count; j++)
            {
                var userid = ListOfRolseId[j];
                await _dataHelperUsersRoles.DeleteAsync(userid);
            }
            SetRoles();

            // Loops Into List Of  UsersRole 
            for (int i = 0; i < ListOfRoles.Count; i++)
            {
                UsersRoles usersRoles = new UsersRoles
                {
                    UserId = ID,
                    Key = ListOfRoles.Keys.ToList()[i],
                    Value = ListOfRoles.Values.ToList()[i]
                };
                await _dataHelperUsersRoles.AddAsync(usersRoles);
            }

            // Save SystemRecord
            SystemRecord systemRecord = new SystemRecord
            {
                Title = "تعديل مستخدم ",
                UserName = Settings.Default.UserName,
                Details = "تم تعديل مستخدم  " + users.UserName,
                AddedDate = DateTime.Now,
            };
            await _dataHelperSystemRecord.AddAsync(systemRecord);
            _userControl.LaodData();
            return true;
        }
        else
        {
            return false;
        }

    }
    #endregion

    #region SetFieldData
    private async void SetFieldData()
    {
        if (ID > 0)
        {
            // Set Fields
            users = await _dataHelper.FindAsync(ID);
            var rolesData = await _dataHelperUsersRoles.GetAllDataAsync();
            var listOfRole = rolesData.Where(x => x.UserId == ID).Select(v => v.Value).ToList();
            if (users != null)
            {
                textBoxName.Text = users.FullName;
                textBoxUserName.Text = users.UserName;
                textBoxPassword.Text = users.Password;
                textBoxEmail.Text = users.Email;
                textBoxPhoneNumber.Text = users.Phone;

                // Set Current Roles 

                checkBoxHome.Checked = listOfRole[0];
                checkBoxCategories.Checked = listOfRole[1];
                checkBoxCustomer.Checked = listOfRole[2];
                checkBoxSupplier.Checked = listOfRole[3];
                checkBoxProjects.Checked = listOfRole[4];
                checkBoxUsers.Checked = listOfRole[5];
                checkBoxSetting.Checked = listOfRole[6];
                checkBoxSystemRecord.Checked = listOfRole[7];


                checkBoxAccessCategory.Checked = listOfRole[8];
                checkBoxAccessSupplier.Checked = listOfRole[9];
                checkBoxAccessCustomer.Checked = listOfRole[10];
                checkBoxAccessProject.Checked = listOfRole[11];
                checkBoxAccessUser.Checked = listOfRole[12];
                checkBoxAccessOutCome.Checked = listOfRole[13];
                checkBoxAccessInCome.Checked = listOfRole[14];



                checkBoxAdd.Checked = listOfRole[15];
                checkBoxDelete.Checked = listOfRole[16];
                checkBoxEdit.Checked = listOfRole[17];
                checkBoxExport.Checked = listOfRole[18];
                checkBoxSearch.Checked = listOfRole[19];
                checkBoxExplor.Checked = listOfRole[20];

            }
            else
            {
                MassageCollection.ShowErrorServer();
            }
        }
    }
    #endregion


  
}
