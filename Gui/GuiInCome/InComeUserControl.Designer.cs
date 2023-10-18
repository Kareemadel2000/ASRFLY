namespace ASRFLY.Gui.GuiInCome;

partial class InComeUserControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        flowLayoutPanel1 = new FlowLayoutPanel();
        buttonAdd = new Button();
        buttonEdit = new Button();
        buttonDelete = new Button();
        buttonUpdate = new Button();
        buttonExport = new Button();
        panel1 = new Panel();
        textBoxSearch = new TextBox();
        buttonSearch = new Button();
        dataGridView1 = new DataGridView();
        comboBoxPageNo = new ComboBox();
        label1 = new Label();
        flowLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.BackColor = SystemColors.Control;
        flowLayoutPanel1.Controls.Add(buttonAdd);
        flowLayoutPanel1.Controls.Add(buttonEdit);
        flowLayoutPanel1.Controls.Add(buttonDelete);
        flowLayoutPanel1.Controls.Add(buttonUpdate);
        flowLayoutPanel1.Controls.Add(buttonExport);
        flowLayoutPanel1.Controls.Add(panel1);
        flowLayoutPanel1.Dock = DockStyle.Top;
        flowLayoutPanel1.Location = new Point(0, 0);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Padding = new Padding(5);
        flowLayoutPanel1.Size = new Size(903, 81);
        flowLayoutPanel1.TabIndex = 1;
        // 
        // buttonAdd
        // 
        buttonAdd.BackColor = Color.White;
        buttonAdd.FlatAppearance.BorderSize = 0;
        buttonAdd.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
        buttonAdd.ForeColor = Color.Black;
        buttonAdd.Image = Resources.Add;
        buttonAdd.ImageAlign = ContentAlignment.TopCenter;
        buttonAdd.Location = new Point(791, 7);
        buttonAdd.Margin = new Padding(2);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(100, 65);
        buttonAdd.TabIndex = 1;
        buttonAdd.Text = "أضافة";
        buttonAdd.TextAlign = ContentAlignment.BottomCenter;
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // buttonEdit
        // 
        buttonEdit.BackColor = Color.White;
        buttonEdit.FlatAppearance.BorderSize = 0;
        buttonEdit.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
        buttonEdit.ForeColor = Color.Black;
        buttonEdit.Image = Resources.Edit;
        buttonEdit.ImageAlign = ContentAlignment.TopCenter;
        buttonEdit.Location = new Point(687, 7);
        buttonEdit.Margin = new Padding(2);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(100, 65);
        buttonEdit.TabIndex = 2;
        buttonEdit.Text = "تعديل";
        buttonEdit.TextAlign = ContentAlignment.BottomCenter;
        buttonEdit.UseVisualStyleBackColor = true;
        buttonEdit.Click += buttonEdit_Click;
        // 
        // buttonDelete
        // 
        buttonDelete.BackColor = Color.White;
        buttonDelete.FlatAppearance.BorderSize = 0;
        buttonDelete.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
        buttonDelete.ForeColor = Color.Black;
        buttonDelete.Image = Resources.Delete;
        buttonDelete.ImageAlign = ContentAlignment.TopCenter;
        buttonDelete.Location = new Point(583, 7);
        buttonDelete.Margin = new Padding(2);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(100, 65);
        buttonDelete.TabIndex = 3;
        buttonDelete.Text = "حذف";
        buttonDelete.TextAlign = ContentAlignment.BottomCenter;
        buttonDelete.UseVisualStyleBackColor = true;
        buttonDelete.Click += buttonDelete_Click;
        // 
        // buttonUpdate
        // 
        buttonUpdate.BackColor = Color.White;
        buttonUpdate.FlatAppearance.BorderSize = 0;
        buttonUpdate.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
        buttonUpdate.ForeColor = Color.Black;
        buttonUpdate.Image = Resources.Refresh;
        buttonUpdate.ImageAlign = ContentAlignment.TopCenter;
        buttonUpdate.Location = new Point(479, 7);
        buttonUpdate.Margin = new Padding(2);
        buttonUpdate.Name = "buttonUpdate";
        buttonUpdate.Size = new Size(100, 65);
        buttonUpdate.TabIndex = 7;
        buttonUpdate.Text = "تحديث";
        buttonUpdate.TextAlign = ContentAlignment.BottomCenter;
        buttonUpdate.UseVisualStyleBackColor = true;
        buttonUpdate.Click += buttonUpdate_Click;
        // 
        // buttonExport
        // 
        buttonExport.BackColor = Color.White;
        buttonExport.FlatAppearance.BorderSize = 0;
        buttonExport.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
        buttonExport.ForeColor = Color.Black;
        buttonExport.Image = Resources.Export;
        buttonExport.ImageAlign = ContentAlignment.TopCenter;
        buttonExport.Location = new Point(375, 7);
        buttonExport.Margin = new Padding(2);
        buttonExport.Name = "buttonExport";
        buttonExport.Size = new Size(100, 65);
        buttonExport.TabIndex = 4;
        buttonExport.Text = "تصدير";
        buttonExport.TextAlign = ContentAlignment.BottomCenter;
        buttonExport.UseVisualStyleBackColor = true;
        buttonExport.Click += buttonExport_Click;
        // 
        // panel1
        // 
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Controls.Add(textBoxSearch);
        panel1.Controls.Add(buttonSearch);
        panel1.Location = new Point(56, 8);
        panel1.Name = "panel1";
        panel1.Size = new Size(314, 62);
        panel1.TabIndex = 6;
        // 
        // textBoxSearch
        // 
        textBoxSearch.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        textBoxSearch.Location = new Point(48, -1);
        textBoxSearch.Margin = new Padding(5);
        textBoxSearch.Multiline = true;
        textBoxSearch.Name = "textBoxSearch";
        textBoxSearch.Size = new Size(264, 62);
        textBoxSearch.TabIndex = 7;
        textBoxSearch.TextAlign = HorizontalAlignment.Center;
        textBoxSearch.TextChanged += textBoxSearch_TextChanged;
        // 
        // buttonSearch
        // 
        buttonSearch.BackColor = Color.DodgerBlue;
        buttonSearch.Dock = DockStyle.Left;
        buttonSearch.FlatAppearance.BorderSize = 0;
        buttonSearch.FlatStyle = FlatStyle.Flat;
        buttonSearch.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
        buttonSearch.ForeColor = Color.Black;
        buttonSearch.Image = Resources.Search_2;
        buttonSearch.ImageAlign = ContentAlignment.MiddleLeft;
        buttonSearch.Location = new Point(0, 0);
        buttonSearch.Margin = new Padding(5);
        buttonSearch.Name = "buttonSearch";
        buttonSearch.Padding = new Padding(5);
        buttonSearch.Size = new Size(50, 60);
        buttonSearch.TabIndex = 5;
        buttonSearch.TextAlign = ContentAlignment.MiddleRight;
        buttonSearch.UseVisualStyleBackColor = false;
        buttonSearch.Click += buttonSearch_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dataGridView1.BackgroundColor = Color.White;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle2.BackColor = SystemColors.Control;
        dataGridViewCellStyle2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle3.BackColor = SystemColors.Window;
        dataGridViewCellStyle3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
        dataGridView1.Dock = DockStyle.Fill;
        dataGridView1.Location = new Point(0, 81);
        dataGridView1.Name = "dataGridView1";
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle4.BackColor = SystemColors.Control;
        dataGridViewCellStyle4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
        dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dataGridView1.RowHeadersWidth = 51;
        dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
        dataGridView1.RowTemplate.Height = 25;
        dataGridView1.Size = new Size(903, 519);
        dataGridView1.TabIndex = 3;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // comboBoxPageNo
        // 
        comboBoxPageNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        comboBoxPageNo.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxPageNo.FormattingEnabled = true;
        comboBoxPageNo.Location = new Point(33, 560);
        comboBoxPageNo.Name = "comboBoxPageNo";
        comboBoxPageNo.Size = new Size(124, 37);
        comboBoxPageNo.TabIndex = 5;
        comboBoxPageNo.SelectedIndexChanged += comboBoxPageNo_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        label1.BackColor = Color.FromArgb(255, 192, 128);
        label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(744, 556);
        label1.Name = "label1";
        label1.Size = new Size(159, 44);
        label1.TabIndex = 6;
        label1.Text = "المقبوضات";
        // 
        // InComeUserControl
        // 
        AutoScaleDimensions = new SizeF(12F, 29F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        Controls.Add(label1);
        Controls.Add(comboBoxPageNo);
        Controls.Add(dataGridView1);
        Controls.Add(flowLayoutPanel1);
        Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(4, 5, 4, 5);
        Name = "InComeUserControl";
        RightToLeft = RightToLeft.Yes;
        Size = new Size(903, 600);
        flowLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private FlowLayoutPanel flowLayoutPanel1;
    private Button buttonAdd;
    private Button buttonEdit;
    private Button buttonDelete;
    private Button buttonExport;
    private Panel panel1;
    private Button buttonSearch;
    private TextBox textBoxSearch;
    private DataGridView dataGridView1;
    private Button buttonUpdate;
    private ComboBox comboBoxPageNo;
    private Label label1;
}
