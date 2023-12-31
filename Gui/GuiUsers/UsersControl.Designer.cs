﻿namespace ASRFLY.Gui.GuiUsers;

partial class UsersControl
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
        panel1 = new Panel();
        textBoxSearch = new TextBox();
        buttonSearch = new Button();
        dataGridView1 = new DataGridView();
        comboBoxPageNo = new ComboBox();
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
        buttonAdd.Image = Resources.Add;
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
        buttonEdit.Image = Resources.Edit;
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
        buttonDelete.Image = Resources.Delete;
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
        // buttonUpdate
        // 
        buttonUpdate.BackColor = Color.White;
        buttonUpdate.FlatAppearance.BorderSize = 0;
        buttonUpdate.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        buttonUpdate.ForeColor = Color.Black;
        buttonUpdate.Image = Resources.Refresh;
        buttonUpdate.ImageAlign = ContentAlignment.MiddleLeft;
        buttonUpdate.Location = new Point(649, 10);
        buttonUpdate.Margin = new Padding(5);
        buttonUpdate.Name = "buttonUpdate";
        buttonUpdate.Padding = new Padding(5);
        buttonUpdate.Size = new Size(142, 55);
        buttonUpdate.TabIndex = 7;
        buttonUpdate.Text = "تحديث";
        buttonUpdate.UseVisualStyleBackColor = true;
        buttonUpdate.Click += buttonUpdate_Click;
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
        textBoxSearch.Location = new Point(91, -4);
        textBoxSearch.Margin = new Padding(5);
        textBoxSearch.Name = "textBoxSearch";
        textBoxSearch.Size = new Size(333, 69);
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
        buttonSearch.Image = Resources.Search_2;
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
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
        dataGridView1.Dock = DockStyle.Fill;
        dataGridView1.Location = new Point(0, 76);
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
        dataGridView1.Size = new Size(1262, 524);
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
        // UsersControl
        // 
        AutoScaleDimensions = new SizeF(12F, 29F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        Controls.Add(comboBoxPageNo);
        Controls.Add(dataGridView1);
        Controls.Add(flowLayoutPanel1);
        Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(4, 5, 4, 5);
        Name = "UsersControl";
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
    private Panel panel1;
    private Button buttonSearch;
    private TextBox textBoxSearch;
    private DataGridView dataGridView1;
    private Button buttonUpdate;
    private ComboBox comboBoxPageNo;
}
