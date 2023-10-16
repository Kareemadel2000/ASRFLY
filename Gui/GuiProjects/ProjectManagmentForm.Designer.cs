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
            tableLayoutPanel1 = new TableLayoutPanel();
            panelInCome = new Panel();
            panelOutCome = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 557);
            panel1.Name = "panel1";
            panel1.Size = new Size(1062, 116);
            panel1.TabIndex = 0;
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
            panelOutCome.Dock = DockStyle.Fill;
            panelOutCome.Location = new Point(534, 3);
            panelOutCome.Name = "panelOutCome";
            panelOutCome.Size = new Size(525, 551);
            panelOutCome.TabIndex = 1;
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
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(190, 116);
            label2.TabIndex = 1;
            label2.Text = "المصروفات:0000000";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Left;
            label3.Location = new Point(190, 0);
            label3.Name = "label3";
            label3.Size = new Size(190, 116);
            label3.TabIndex = 2;
            label3.Text = "المقبوضات:0000000";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Dock = DockStyle.Left;
            label4.Location = new Point(380, 0);
            label4.Name = "label4";
            label4.Size = new Size(180, 116);
            label4.TabIndex = 3;
            label4.Text = "الارباح:0000000";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // ProjectManagmentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ProjectManagmentForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "أدارة المشروع ";
            TopMost = true;
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
        private Label label4;
        private Label label3;
        private Label label2;
    }
}