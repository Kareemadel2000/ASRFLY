namespace ASRFLY
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonHome = new Button();
            buttonCategory = new Button();
            buttonCustomers = new Button();
            buttonSuppliers = new Button();
            buttonProjects = new Button();
            buttonUsers = new Button();
            buttonAbouts = new Button();
            buttonSettings = new Button();
            buttonLogOut = new Button();
            buttonHelp = new Button();
            panelContainer = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(buttonHome);
            flowLayoutPanel1.Controls.Add(buttonCategory);
            flowLayoutPanel1.Controls.Add(buttonCustomers);
            flowLayoutPanel1.Controls.Add(buttonSuppliers);
            flowLayoutPanel1.Controls.Add(buttonProjects);
            flowLayoutPanel1.Controls.Add(buttonUsers);
            flowLayoutPanel1.Controls.Add(buttonAbouts);
            flowLayoutPanel1.Controls.Add(buttonSettings);
            flowLayoutPanel1.Controls.Add(buttonLogOut);
            flowLayoutPanel1.Controls.Add(buttonHelp);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(1132, 77);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.White;
            buttonHome.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.ForeColor = Color.Black;
            buttonHome.Image = Properties.Resources.Home;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(935, 10);
            buttonHome.Margin = new Padding(5);
            buttonHome.Name = "buttonHome";
            buttonHome.Padding = new Padding(5);
            buttonHome.Size = new Size(165, 55);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "           الرئيسة\r\n";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonCategory
            // 
            buttonCategory.BackColor = Color.White;
            buttonCategory.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCategory.ForeColor = Color.Black;
            buttonCategory.Image = Properties.Resources.Categorize;
            buttonCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCategory.Location = new Point(760, 10);
            buttonCategory.Margin = new Padding(5);
            buttonCategory.Name = "buttonCategory";
            buttonCategory.Padding = new Padding(5);
            buttonCategory.Size = new Size(165, 55);
            buttonCategory.TabIndex = 1;
            buttonCategory.Text = "الاصناف";
            buttonCategory.UseVisualStyleBackColor = true;
            // 
            // buttonCustomers
            // 
            buttonCustomers.BackColor = Color.White;
            buttonCustomers.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCustomers.ForeColor = Color.Black;
            buttonCustomers.Image = Properties.Resources.Users;
            buttonCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCustomers.Location = new Point(585, 10);
            buttonCustomers.Margin = new Padding(5);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Padding = new Padding(5);
            buttonCustomers.Size = new Size(165, 55);
            buttonCustomers.TabIndex = 2;
            buttonCustomers.Text = "العملاء ";
            buttonCustomers.UseVisualStyleBackColor = true;
            // 
            // buttonSuppliers
            // 
            buttonSuppliers.BackColor = Color.White;
            buttonSuppliers.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSuppliers.ForeColor = Color.Black;
            buttonSuppliers.Image = Properties.Resources.Crowd;
            buttonSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSuppliers.Location = new Point(410, 10);
            buttonSuppliers.Margin = new Padding(5);
            buttonSuppliers.Name = "buttonSuppliers";
            buttonSuppliers.Padding = new Padding(5);
            buttonSuppliers.Size = new Size(165, 55);
            buttonSuppliers.TabIndex = 3;
            buttonSuppliers.Text = "الموردين";
            buttonSuppliers.UseVisualStyleBackColor = true;
            // 
            // buttonProjects
            // 
            buttonProjects.BackColor = Color.White;
            buttonProjects.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProjects.ForeColor = Color.Black;
            buttonProjects.Image = Properties.Resources.Group_of_Projects_1;
            buttonProjects.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProjects.Location = new Point(235, 10);
            buttonProjects.Margin = new Padding(5);
            buttonProjects.Name = "buttonProjects";
            buttonProjects.Padding = new Padding(5);
            buttonProjects.Size = new Size(165, 55);
            buttonProjects.TabIndex = 4;
            buttonProjects.Text = "المشاريع";
            buttonProjects.UseVisualStyleBackColor = true;
            // 
            // buttonUsers
            // 
            buttonUsers.BackColor = Color.White;
            buttonUsers.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsers.ForeColor = Color.Black;
            buttonUsers.Image = Properties.Resources.Conference_Skin_Type_7;
            buttonUsers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUsers.Location = new Point(60, 10);
            buttonUsers.Margin = new Padding(5);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Padding = new Padding(5);
            buttonUsers.Size = new Size(165, 55);
            buttonUsers.TabIndex = 5;
            buttonUsers.Text = "المستخدمين";
            buttonUsers.UseVisualStyleBackColor = true;
            // 
            // buttonAbouts
            // 
            buttonAbouts.BackColor = Color.White;
            buttonAbouts.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAbouts.ForeColor = Color.Black;
            buttonAbouts.Image = Properties.Resources.About;
            buttonAbouts.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAbouts.Location = new Point(935, 75);
            buttonAbouts.Margin = new Padding(5);
            buttonAbouts.Name = "buttonAbouts";
            buttonAbouts.Padding = new Padding(5);
            buttonAbouts.Size = new Size(165, 55);
            buttonAbouts.TabIndex = 6;
            buttonAbouts.Text = "حول\r\n";
            buttonAbouts.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.White;
            buttonSettings.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSettings.ForeColor = Color.Black;
            buttonSettings.Image = Properties.Resources.Automatic;
            buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSettings.Location = new Point(760, 75);
            buttonSettings.Margin = new Padding(5);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Padding = new Padding(5);
            buttonSettings.Size = new Size(165, 55);
            buttonSettings.TabIndex = 7;
            buttonSettings.Text = "الاعدادات";
            buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.White;
            buttonLogOut.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogOut.ForeColor = Color.Black;
            buttonLogOut.Image = Properties.Resources.Logout_1;
            buttonLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogOut.Location = new Point(585, 75);
            buttonLogOut.Margin = new Padding(5);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Padding = new Padding(5);
            buttonLogOut.Size = new Size(165, 55);
            buttonLogOut.TabIndex = 8;
            buttonLogOut.Text = "خروج";
            buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.White;
            buttonHelp.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHelp.ForeColor = Color.Black;
            buttonHelp.Image = Properties.Resources.Help;
            buttonHelp.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHelp.Location = new Point(410, 75);
            buttonHelp.Margin = new Padding(5);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Padding = new Padding(5);
            buttonHelp.Size = new Size(165, 55);
            buttonHelp.TabIndex = 9;
            buttonHelp.Text = "مساعدة";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            panelContainer.Location = new Point(0, 77);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1132, 463);
            panelContainer.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 540);
            Controls.Add(panelContainer);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Main";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ASRFLY";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonHome;
        private Button buttonCategory;
        private Button buttonCustomers;
        private Button buttonSuppliers;
        private Button buttonProjects;
        private Button buttonUsers;
        private Button buttonAbouts;
        private Button buttonSettings;
        private Button buttonLogOut;
        private Button buttonHelp;
        public Panel panelContainer;
    }
}