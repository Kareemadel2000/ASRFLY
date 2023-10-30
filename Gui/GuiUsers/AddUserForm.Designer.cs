namespace ASRFLY.Gui.GuiUsers;

partial class AddUserForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new Panel();
        buttonSave = new Button();
        buttonSaveAndClose = new Button();
        groupBox1 = new GroupBox();
        textBoxPhoneNumber = new TextBox();
        label10 = new Label();
        label7 = new Label();
        textBoxPassword = new TextBox();
        label8 = new Label();
        label4 = new Label();
        textBoxUserName = new TextBox();
        label5 = new Label();
        textBoxEmail = new TextBox();
        label3 = new Label();
        label6 = new Label();
        textBoxName = new TextBox();
        label1 = new Label();
        pictureBoxUser = new PictureBox();
        groupBox2 = new GroupBox();
        flowLayoutPanel1 = new FlowLayoutPanel();
        checkBoxHome = new CheckBox();
        checkBoxCategories = new CheckBox();
        checkBoxCustomer = new CheckBox();
        checkBoxSupplier = new CheckBox();
        checkBoxProjects = new CheckBox();
        checkBoxUsers = new CheckBox();
        checkBoxSetting = new CheckBox();
        checkBoxSystemRecord = new CheckBox();
        groupBox3 = new GroupBox();
        flowLayoutPanel2 = new FlowLayoutPanel();
        checkBoxAccessCategory = new CheckBox();
        checkBoxAccessSupplier = new CheckBox();
        checkBoxAccessCustomer = new CheckBox();
        checkBoxAccessProject = new CheckBox();
        checkBoxAccessUser = new CheckBox();
        checkBoxAccessOutCome = new CheckBox();
        checkBoxAccessInCome = new CheckBox();
        flowLayoutPanel3 = new FlowLayoutPanel();
        checkBoxExplor = new CheckBox();
        checkBoxSearch = new CheckBox();
        checkBoxExport = new CheckBox();
        checkBoxEdit = new CheckBox();
        checkBoxDelete = new CheckBox();
        checkBoxAdd = new CheckBox();
        groupBox4 = new GroupBox();
        label2 = new Label();
        panel1.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
        groupBox2.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        groupBox3.SuspendLayout();
        flowLayoutPanel2.SuspendLayout();
        flowLayoutPanel3.SuspendLayout();
        groupBox4.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonSave);
        panel1.Controls.Add(buttonSaveAndClose);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 443);
        panel1.Name = "panel1";
        panel1.Size = new Size(922, 83);
        panel1.TabIndex = 0;
        // 
        // buttonSave
        // 
        buttonSave.BackColor = Color.White;
        buttonSave.FlatAppearance.BorderSize = 0;
        buttonSave.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        buttonSave.ForeColor = Color.Black;
        buttonSave.Image = Resources.Save_1;
        buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
        buttonSave.Location = new Point(22, 14);
        buttonSave.Margin = new Padding(5);
        buttonSave.Name = "buttonSave";
        buttonSave.Padding = new Padding(5);
        buttonSave.Size = new Size(124, 55);
        buttonSave.TabIndex = 6;
        buttonSave.Text = "حفظ";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += buttonSave_Click;
        // 
        // buttonSaveAndClose
        // 
        buttonSaveAndClose.BackColor = Color.White;
        buttonSaveAndClose.FlatAppearance.BorderSize = 0;
        buttonSaveAndClose.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        buttonSaveAndClose.ForeColor = Color.Black;
        buttonSaveAndClose.Image = Resources.Save;
        buttonSaveAndClose.ImageAlign = ContentAlignment.MiddleLeft;
        buttonSaveAndClose.Location = new Point(676, 14);
        buttonSaveAndClose.Margin = new Padding(5);
        buttonSaveAndClose.Name = "buttonSaveAndClose";
        buttonSaveAndClose.Padding = new Padding(5);
        buttonSaveAndClose.Size = new Size(221, 55);
        buttonSaveAndClose.TabIndex = 5;
        buttonSaveAndClose.Text = "حفظ وغلق";
        buttonSaveAndClose.UseVisualStyleBackColor = true;
        buttonSaveAndClose.Click += buttonSaveAndClose_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(pictureBoxUser);
        groupBox1.Controls.Add(textBoxPhoneNumber);
        groupBox1.Controls.Add(label10);
        groupBox1.Controls.Add(label7);
        groupBox1.Controls.Add(textBoxPassword);
        groupBox1.Controls.Add(label8);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(textBoxUserName);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(textBoxEmail);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(textBoxName);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(12, 11);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(483, 410);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "معلومات المستخدم";
        // 
        // textBoxPhoneNumber
        // 
        textBoxPhoneNumber.Cursor = Cursors.IBeam;
        textBoxPhoneNumber.Location = new Point(26, 365);
        textBoxPhoneNumber.Name = "textBoxPhoneNumber";
        textBoxPhoneNumber.Size = new Size(303, 32);
        textBoxPhoneNumber.TabIndex = 4;
        textBoxPhoneNumber.TextAlign = HorizontalAlignment.Center;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(388, 368);
        label10.Name = "label10";
        label10.Size = new Size(82, 24);
        label10.TabIndex = 21;
        label10.Text = "رقم الهاتف";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.ForeColor = Color.Red;
        label7.Location = new Point(369, 258);
        label7.Name = "label7";
        label7.Size = new Size(20, 24);
        label7.TabIndex = 20;
        label7.Text = "*";
        // 
        // textBoxPassword
        // 
        textBoxPassword.Cursor = Cursors.IBeam;
        textBoxPassword.Location = new Point(26, 255);
        textBoxPassword.Name = "textBoxPassword";
        textBoxPassword.PasswordChar = '*';
        textBoxPassword.Size = new Size(303, 32);
        textBoxPassword.TabIndex = 2;
        textBoxPassword.TextAlign = HorizontalAlignment.Center;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(395, 258);
        label8.Name = "label8";
        label8.Size = new Size(75, 24);
        label8.TabIndex = 18;
        label8.Text = "كلمة السر";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.ForeColor = Color.Red;
        label4.Location = new Point(335, 205);
        label4.Name = "label4";
        label4.Size = new Size(20, 24);
        label4.TabIndex = 17;
        label4.Text = "*";
        // 
        // textBoxUserName
        // 
        textBoxUserName.Cursor = Cursors.IBeam;
        textBoxUserName.Location = new Point(26, 202);
        textBoxUserName.Name = "textBoxUserName";
        textBoxUserName.Size = new Size(303, 32);
        textBoxUserName.TabIndex = 1;
        textBoxUserName.TextAlign = HorizontalAlignment.Center;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(358, 205);
        label5.Name = "label5";
        label5.Size = new Size(112, 24);
        label5.TabIndex = 15;
        label5.Text = "اسم المستخدم";
        // 
        // textBoxEmail
        // 
        textBoxEmail.Cursor = Cursors.IBeam;
        textBoxEmail.Location = new Point(26, 310);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(303, 32);
        textBoxEmail.TabIndex = 3;
        textBoxEmail.TextAlign = HorizontalAlignment.Center;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(414, 318);
        label3.Name = "label3";
        label3.Size = new Size(56, 24);
        label3.TabIndex = 12;
        label3.Text = "الايميل";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.ForeColor = Color.Red;
        label6.Location = new Point(351, 150);
        label6.Name = "label6";
        label6.Size = new Size(20, 24);
        label6.TabIndex = 11;
        label6.Text = "*";
        // 
        // textBoxName
        // 
        textBoxName.Cursor = Cursors.IBeam;
        textBoxName.Location = new Point(26, 142);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(303, 32);
        textBoxName.TabIndex = 0;
        textBoxName.TextAlign = HorizontalAlignment.Center;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(377, 150);
        label1.Name = "label1";
        label1.Size = new Size(93, 24);
        label1.TabIndex = 0;
        label1.Text = "الاسم الكامل";
        // 
        // pictureBoxUser
        // 
        pictureBoxUser.Image = Resources.Valet_1;
        pictureBoxUser.Location = new Point(335, 28);
        pictureBoxUser.Name = "pictureBoxUser";
        pictureBoxUser.Size = new Size(135, 101);
        pictureBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBoxUser.TabIndex = 23;
        pictureBoxUser.TabStop = false;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(flowLayoutPanel1);
        groupBox2.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        groupBox2.Location = new Point(501, 18);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(413, 122);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        groupBox2.Text = "الصلاحيات/التبويبات";
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Controls.Add(checkBoxHome);
        flowLayoutPanel1.Controls.Add(checkBoxCategories);
        flowLayoutPanel1.Controls.Add(checkBoxCustomer);
        flowLayoutPanel1.Controls.Add(checkBoxSupplier);
        flowLayoutPanel1.Controls.Add(checkBoxProjects);
        flowLayoutPanel1.Controls.Add(checkBoxUsers);
        flowLayoutPanel1.Controls.Add(checkBoxSetting);
        flowLayoutPanel1.Controls.Add(checkBoxSystemRecord);
        flowLayoutPanel1.Dock = DockStyle.Fill;
        flowLayoutPanel1.Location = new Point(3, 24);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(407, 95);
        flowLayoutPanel1.TabIndex = 0;
        // 
        // checkBoxHome
        // 
        checkBoxHome.AutoSize = true;
        checkBoxHome.Checked = true;
        checkBoxHome.CheckState = CheckState.Checked;
        checkBoxHome.Location = new Point(332, 3);
        checkBoxHome.Name = "checkBoxHome";
        checkBoxHome.Size = new Size(72, 25);
        checkBoxHome.TabIndex = 0;
        checkBoxHome.Text = "الرئيسة";
        checkBoxHome.UseVisualStyleBackColor = true;
        // 
        // checkBoxCategories
        // 
        checkBoxCategories.AutoSize = true;
        checkBoxCategories.Location = new Point(246, 3);
        checkBoxCategories.Name = "checkBoxCategories";
        checkBoxCategories.Size = new Size(80, 25);
        checkBoxCategories.TabIndex = 1;
        checkBoxCategories.Text = "الأصناف";
        checkBoxCategories.UseVisualStyleBackColor = true;
        // 
        // checkBoxCustomer
        // 
        checkBoxCustomer.AutoSize = true;
        checkBoxCustomer.Location = new Point(169, 3);
        checkBoxCustomer.Name = "checkBoxCustomer";
        checkBoxCustomer.Size = new Size(71, 25);
        checkBoxCustomer.TabIndex = 2;
        checkBoxCustomer.Text = "العملاء";
        checkBoxCustomer.UseVisualStyleBackColor = true;
        // 
        // checkBoxSupplier
        // 
        checkBoxSupplier.AutoSize = true;
        checkBoxSupplier.Location = new Point(83, 3);
        checkBoxSupplier.Name = "checkBoxSupplier";
        checkBoxSupplier.Size = new Size(80, 25);
        checkBoxSupplier.TabIndex = 3;
        checkBoxSupplier.Text = "الموردين";
        checkBoxSupplier.UseVisualStyleBackColor = true;
        // 
        // checkBoxProjects
        // 
        checkBoxProjects.AutoSize = true;
        checkBoxProjects.Location = new Point(320, 34);
        checkBoxProjects.Name = "checkBoxProjects";
        checkBoxProjects.Size = new Size(84, 25);
        checkBoxProjects.TabIndex = 4;
        checkBoxProjects.Text = "المشاريع";
        checkBoxProjects.UseVisualStyleBackColor = true;
        // 
        // checkBoxUsers
        // 
        checkBoxUsers.AutoSize = true;
        checkBoxUsers.Location = new Point(212, 34);
        checkBoxUsers.Name = "checkBoxUsers";
        checkBoxUsers.Size = new Size(102, 25);
        checkBoxUsers.TabIndex = 5;
        checkBoxUsers.Text = "المستخدمين";
        checkBoxUsers.UseVisualStyleBackColor = true;
        // 
        // checkBoxSetting
        // 
        checkBoxSetting.AutoSize = true;
        checkBoxSetting.Location = new Point(119, 34);
        checkBoxSetting.Name = "checkBoxSetting";
        checkBoxSetting.Size = new Size(87, 25);
        checkBoxSetting.TabIndex = 6;
        checkBoxSetting.Text = "الاعدادات";
        checkBoxSetting.UseVisualStyleBackColor = true;
        // 
        // checkBoxSystemRecord
        // 
        checkBoxSystemRecord.AutoSize = true;
        checkBoxSystemRecord.Location = new Point(11, 34);
        checkBoxSystemRecord.Name = "checkBoxSystemRecord";
        checkBoxSystemRecord.Size = new Size(102, 25);
        checkBoxSystemRecord.TabIndex = 7;
        checkBoxSystemRecord.Text = "سجل النظام";
        checkBoxSystemRecord.UseVisualStyleBackColor = true;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(flowLayoutPanel2);
        groupBox3.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        groupBox3.Location = new Point(501, 161);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(413, 122);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "الصلاحيات/الوصول السريع";
        // 
        // flowLayoutPanel2
        // 
        flowLayoutPanel2.Controls.Add(checkBoxAccessCategory);
        flowLayoutPanel2.Controls.Add(checkBoxAccessSupplier);
        flowLayoutPanel2.Controls.Add(checkBoxAccessCustomer);
        flowLayoutPanel2.Controls.Add(checkBoxAccessProject);
        flowLayoutPanel2.Controls.Add(checkBoxAccessUser);
        flowLayoutPanel2.Controls.Add(checkBoxAccessOutCome);
        flowLayoutPanel2.Controls.Add(checkBoxAccessInCome);
        flowLayoutPanel2.Dock = DockStyle.Fill;
        flowLayoutPanel2.Location = new Point(3, 24);
        flowLayoutPanel2.Name = "flowLayoutPanel2";
        flowLayoutPanel2.Size = new Size(407, 95);
        flowLayoutPanel2.TabIndex = 0;
        // 
        // checkBoxAccessCategory
        // 
        checkBoxAccessCategory.AutoSize = true;
        checkBoxAccessCategory.Location = new Point(339, 3);
        checkBoxAccessCategory.Name = "checkBoxAccessCategory";
        checkBoxAccessCategory.Size = new Size(65, 25);
        checkBoxAccessCategory.TabIndex = 0;
        checkBoxAccessCategory.Text = "صنف";
        checkBoxAccessCategory.UseVisualStyleBackColor = true;
        // 
        // checkBoxAccessSupplier
        // 
        checkBoxAccessSupplier.AutoSize = true;
        checkBoxAccessSupplier.Location = new Point(275, 3);
        checkBoxAccessSupplier.Name = "checkBoxAccessSupplier";
        checkBoxAccessSupplier.Size = new Size(58, 25);
        checkBoxAccessSupplier.TabIndex = 1;
        checkBoxAccessSupplier.Text = "مورد";
        checkBoxAccessSupplier.UseVisualStyleBackColor = true;
        // 
        // checkBoxAccessCustomer
        // 
        checkBoxAccessCustomer.AutoSize = true;
        checkBoxAccessCustomer.Location = new Point(206, 3);
        checkBoxAccessCustomer.Name = "checkBoxAccessCustomer";
        checkBoxAccessCustomer.Size = new Size(63, 25);
        checkBoxAccessCustomer.TabIndex = 2;
        checkBoxAccessCustomer.Text = "عميل";
        checkBoxAccessCustomer.UseVisualStyleBackColor = true;
        // 
        // checkBoxAccessProject
        // 
        checkBoxAccessProject.AutoSize = true;
        checkBoxAccessProject.Location = new Point(130, 3);
        checkBoxAccessProject.Name = "checkBoxAccessProject";
        checkBoxAccessProject.Size = new Size(70, 25);
        checkBoxAccessProject.TabIndex = 3;
        checkBoxAccessProject.Text = "مشروع";
        checkBoxAccessProject.UseVisualStyleBackColor = true;
        // 
        // checkBoxAccessUser
        // 
        checkBoxAccessUser.AutoSize = true;
        checkBoxAccessUser.Location = new Point(43, 3);
        checkBoxAccessUser.Name = "checkBoxAccessUser";
        checkBoxAccessUser.Size = new Size(81, 25);
        checkBoxAccessUser.TabIndex = 4;
        checkBoxAccessUser.Text = "مستخدم";
        checkBoxAccessUser.UseVisualStyleBackColor = true;
        // 
        // checkBoxAccessOutCome
        // 
        checkBoxAccessOutCome.AutoSize = true;
        checkBoxAccessOutCome.Location = new Point(341, 34);
        checkBoxAccessOutCome.Name = "checkBoxAccessOutCome";
        checkBoxAccessOutCome.Size = new Size(63, 25);
        checkBoxAccessOutCome.TabIndex = 5;
        checkBoxAccessOutCome.Text = "صرف";
        checkBoxAccessOutCome.UseVisualStyleBackColor = true;
        // 
        // checkBoxAccessInCome
        // 
        checkBoxAccessInCome.AutoSize = true;
        checkBoxAccessInCome.Location = new Point(274, 34);
        checkBoxAccessInCome.Name = "checkBoxAccessInCome";
        checkBoxAccessInCome.Size = new Size(61, 25);
        checkBoxAccessInCome.TabIndex = 6;
        checkBoxAccessInCome.Text = "قبض";
        checkBoxAccessInCome.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanel3
        // 
        flowLayoutPanel3.Controls.Add(checkBoxAdd);
        flowLayoutPanel3.Controls.Add(checkBoxDelete);
        flowLayoutPanel3.Controls.Add(checkBoxEdit);
        flowLayoutPanel3.Controls.Add(checkBoxExport);
        flowLayoutPanel3.Controls.Add(checkBoxSearch);
        flowLayoutPanel3.Controls.Add(checkBoxExplor);
        flowLayoutPanel3.Dock = DockStyle.Fill;
        flowLayoutPanel3.Location = new Point(3, 24);
        flowLayoutPanel3.Name = "flowLayoutPanel3";
        flowLayoutPanel3.Size = new Size(407, 95);
        flowLayoutPanel3.TabIndex = 0;
        // 
        // checkBoxExplor
        // 
        checkBoxExplor.AutoSize = true;
        checkBoxExplor.Location = new Point(338, 34);
        checkBoxExplor.Name = "checkBoxExplor";
        checkBoxExplor.Size = new Size(66, 25);
        checkBoxExplor.TabIndex = 5;
        checkBoxExplor.Text = "تصفح";
        checkBoxExplor.UseVisualStyleBackColor = true;
        // 
        // checkBoxSearch
        // 
        checkBoxSearch.AutoSize = true;
        checkBoxSearch.Location = new Point(54, 3);
        checkBoxSearch.Name = "checkBoxSearch";
        checkBoxSearch.Size = new Size(62, 25);
        checkBoxSearch.TabIndex = 4;
        checkBoxSearch.Text = "بحث";
        checkBoxSearch.UseVisualStyleBackColor = true;
        // 
        // checkBoxExport
        // 
        checkBoxExport.AutoSize = true;
        checkBoxExport.Location = new Point(122, 3);
        checkBoxExport.Name = "checkBoxExport";
        checkBoxExport.Size = new Size(69, 25);
        checkBoxExport.TabIndex = 3;
        checkBoxExport.Text = "تصدير";
        checkBoxExport.UseVisualStyleBackColor = true;
        // 
        // checkBoxEdit
        // 
        checkBoxEdit.AutoSize = true;
        checkBoxEdit.Location = new Point(197, 3);
        checkBoxEdit.Name = "checkBoxEdit";
        checkBoxEdit.Size = new Size(66, 25);
        checkBoxEdit.TabIndex = 2;
        checkBoxEdit.Text = "تعديل";
        checkBoxEdit.UseVisualStyleBackColor = true;
        // 
        // checkBoxDelete
        // 
        checkBoxDelete.AutoSize = true;
        checkBoxDelete.Location = new Point(269, 3);
        checkBoxDelete.Name = "checkBoxDelete";
        checkBoxDelete.Size = new Size(64, 25);
        checkBoxDelete.TabIndex = 1;
        checkBoxDelete.Text = "حذف";
        checkBoxDelete.UseVisualStyleBackColor = true;
        // 
        // checkBoxAdd
        // 
        checkBoxAdd.AutoSize = true;
        checkBoxAdd.Location = new Point(339, 3);
        checkBoxAdd.Name = "checkBoxAdd";
        checkBoxAdd.Size = new Size(65, 25);
        checkBoxAdd.TabIndex = 0;
        checkBoxAdd.Text = "أضافة";
        checkBoxAdd.UseVisualStyleBackColor = true;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(flowLayoutPanel3);
        groupBox4.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
        groupBox4.Location = new Point(501, 299);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(413, 122);
        groupBox4.TabIndex = 2;
        groupBox4.TabStop = false;
        groupBox4.Text = "الصلاحيات/العمليات القياسية";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Calibri", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
        label2.ForeColor = Color.DodgerBlue;
        label2.Location = new Point(26, 34);
        label2.Name = "label2";
        label2.Size = new Size(285, 45);
        label2.TabIndex = 0;
        label2.Text = "أضافة مستخدم جديد";
        // 
        // AddUserForm
        // 
        AutoScaleDimensions = new SizeF(10F, 24F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(922, 526);
        Controls.Add(groupBox4);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(panel1);
        Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AddUserForm";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "أضافة / تعديل مستخدم";
        TopMost = true;
        Load += AddCategoryForm_Load;
        panel1.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
        groupBox2.ResumeLayout(false);
        flowLayoutPanel1.ResumeLayout(false);
        flowLayoutPanel1.PerformLayout();
        groupBox3.ResumeLayout(false);
        flowLayoutPanel2.ResumeLayout(false);
        flowLayoutPanel2.PerformLayout();
        flowLayoutPanel3.ResumeLayout(false);
        flowLayoutPanel3.PerformLayout();
        groupBox4.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private GroupBox groupBox1;
    private TextBox textBoxName;
    private Label label1;
    private Button buttonSaveAndClose;
    private Button buttonSave;
    private Label label6;
    private TextBox textBoxPhoneNumber;
    private Label label10;
    private Label label7;
    private TextBox textBoxPassword;
    private Label label8;
    private Label label4;
    private TextBox textBoxUserName;
    private Label label5;
    private TextBox textBoxEmail;
    private Label label3;
    private PictureBox pictureBoxUser;
    private GroupBox groupBox2;
    private FlowLayoutPanel flowLayoutPanel1;
    private CheckBox checkBoxHome;
    private CheckBox checkBoxCategories;
    private CheckBox checkBoxCustomer;
    private CheckBox checkBoxSupplier;
    private CheckBox checkBoxProjects;
    private CheckBox checkBoxUsers;
    private CheckBox checkBoxSetting;
    private CheckBox checkBoxSystemRecord;
    private GroupBox groupBox3;
    private FlowLayoutPanel flowLayoutPanel2;
    private CheckBox checkBoxAccessCategory;
    private CheckBox checkBoxAccessSupplier;
    private CheckBox checkBoxAccessCustomer;
    private CheckBox checkBoxAccessProject;
    private CheckBox checkBoxAccessUser;
    private CheckBox checkBoxAccessOutCome;
    private CheckBox checkBoxAccessInCome;
    private FlowLayoutPanel flowLayoutPanel3;
    private CheckBox checkBoxAdd;
    private CheckBox checkBoxDelete;
    private CheckBox checkBoxEdit;
    private CheckBox checkBoxExport;
    private CheckBox checkBoxSearch;
    private CheckBox checkBoxExplor;
    private GroupBox groupBox4;
    private Label label2;
}