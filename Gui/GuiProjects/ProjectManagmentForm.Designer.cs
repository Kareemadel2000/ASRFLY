namespace ASRFLY.Gui.GuiProjects
{
    partial class ProjectManagmentForm
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
            labelRev = new Label();
            labelIncome = new Label();
            labelOutcome = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelInCome = new Panel();
            panelOutCome = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelRev);
            panel1.Controls.Add(labelIncome);
            panel1.Controls.Add(labelOutcome);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 557);
            panel1.Name = "panel1";
            panel1.Size = new Size(1062, 116);
            panel1.TabIndex = 0;
            // 
            // labelRev
            // 
            labelRev.BackColor = Color.DarkGray;
            labelRev.BorderStyle = BorderStyle.Fixed3D;
            labelRev.Dock = DockStyle.Left;
            labelRev.Location = new Point(380, 0);
            labelRev.Name = "labelRev";
            labelRev.Size = new Size(180, 116);
            labelRev.TabIndex = 3;
            labelRev.Text = "الارباح:0000000";
            labelRev.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelIncome
            // 
            labelIncome.BackColor = Color.Gold;
            labelIncome.BorderStyle = BorderStyle.Fixed3D;
            labelIncome.Dock = DockStyle.Left;
            labelIncome.Location = new Point(190, 0);
            labelIncome.Name = "labelIncome";
            labelIncome.Size = new Size(190, 116);
            labelIncome.TabIndex = 2;
            labelIncome.Text = "المقبوضات:000000";
            labelIncome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOutcome
            // 
            labelOutcome.BackColor = Color.DarkOrange;
            labelOutcome.BorderStyle = BorderStyle.Fixed3D;
            labelOutcome.Dock = DockStyle.Left;
            labelOutcome.Location = new Point(0, 0);
            labelOutcome.Name = "labelOutcome";
            labelOutcome.Size = new Size(190, 116);
            labelOutcome.TabIndex = 1;
            labelOutcome.Text = "المصروفات:000000";
            labelOutcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(255, 192, 128);
            label1.Font = new Font("Calibri", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(648, 0);
            label1.Name = "label1";
            label1.Size = new Size(414, 116);
            label1.TabIndex = 0;
            label1.Text = "أدارة صرفيات المشاريع";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelInCome, 1, 0);
            tableLayoutPanel1.Controls.Add(panelOutCome, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1062, 557);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panelInCome
            // 
            panelInCome.Dock = DockStyle.Fill;
            panelInCome.Location = new Point(3, 3);
            panelInCome.Name = "panelInCome";
            panelInCome.Size = new Size(525, 551);
            panelInCome.TabIndex = 0;
            // 
            // panelOutCome
            // 
            panelOutCome.BackColor = Color.White;
            panelOutCome.Dock = DockStyle.Fill;
            panelOutCome.Location = new Point(534, 3);
            panelOutCome.Name = "panelOutCome";
            panelOutCome.Size = new Size(525, 551);
            panelOutCome.TabIndex = 1;
            // 
            // ProjectManagmentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ProjectManagmentForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "أدارة المشروع ";
            WindowState = FormWindowState.Maximized;
            Activated += ProjectManagmentForm_Activated;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelInCome;
        private Panel panelOutCome;
        private Label labelRev;
        private Label labelIncome;
        private Label labelOutcome;
    }
}