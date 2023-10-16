namespace ASRFLY.Gui.GuiOutCome;

partial class AddOutComeForm
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
        dateTimePickerDate = new DateTimePicker();
        comboBoxSupplier = new ComboBox();
        label8 = new Label();
        label6 = new Label();
        richTextBoxDetails = new RichTextBox();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        comboBoxCategory = new ComboBox();
        textBoxRecNo = new TextBox();
        label5 = new Label();
        label4 = new Label();
        textBoxAmount = new TextBox();
        label7 = new Label();
        label9 = new Label();
        label10 = new Label();
        panel1.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(buttonSave);
        panel1.Controls.Add(buttonSaveAndClose);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 415);
        panel1.Name = "panel1";
        panel1.Size = new Size(479, 83);
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
        buttonSave.Text = "   حفظ";
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
        buttonSaveAndClose.Location = new Point(277, 14);
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
        groupBox1.Controls.Add(label10);
        groupBox1.Controls.Add(label9);
        groupBox1.Controls.Add(label7);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(textBoxAmount);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(textBoxRecNo);
        groupBox1.Controls.Add(comboBoxCategory);
        groupBox1.Controls.Add(dateTimePickerDate);
        groupBox1.Controls.Add(comboBoxSupplier);
        groupBox1.Controls.Add(label8);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(richTextBoxDetails);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(458, 396);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "معلومات الصرف ";
        // 
        // dateTimePickerDate
        // 
        dateTimePickerDate.Location = new Point(7, 146);
        dateTimePickerDate.Name = "dateTimePickerDate";
        dateTimePickerDate.Size = new Size(297, 32);
        dateTimePickerDate.TabIndex = 22;
        // 
        // comboBoxSupplier
        // 
        comboBoxSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        comboBoxSupplier.AutoCompleteSource = AutoCompleteSource.CustomSource;
        comboBoxSupplier.FormattingEnabled = true;
        comboBoxSupplier.Location = new Point(7, 88);
        comboBoxSupplier.Name = "comboBoxSupplier";
        comboBoxSupplier.Size = new Size(297, 32);
        comboBoxSupplier.TabIndex = 21;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(346, 152);
        label8.Name = "label8";
        label8.Size = new Size(97, 24);
        label8.TabIndex = 18;
        label8.Text = "تاريخ الصرف";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.ForeColor = Color.Red;
        label6.Location = new Point(372, 38);
        label6.Name = "label6";
        label6.Size = new Size(20, 24);
        label6.TabIndex = 11;
        label6.Text = "*";
        // 
        // richTextBoxDetails
        // 
        richTextBoxDetails.Cursor = Cursors.IBeam;
        richTextBoxDetails.Location = new Point(7, 320);
        richTextBoxDetails.Name = "richTextBoxDetails";
        richTextBoxDetails.Size = new Size(297, 63);
        richTextBoxDetails.TabIndex = 9;
        richTextBoxDetails.Text = "";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(329, 92);
        label3.Name = "label3";
        label3.Size = new Size(114, 24);
        label3.TabIndex = 4;
        label3.Text = "المورد(المستلم)";
        label3.Click += label3_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(372, 346);
        label2.Name = "label2";
        label2.Size = new Size(71, 24);
        label2.TabIndex = 2;
        label2.Text = "التفاصيل";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(394, 38);
        label1.Name = "label1";
        label1.Size = new Size(49, 24);
        label1.TabIndex = 0;
        label1.Text = "صنف";
        // 
        // comboBoxCategory
        // 
        comboBoxCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        comboBoxCategory.AutoCompleteSource = AutoCompleteSource.CustomSource;
        comboBoxCategory.FormattingEnabled = true;
        comboBoxCategory.Location = new Point(7, 30);
        comboBoxCategory.Name = "comboBoxCategory";
        comboBoxCategory.Size = new Size(297, 32);
        comboBoxCategory.TabIndex = 23;
        // 
        // textBoxRecNo
        // 
        textBoxRecNo.Cursor = Cursors.IBeam;
        textBoxRecNo.Enabled = false;
        textBoxRecNo.Location = new Point(7, 204);
        textBoxRecNo.Name = "textBoxRecNo";
        textBoxRecNo.Size = new Size(297, 32);
        textBoxRecNo.TabIndex = 24;
        textBoxRecNo.Text = "0";
        textBoxRecNo.TextAlign = HorizontalAlignment.Center;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(362, 208);
        label5.Name = "label5";
        label5.Size = new Size(81, 24);
        label5.TabIndex = 25;
        label5.Text = "رقم الوصل";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(394, 265);
        label4.Name = "label4";
        label4.Size = new Size(49, 24);
        label4.TabIndex = 27;
        label4.Text = "المبلغ";
        // 
        // textBoxAmount
        // 
        textBoxAmount.Cursor = Cursors.IBeam;
        textBoxAmount.Enabled = false;
        textBoxAmount.Location = new Point(7, 262);
        textBoxAmount.Name = "textBoxAmount";
        textBoxAmount.Size = new Size(297, 32);
        textBoxAmount.TabIndex = 26;
        textBoxAmount.Text = "0";
        textBoxAmount.TextAlign = HorizontalAlignment.Center;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.ForeColor = Color.Red;
        label7.Location = new Point(329, 146);
        label7.Name = "label7";
        label7.Size = new Size(20, 24);
        label7.TabIndex = 28;
        label7.Text = "*";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.ForeColor = Color.Red;
        label9.Location = new Point(310, 88);
        label9.Name = "label9";
        label9.Size = new Size(20, 24);
        label9.TabIndex = 29;
        label9.Text = "*";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.ForeColor = Color.Red;
        label10.Location = new Point(372, 262);
        label10.Name = "label10";
        label10.Size = new Size(20, 24);
        label10.TabIndex = 30;
        label10.Text = "*";
        // 
        // AddOutComeForm
        // 
        AutoScaleDimensions = new SizeF(10F, 24F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(479, 498);
        Controls.Add(groupBox1);
        Controls.Add(panel1);
        Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "AddOutComeForm";
        RightToLeft = RightToLeft.Yes;
        RightToLeftLayout = true;
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "أضافة / تعديل صرف";
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
    private Label label1;
    private Label label3;
    private Label label2;
    private RichTextBox richTextBoxDetails;
    private Button buttonSaveAndClose;
    private Button buttonSave;
    private Label label6;
    private Label label8;
    private DateTimePicker dateTimePickerDate;
    private ComboBox comboBoxSupplier;
    private Label label5;
    private TextBox textBoxRecNo;
    private ComboBox comboBoxCategory;
    private Label label4;
    private TextBox textBoxAmount;
    private Label label7;
    private Label label10;
    private Label label9;
}