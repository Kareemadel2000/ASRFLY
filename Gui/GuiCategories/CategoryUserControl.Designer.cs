namespace ASRFLY.Gui.GuiCategories;

partial class CategoryUserControl
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
        flowLayoutPanel1 = new FlowLayoutPanel();
        buttonAdd = new Button();
        buttonEdit = new Button();
        buttonDelete = new Button();
        buttonExport = new Button();
        panel1 = new Panel();
        textBoxSearch = new TextBox();
        buttonSearch = new Button();
        dataGridView1 = new DataGridView();
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
        flowLayoutPanel1.Controls.Add(buttonExport);
        flowLayoutPanel1.Controls.Add(panel1);
        flowLayoutPanel1.Dock = DockStyle.Top;
        flowLayoutPanel1.Location = new Point(0, 0);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Padding = new Padding(5);
        flowLayoutPanel1.Size = new Size(1262, 76);
        flowLayoutPanel1.TabIndex = 1;
        // 
        // buttonAdd
        // 
        buttonAdd.BackColor = Color.White;
        buttonAdd.FlatAppearance.BorderSize = 0;
        buttonAdd.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        buttonAdd.ForeColor = Color.Black;
        buttonAdd.Image = Properties.Resources.Add;
        buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
        buttonAdd.Location = new Point(1105, 10);
        buttonAdd.Margin = new Padding(5);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Padding = new Padding(5);
        buttonAdd.Size = new Size(142, 55);
        buttonAdd.TabIndex = 1;
        buttonAdd.Text = "أضافة";
        buttonAdd.UseVisualStyleBackColor = true;
        buttonAdd.Click += buttonAdd_Click;
        // 
        // buttonEdit
        // 
        buttonEdit.BackColor = Color.White;
        buttonEdit.FlatAppearance.BorderSize = 0;
        buttonEdit.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        buttonEdit.ForeColor = Color.Black;
        buttonEdit.Image = Properties.Resources.Edit;
        buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;
        buttonEdit.Location = new Point(953, 10);
        buttonEdit.Margin = new Padding(5);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Padding = new Padding(5);
        buttonEdit.Size = new Size(142, 55);
        buttonEdit.TabIndex = 2;
        buttonEdit.Text = "تعديل";
        buttonEdit.UseVisualStyleBackColor = true;
        buttonEdit.Click += buttonEdit_Click;
        // 
        // buttonDelete
        // 
        buttonDelete.BackColor = Color.White;
        buttonDelete.FlatAppearance.BorderSize = 0;
        buttonDelete.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        buttonDelete.ForeColor = Color.Black;
        buttonDelete.Image = Properties.Resources.Delete;
        buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
        buttonDelete.Location = new Point(801, 10);
        buttonDelete.Margin = new Padding(5);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Padding = new Padding(5);
        buttonDelete.Size = new Size(142, 55);
        buttonDelete.TabIndex = 3;
        buttonDelete.Text = "حذف";
        buttonDelete.UseVisualStyleBackColor = true;
        buttonDelete.Click += buttonDelete_Click;
        // 
        // buttonExport
        // 
        buttonExport.BackColor = Color.White;
        buttonExport.FlatAppearance.BorderSize = 0;
        buttonExport.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        buttonExport.ForeColor = Color.Black;
        buttonExport.Image = Properties.Resources.Export;
        buttonExport.ImageAlign = ContentAlignment.MiddleLeft;
        buttonExport.Location = new Point(649, 10);
        buttonExport.Margin = new Padding(5);
        buttonExport.Name = "buttonExport";
        buttonExport.Padding = new Padding(5);
        buttonExport.Size = new Size(142, 55);
        buttonExport.TabIndex = 4;
        buttonExport.Text = "تصدير";
        buttonExport.UseVisualStyleBackColor = true;
        buttonExport.Click += buttonExport_Click;
        // 
        // panel1
        // 
        panel1.BorderStyle = BorderStyle.FixedSingle;
        panel1.Controls.Add(textBoxSearch);
        panel1.Controls.Add(buttonSearch);
        panel1.Location = new Point(216, 8);
        panel1.Name = "panel1";
        panel1.Size = new Size(425, 57);
        panel1.TabIndex = 6;
        // 
        // textBoxSearch
        // 
        textBoxSearch.Font = new Font("Calibri", 30F, FontStyle.Bold, GraphicsUnit.Point);
        textBoxSearch.Location = new Point(92, 0);
        textBoxSearch.Margin = new Padding(5);
        textBoxSearch.Name = "textBoxSearch";
        textBoxSearch.Size = new Size(333, 56);
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
        buttonSearch.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        buttonSearch.ForeColor = Color.Black;
        buttonSearch.Image = Properties.Resources.Search_2;
        buttonSearch.ImageAlign = ContentAlignment.MiddleLeft;
        buttonSearch.Location = new Point(0, 0);
        buttonSearch.Margin = new Padding(5);
        buttonSearch.Name = "buttonSearch";
        buttonSearch.Padding = new Padding(5);
        buttonSearch.Size = new Size(92, 55);
        buttonSearch.TabIndex = 5;
        buttonSearch.Text = "       بحث";
        buttonSearch.UseVisualStyleBackColor = false;
        buttonSearch.Click += buttonSearch_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dataGridView1.BackgroundColor = Color.White;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle1.BackColor = SystemColors.Window;
        dataGridViewCellStyle1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
        dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
        dataGridView1.Dock = DockStyle.Fill;
        dataGridView1.Location = new Point(0, 76);
        dataGridView1.Name = "dataGridView1";
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle2.BackColor = SystemColors.Control;
        dataGridViewCellStyle2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dataGridView1.RowHeadersWidth = 51;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
        dataGridView1.RowTemplate.Height = 25;
        dataGridView1.Size = new Size(1262, 524);
        dataGridView1.TabIndex = 3;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // CategoryUserControl
        // 
        AutoScaleDimensions = new SizeF(10F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        Controls.Add(dataGridView1);
        Controls.Add(flowLayoutPanel1);
        Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(4, 5, 4, 5);
        Name = "CategoryUserControl";
        RightToLeft = RightToLeft.Yes;
        Size = new Size(1262, 600);
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
}
