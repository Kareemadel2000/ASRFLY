namespace ASRFLY.Gui.GuiUsers;

partial class UserLogInForm
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
        buttonLogin = new Button();
        groupBox1 = new GroupBox();
        pictureBoxUser = new PictureBox();
        label7 = new Label();
        textBoxPassword = new TextBox();
        label8 = new Label();
        label4 = new Label();
        textBoxUserName = new TextBox();
        label5 = new Label();
        label2 = new Label();
        panel1.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonLogin);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 351);
        panel1.Name = "panel1";
        panel1.Size = new Size(438, 83);
        panel1.TabIndex = 0;
        // 
        // buttonLogin
        // 
        buttonLogin.BackColor = Color.DodgerBlue;
        buttonLogin.FlatAppearance.BorderSize = 0;
        buttonLogin.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        buttonLogin.ForeColor = Color.Black;
        buttonLogin.Image = Resources.Login;
        buttonLogin.ImageAlign = ContentAlignment.MiddleLeft;
        buttonLogin.Location = new Point(26, 14);
        buttonLogin.Margin = new Padding(5);
        buttonLogin.Name = "buttonLogin";
        buttonLogin.Padding = new Padding(5);
        buttonLogin.Size = new Size(372, 55);
        buttonLogin.TabIndex = 6;
        buttonLogin.Text = "تسجيل الدخول";
        buttonLogin.UseVisualStyleBackColor = false;
        buttonLogin.Click += buttonSave_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(pictureBoxUser);
        groupBox1.Controls.Add(label7);
        groupBox1.Controls.Add(textBoxPassword);
        groupBox1.Controls.Add(label8);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(textBoxUserName);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label2);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(419, 325);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "معلومات المستخدم";
        // 
        // pictureBoxUser
        // 
        pictureBoxUser.Image = Resources.Valet_1;
        pictureBoxUser.Location = new Point(102, 31);
        pictureBoxUser.Name = "pictureBoxUser";
        pictureBoxUser.Size = new Size(167, 129);
        pictureBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBoxUser.TabIndex = 23;
        pictureBoxUser.TabStop = false;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.ForeColor = Color.Red;
        label7.Location = new Point(309, 279);
        label7.Name = "label7";
        label7.Size = new Size(20, 24);
        label7.TabIndex = 20;
        label7.Text = "*";
        // 
        // textBoxPassword
        // 
        textBoxPassword.Cursor = Cursors.IBeam;
        textBoxPassword.Location = new Point(10, 276);
        textBoxPassword.Name = "textBoxPassword";
        textBoxPassword.PasswordChar = '*';
        textBoxPassword.Size = new Size(259, 32);
        textBoxPassword.TabIndex = 2;
        textBoxPassword.TextAlign = HorizontalAlignment.Center;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(335, 279);
        label8.Name = "label8";
        label8.Size = new Size(75, 24);
        label8.TabIndex = 18;
        label8.Text = "كلمة السر";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.ForeColor = Color.Red;
        label4.Location = new Point(275, 226);
        label4.Name = "label4";
        label4.Size = new Size(20, 24);
        label4.TabIndex = 17;
        label4.Text = "*";
        // 
        // textBoxUserName
        // 
        textBoxUserName.Cursor = Cursors.IBeam;
        textBoxUserName.Location = new Point(10, 223);
        textBoxUserName.Name = "textBoxUserName";
        textBoxUserName.Size = new Size(259, 32);
        textBoxUserName.TabIndex = 1;
        textBoxUserName.TextAlign = HorizontalAlignment.Center;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(298, 226);
        label5.Name = "label5";
        label5.Size = new Size(112, 24);
        label5.TabIndex = 15;
        label5.Text = "اسم المستخدم";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Calibri", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
        label2.ForeColor = Color.DodgerBlue;
        label2.Location = new Point(74, 163);
        label2.Name = "label2";
        label2.Size = new Size(221, 45);
        label2.TabIndex = 0;
        label2.Text = "مرحبا بك مجددا";
        // 
        // UserLogInForm
        // 
        AutoScaleDimensions = new SizeF(10F, 24F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(438, 434);
        Controls.Add(groupBox1);
        Controls.Add(panel1);
        Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "UserLogInForm";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "تسجيل الدخول";
        FormClosed += UserLogInForm_FormClosed;
        panel1.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private GroupBox groupBox1;
    private Button buttonLogin;
    private Label label7;
    private TextBox textBoxPassword;
    private Label label8;
    private Label label4;
    private TextBox textBoxUserName;
    private Label label5;
    private PictureBox pictureBoxUser;
    private Label label2;
}