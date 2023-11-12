namespace ASRFLY.Gui.GuiHome
{
    partial class HomeUserControl
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            buttonAddInput = new Button();
            buttonAddUsers = new Button();
            buttonAddProjects = new Button();
            buttonAddSuppliers = new Button();
            buttonAddCustomers = new Button();
            buttonAddCategory = new Button();
            buttonAddOutput = new Button();
            label1 = new Label();
            panel2 = new Panel();
            labelCompanyName = new Label();
            pictureBoxLogo = new PictureBox();
            labelWellcome = new Label();
            panel3 = new Panel();
            comboBoxProject = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 417);
            panel1.Name = "panel1";
            panel1.Size = new Size(1262, 183);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(buttonAddInput);
            groupBox1.Controls.Add(buttonAddUsers);
            groupBox1.Controls.Add(buttonAddProjects);
            groupBox1.Controls.Add(buttonAddSuppliers);
            groupBox1.Controls.Add(buttonAddCustomers);
            groupBox1.Controls.Add(buttonAddCategory);
            groupBox1.Controls.Add(buttonAddOutput);
            groupBox1.Location = new Point(87, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(973, 101);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "أضافه";
            // 
            // buttonAddInput
            // 
            buttonAddInput.BackColor = Color.WhiteSmoke;
            buttonAddInput.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddInput.ForeColor = Color.Black;
            buttonAddInput.Image = Resources.Input_1;
            buttonAddInput.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddInput.Location = new Point(83, 28);
            buttonAddInput.Margin = new Padding(5);
            buttonAddInput.Name = "buttonAddInput";
            buttonAddInput.Size = new Size(120, 53);
            buttonAddInput.TabIndex = 10;
            buttonAddInput.Text = "       قبض";
            buttonAddInput.UseVisualStyleBackColor = false;
            buttonAddInput.Click += buttonAddInput_Click;
            // 
            // buttonAddUsers
            // 
            buttonAddUsers.BackColor = Color.WhiteSmoke;
            buttonAddUsers.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddUsers.ForeColor = Color.Black;
            buttonAddUsers.Image = Resources.Conference_Skin_Type_7;
            buttonAddUsers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddUsers.Location = new Point(323, 27);
            buttonAddUsers.Margin = new Padding(5);
            buttonAddUsers.Name = "buttonAddUsers";
            buttonAddUsers.Size = new Size(114, 53);
            buttonAddUsers.TabIndex = 9;
            buttonAddUsers.Text = "    مستخدم";
            buttonAddUsers.UseVisualStyleBackColor = false;
            buttonAddUsers.Click += buttonAddUsers_Click;
            // 
            // buttonAddProjects
            // 
            buttonAddProjects.BackColor = Color.WhiteSmoke;
            buttonAddProjects.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddProjects.ForeColor = Color.Black;
            buttonAddProjects.Image = Resources.Group_of_Projects_1;
            buttonAddProjects.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddProjects.Location = new Point(437, 27);
            buttonAddProjects.Margin = new Padding(5);
            buttonAddProjects.Name = "buttonAddProjects";
            buttonAddProjects.Size = new Size(120, 53);
            buttonAddProjects.TabIndex = 8;
            buttonAddProjects.Text = "      مشروع\r\n";
            buttonAddProjects.UseVisualStyleBackColor = false;
            buttonAddProjects.Click += buttonAddProjects_Click;
            // 
            // buttonAddSuppliers
            // 
            buttonAddSuppliers.BackColor = Color.WhiteSmoke;
            buttonAddSuppliers.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddSuppliers.ForeColor = Color.Black;
            buttonAddSuppliers.Image = Resources.Crowd;
            buttonAddSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddSuppliers.Location = new Point(557, 28);
            buttonAddSuppliers.Margin = new Padding(5);
            buttonAddSuppliers.Name = "buttonAddSuppliers";
            buttonAddSuppliers.Size = new Size(120, 53);
            buttonAddSuppliers.TabIndex = 7;
            buttonAddSuppliers.Text = "       مورد";
            buttonAddSuppliers.UseVisualStyleBackColor = false;
            buttonAddSuppliers.Click += buttonAddSuppliers_Click;
            // 
            // buttonAddCustomers
            // 
            buttonAddCustomers.BackColor = Color.WhiteSmoke;
            buttonAddCustomers.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddCustomers.ForeColor = Color.Black;
            buttonAddCustomers.Image = Resources.Users;
            buttonAddCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCustomers.Location = new Point(677, 28);
            buttonAddCustomers.Margin = new Padding(5);
            buttonAddCustomers.Name = "buttonAddCustomers";
            buttonAddCustomers.Size = new Size(120, 53);
            buttonAddCustomers.TabIndex = 6;
            buttonAddCustomers.Text = "       عميل";
            buttonAddCustomers.UseVisualStyleBackColor = false;
            buttonAddCustomers.Click += buttonAddCustomers_Click;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.BackColor = Color.WhiteSmoke;
            buttonAddCategory.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddCategory.ForeColor = Color.Black;
            buttonAddCategory.Image = Resources.Categorize;
            buttonAddCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCategory.Location = new Point(797, 27);
            buttonAddCategory.Margin = new Padding(5);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(120, 53);
            buttonAddCategory.TabIndex = 5;
            buttonAddCategory.Text = "       صنف\r\n";
            buttonAddCategory.UseVisualStyleBackColor = false;
            buttonAddCategory.Click += buttonAddCategory_Click;
            // 
            // buttonAddOutput
            // 
            buttonAddOutput.BackColor = Color.WhiteSmoke;
            buttonAddOutput.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddOutput.ForeColor = Color.Black;
            buttonAddOutput.Image = Resources.Output_1;
            buttonAddOutput.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddOutput.Location = new Point(203, 28);
            buttonAddOutput.Margin = new Padding(5);
            buttonAddOutput.Name = "buttonAddOutput";
            buttonAddOutput.Size = new Size(120, 53);
            buttonAddOutput.TabIndex = 4;
            buttonAddOutput.Text = "       صرف";
            buttonAddOutput.UseVisualStyleBackColor = false;
            buttonAddOutput.Click += buttonAddOutput_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(886, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 37);
            label1.TabIndex = 3;
            label1.Text = "الوصول السريع ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(labelCompanyName);
            panel2.Controls.Add(pictureBoxLogo);
            panel2.Location = new Point(657, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(571, 97);
            panel2.TabIndex = 3;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelCompanyName.Location = new Point(3, 6);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(477, 85);
            labelCompanyName.TabIndex = 0;
            labelCompanyName.Text = "ASRFLY";
            labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
            labelCompanyName.Click += labelCompanyName_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Right;
            pictureBoxLogo.Image = Resources.Smart_1;
            pictureBoxLogo.Location = new Point(486, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(85, 97);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 9;
            pictureBoxLogo.TabStop = false;
            // 
            // labelWellcome
            // 
            labelWellcome.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelWellcome.Location = new Point(52, 49);
            labelWellcome.Name = "labelWellcome";
            labelWellcome.Size = new Size(443, 97);
            labelWellcome.TabIndex = 11;
            labelWellcome.Text = "مرحبا بك مجددا في ASRFLY\r\n";
            labelWellcome.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom;
            panel3.Controls.Add(comboBoxProject);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(363, 267);
            panel3.Name = "panel3";
            panel3.Size = new Size(529, 144);
            panel3.TabIndex = 12;
            // 
            // comboBoxProject
            // 
            comboBoxProject.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProject.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxProject.FormattingEnabled = true;
            comboBoxProject.Location = new Point(17, 94);
            comboBoxProject.Name = "comboBoxProject";
            comboBoxProject.Size = new Size(494, 32);
            comboBoxProject.TabIndex = 12;
            comboBoxProject.SelectedIndexChanged += comboBoxProject_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(529, 48);
            label2.TabIndex = 11;
            label2.Text = "المشاريع";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(labelWellcome);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomeUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1262, 600);
            Load += HomeUserControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button buttonAddOutput;
        private GroupBox groupBox1;
        private Button buttonAddCategory;
        private Button buttonAddProjects;
        private Button buttonAddSuppliers;
        private Button buttonAddCustomers;
        private Button buttonAddInput;
        private Panel panel2;
        private Label labelCompanyName;
        private PictureBox pictureBoxLogo;
        private Label labelWellcome;
        private Button buttonAddUsers;
        private Panel panel3;
        private ComboBox comboBoxProject;
        private Label label2;
    }
}
