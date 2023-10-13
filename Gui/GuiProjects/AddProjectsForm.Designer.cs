namespace ASRFLY.Gui.GuiProjects;

partial class AddProjectsForm
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
        dateTimePickerEndDate = new DateTimePicker();
        dateTimePickerStartDate = new DateTimePicker();
        comboBoxCustomer = new ComboBox();
        label9 = new Label();
        label8 = new Label();
        label7 = new Label();
        label5 = new Label();
        textBoxComapany = new TextBox();
        textBoxAddress = new TextBox();
        label6 = new Label();
        richTextBoxDetails = new RichTextBox();
        label3 = new Label();
        label2 = new Label();
        textBoxName = new TextBox();
        label1 = new Label();
        textBoxIncome = new TextBox();
        groupBox2 = new GroupBox();
        label10 = new Label();
        textBoxRevenue = new TextBox();
        label4 = new Label();
        textBoxOutcome = new TextBox();
        label16 = new Label();
        panel1.SuspendLayout();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonSave);
        panel1.Controls.Add(buttonSaveAndClose);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 470);
        panel1.Name = "panel1";
        panel1.Size = new Size(806, 83);
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
        buttonSave.Size = new Size(119, 55);
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
        buttonSaveAndClose.Location = new Point(604, 14);
        buttonSaveAndClose.Margin = new Padding(5);
        buttonSaveAndClose.Name = "buttonSaveAndClose";
        buttonSaveAndClose.Padding = new Padding(5);
        buttonSaveAndClose.Size = new Size(190, 55);
        buttonSaveAndClose.TabIndex = 5;
        buttonSaveAndClose.Text = "حفظ وغلق";
        buttonSaveAndClose.UseVisualStyleBackColor = true;
        buttonSaveAndClose.Click += buttonSaveAndClose_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(dateTimePickerEndDate);
        groupBox1.Controls.Add(dateTimePickerStartDate);
        groupBox1.Controls.Add(comboBoxCustomer);
        groupBox1.Controls.Add(label9);
        groupBox1.Controls.Add(label8);
        groupBox1.Controls.Add(label7);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(textBoxComapany);
        groupBox1.Controls.Add(textBoxAddress);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(richTextBoxDetails);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(textBoxName);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(458, 446);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "معلومات المشروع ";
        // 
        // dateTimePickerEndDate
        // 
        dateTimePickerEndDate.Location = new Point(6, 306);
        dateTimePickerEndDate.Name = "dateTimePickerEndDate";
        dateTimePickerEndDate.Size = new Size(297, 27);
        dateTimePickerEndDate.TabIndex = 23;
        // 
        // dateTimePickerStartDate
        // 
        dateTimePickerStartDate.Location = new Point(6, 256);
        dateTimePickerStartDate.Name = "dateTimePickerStartDate";
        dateTimePickerStartDate.Size = new Size(297, 27);
        dateTimePickerStartDate.TabIndex = 22;
        // 
        // comboBoxCustomer
        // 
        comboBoxCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        comboBoxCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource;
        comboBoxCustomer.FormattingEnabled = true;
        comboBoxCustomer.Location = new Point(6, 89);
        comboBoxCustomer.Name = "comboBoxCustomer";
        comboBoxCustomer.Size = new Size(297, 27);
        comboBoxCustomer.TabIndex = 21;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(342, 306);
        label9.Name = "label9";
        label9.Size = new Size(81, 19);
        label9.TabIndex = 20;
        label9.Text = "نهاية المشروع";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(341, 256);
        label8.Name = "label8";
        label8.Size = new Size(82, 19);
        label8.TabIndex = 18;
        label8.Text = "بداية المشروع";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(337, 203);
        label7.Name = "label7";
        label7.Size = new Size(86, 19);
        label7.TabIndex = 16;
        label7.Text = "الشركة المنفذة";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(386, 146);
        label5.Name = "label5";
        label5.Size = new Size(47, 19);
        label5.TabIndex = 15;
        label5.Text = "العنوان";
        // 
        // textBoxComapany
        // 
        textBoxComapany.Cursor = Cursors.IBeam;
        textBoxComapany.Location = new Point(6, 202);
        textBoxComapany.Name = "textBoxComapany";
        textBoxComapany.Size = new Size(297, 27);
        textBoxComapany.TabIndex = 14;
        textBoxComapany.TextAlign = HorizontalAlignment.Center;
        // 
        // textBoxAddress
        // 
        textBoxAddress.Cursor = Cursors.IBeam;
        textBoxAddress.Location = new Point(6, 145);
        textBoxAddress.Name = "textBoxAddress";
        textBoxAddress.Size = new Size(297, 27);
        textBoxAddress.TabIndex = 13;
        textBoxAddress.TextAlign = HorizontalAlignment.Center;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.ForeColor = Color.Red;
        label6.Location = new Point(321, 44);
        label6.Name = "label6";
        label6.Size = new Size(17, 19);
        label6.TabIndex = 11;
        label6.Text = "*";
        // 
        // richTextBoxDetails
        // 
        richTextBoxDetails.Cursor = Cursors.IBeam;
        richTextBoxDetails.Location = new Point(6, 356);
        richTextBoxDetails.Name = "richTextBoxDetails";
        richTextBoxDetails.Size = new Size(297, 76);
        richTextBoxDetails.TabIndex = 9;
        richTextBoxDetails.Text = "";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(388, 89);
        label3.Name = "label3";
        label3.Size = new Size(44, 19);
        label3.TabIndex = 4;
        label3.Text = "العميل";
        label3.Click += label3_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(372, 376);
        label2.Name = "label2";
        label2.Size = new Size(58, 19);
        label2.TabIndex = 2;
        label2.Text = "التفاصيل";
        // 
        // textBoxName
        // 
        textBoxName.Cursor = Cursors.IBeam;
        textBoxName.Location = new Point(6, 36);
        textBoxName.Multiline = true;
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(297, 39);
        textBoxName.TabIndex = 1;
        textBoxName.TextAlign = HorizontalAlignment.Center;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(347, 44);
        label1.Name = "label1";
        label1.Size = new Size(77, 19);
        label1.TabIndex = 0;
        label1.Text = "اسم المشروع";
        // 
        // textBoxIncome
        // 
        textBoxIncome.Cursor = Cursors.IBeam;
        textBoxIncome.Enabled = false;
        textBoxIncome.Location = new Point(19, 81);
        textBoxIncome.Name = "textBoxIncome";
        textBoxIncome.Size = new Size(270, 27);
        textBoxIncome.TabIndex = 7;
        textBoxIncome.Text = "0";
        textBoxIncome.TextAlign = HorizontalAlignment.Center;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label10);
        groupBox2.Controls.Add(textBoxRevenue);
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(textBoxOutcome);
        groupBox2.Controls.Add(label16);
        groupBox2.Controls.Add(textBoxIncome);
        groupBox2.Location = new Point(491, 12);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(306, 288);
        groupBox2.TabIndex = 8;
        groupBox2.TabStop = false;
        groupBox2.Text = "ملخص الأموال";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(140, 200);
        label10.Name = "label10";
        label10.Size = new Size(42, 19);
        label10.TabIndex = 10;
        label10.Text = "الأرباح";
        // 
        // textBoxRevenue
        // 
        textBoxRevenue.Cursor = Cursors.IBeam;
        textBoxRevenue.Location = new Point(19, 241);
        textBoxRevenue.Name = "textBoxRevenue";
        textBoxRevenue.Size = new Size(270, 27);
        textBoxRevenue.TabIndex = 9;
        textBoxRevenue.Text = "0";
        textBoxRevenue.TextAlign = HorizontalAlignment.Center;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(126, 122);
        label4.Name = "label4";
        label4.Size = new Size(70, 19);
        label4.TabIndex = 8;
        label4.Text = "المصروفات";
        // 
        // textBoxOutcome
        // 
        textBoxOutcome.Cursor = Cursors.IBeam;
        textBoxOutcome.Location = new Point(19, 161);
        textBoxOutcome.Name = "textBoxOutcome";
        textBoxOutcome.Size = new Size(270, 27);
        textBoxOutcome.TabIndex = 1;
        textBoxOutcome.Text = "0";
        textBoxOutcome.TextAlign = HorizontalAlignment.Center;
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(126, 38);
        label16.Name = "label16";
        label16.Size = new Size(71, 19);
        label16.TabIndex = 0;
        label16.Text = "المقبوضات";
        // 
        // AddProjectsForm
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(806, 553);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(panel1);
        Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AddProjectsForm";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "أضافة / تعديل مشروع";
        TopMost = true;
        Load += AddCategoryForm_Load;
        panel1.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private GroupBox groupBox1;
    private TextBox textBoxName;
    private Label label1;
    private TextBox textBoxIncome;
    private Label label3;
    private Label label2;
    private RichTextBox richTextBoxDetails;
    private Button buttonSaveAndClose;
    private Button buttonSave;
    private Label label6;
    private Label label7;
    private Label label5;
    private TextBox textBoxComapany;
    private TextBox textBoxAddress;
    private Label label9;
    private Label label8;
    private GroupBox groupBox2;
    private TextBox textBoxOutcome;
    private Label label16;
    private Label label10;
    private TextBox textBoxRevenue;
    private Label label4;
    private DateTimePicker dateTimePickerEndDate;
    private DateTimePicker dateTimePickerStartDate;
    private ComboBox comboBoxCustomer;
}