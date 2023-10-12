namespace ASRFLY.Gui.GuiSuppliers;

partial class AddSuppliersForm
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
        label7 = new Label();
        label5 = new Label();
        textBoxEmail = new TextBox();
        textBoxAddress = new TextBox();
        textBoxPhoneNumber = new TextBox();
        label6 = new Label();
        richTextBoxDetails = new RichTextBox();
        textBoxBalance = new TextBox();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        textBoxName = new TextBox();
        label1 = new Label();
        panel1.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonSave);
        panel1.Controls.Add(buttonSaveAndClose);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 596);
        panel1.Name = "panel1";
        panel1.Size = new Size(606, 83);
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
        buttonSave.Location = new Point(16, 14);
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
        buttonSaveAndClose.Location = new Point(380, 14);
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
        groupBox1.Controls.Add(label7);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(textBoxEmail);
        groupBox1.Controls.Add(textBoxAddress);
        groupBox1.Controls.Add(textBoxPhoneNumber);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(richTextBoxDetails);
        groupBox1.Controls.Add(textBoxBalance);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(textBoxName);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(12, 11);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(584, 576);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "معلومات المورد ";
        groupBox1.Enter += groupBox1_Enter;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(216, 281);
        label7.Name = "label7";
        label7.Size = new Size(89, 19);
        label7.TabIndex = 16;
        label7.Text = "البريد الألكترونى";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(252, 199);
        label5.Name = "label5";
        label5.Size = new Size(47, 19);
        label5.TabIndex = 15;
        label5.Text = "العنوان";
        // 
        // textBoxEmail
        // 
        textBoxEmail.Cursor = Cursors.IBeam;
        textBoxEmail.Location = new Point(6, 321);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(570, 27);
        textBoxEmail.TabIndex = 14;
        textBoxEmail.TextAlign = HorizontalAlignment.Center;
        // 
        // textBoxAddress
        // 
        textBoxAddress.Cursor = Cursors.IBeam;
        textBoxAddress.Location = new Point(6, 235);
        textBoxAddress.Name = "textBoxAddress";
        textBoxAddress.Size = new Size(570, 27);
        textBoxAddress.TabIndex = 13;
        textBoxAddress.TextAlign = HorizontalAlignment.Center;
        // 
        // textBoxPhoneNumber
        // 
        textBoxPhoneNumber.Cursor = Cursors.IBeam;
        textBoxPhoneNumber.Location = new Point(6, 154);
        textBoxPhoneNumber.Name = "textBoxPhoneNumber";
        textBoxPhoneNumber.Size = new Size(570, 27);
        textBoxPhoneNumber.TabIndex = 12;
        textBoxPhoneNumber.TextAlign = HorizontalAlignment.Center;
        textBoxPhoneNumber.TextChanged += textBox1_TextChanged;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.ForeColor = Color.Red;
        label6.Location = new Point(225, 33);
        label6.Name = "label6";
        label6.Size = new Size(17, 19);
        label6.TabIndex = 11;
        label6.Text = "*";
        // 
        // richTextBoxDetails
        // 
        richTextBoxDetails.Cursor = Cursors.IBeam;
        richTextBoxDetails.Location = new Point(6, 401);
        richTextBoxDetails.Name = "richTextBoxDetails";
        richTextBoxDetails.Size = new Size(570, 64);
        richTextBoxDetails.TabIndex = 9;
        richTextBoxDetails.Text = "";
        // 
        // textBoxBalance
        // 
        textBoxBalance.Cursor = Cursors.IBeam;
        textBoxBalance.Enabled = false;
        textBoxBalance.Location = new Point(6, 523);
        textBoxBalance.Name = "textBoxBalance";
        textBoxBalance.Size = new Size(570, 27);
        textBoxBalance.TabIndex = 7;
        textBoxBalance.Text = "0";
        textBoxBalance.TextAlign = HorizontalAlignment.Center;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(267, 483);
        label4.Name = "label4";
        label4.Size = new Size(46, 19);
        label4.TabIndex = 6;
        label4.Text = "الرصيد";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(241, 118);
        label3.Name = "label3";
        label3.Size = new Size(67, 19);
        label3.TabIndex = 4;
        label3.Text = "رقم الهاتف";
        label3.Click += label3_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(257, 365);
        label2.Name = "label2";
        label2.Size = new Size(58, 19);
        label2.TabIndex = 2;
        label2.Text = "التفاصيل";
        // 
        // textBoxName
        // 
        textBoxName.Cursor = Cursors.IBeam;
        textBoxName.Location = new Point(6, 71);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(570, 27);
        textBoxName.TabIndex = 1;
        textBoxName.TextAlign = HorizontalAlignment.Center;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(241, 33);
        label1.Name = "label1";
        label1.Size = new Size(67, 19);
        label1.TabIndex = 0;
        label1.Text = "اسم المورد";
        // 
        // AddSuppliersForm
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(606, 679);
        Controls.Add(groupBox1);
        Controls.Add(panel1);
        Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AddSuppliersForm";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "أضافة / تعديل مورد";
        TopMost = true;
        Load += AddCategoryForm_Load;
        panel1.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private GroupBox groupBox1;
    private TextBox textBoxName;
    private Label label1;
    private TextBox textBoxBalance;
    private Label label4;
    private Label label3;
    private Label label2;
    private RichTextBox richTextBoxDetails;
    private Button buttonSaveAndClose;
    private Button buttonSave;
    private Label label6;
    private TextBox textBoxPhoneNumber;
    private Label label7;
    private Label label5;
    private TextBox textBoxEmail;
    private TextBox textBoxAddress;
}