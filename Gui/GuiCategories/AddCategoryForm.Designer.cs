namespace ASRFLY.Gui.GuiCategories
{
    partial class AddCategoryForm
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
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            buttonExport = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonExport);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 523);
            panel1.Name = "panel1";
            panel1.Size = new Size(606, 83);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(584, 506);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الصنف";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 238);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(570, 153);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "صرف ", "قبض" });
            comboBox1.Location = new Point(6, 169);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(570, 27);
            comboBox1.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(6, 449);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(570, 27);
            textBox4.TabIndex = 7;
            textBox4.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 414);
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
            label3.Size = new Size(68, 19);
            label3.TabIndex = 4;
            label3.Text = "نوع الصنف";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 207);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 2;
            label2.Text = "التفاصيل";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(570, 27);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 33);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 0;
            label1.Text = "اسم الصنف";
            // 
            // buttonExport
            // 
            buttonExport.BackColor = Color.White;
            buttonExport.FlatAppearance.BorderSize = 0;
            buttonExport.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExport.ForeColor = Color.Black;
            buttonExport.Image = Properties.Resources.Save;
            buttonExport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExport.Location = new Point(380, 14);
            buttonExport.Margin = new Padding(5);
            buttonExport.Name = "buttonExport";
            buttonExport.Padding = new Padding(5);
            buttonExport.Size = new Size(221, 55);
            buttonExport.TabIndex = 5;
            buttonExport.Text = "حفظ وغلق";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.Save_1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(16, 14);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Padding = new Padding(5);
            button1.Size = new Size(124, 55);
            button1.TabIndex = 6;
            button1.Text = "حفظ";
            button1.UseVisualStyleBackColor = true;
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 606);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCategoryForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "أضافة / تعديل صنف";
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
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox4;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private Button buttonExport;
        private Button button1;
    }
}