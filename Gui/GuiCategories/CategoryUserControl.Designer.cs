namespace ASRFLY.Gui.GuiCategories
{
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonCategory = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            textBox1 = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.Control;
            flowLayoutPanel1.Controls.Add(buttonCategory);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(1262, 76);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonCategory
            // 
            buttonCategory.BackColor = Color.White;
            buttonCategory.FlatAppearance.BorderSize = 0;
            buttonCategory.FlatStyle = FlatStyle.Popup;
            buttonCategory.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCategory.ForeColor = Color.Black;
            buttonCategory.Image = Properties.Resources.Add;
            buttonCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCategory.Location = new Point(1105, 10);
            buttonCategory.Margin = new Padding(5);
            buttonCategory.Name = "buttonCategory";
            buttonCategory.Padding = new Padding(5);
            buttonCategory.Size = new Size(142, 55);
            buttonCategory.TabIndex = 1;
            buttonCategory.Text = "أضافة";
            buttonCategory.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.Close;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(953, 10);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Padding = new Padding(5);
            button1.Size = new Size(142, 55);
            button1.TabIndex = 2;
            button1.Text = "حذف";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Image = Properties.Resources.Slider;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(801, 10);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Padding = new Padding(5);
            button2.Size = new Size(142, 55);
            button2.TabIndex = 3;
            button2.Text = "تعديل";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Image = Properties.Resources.Export;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(649, 10);
            button3.Margin = new Padding(5);
            button3.Name = "button3";
            button3.Padding = new Padding(5);
            button3.Size = new Size(142, 55);
            button3.TabIndex = 4;
            button3.Text = "تصدير";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(216, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 57);
            panel1.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.Dock = DockStyle.Left;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Image = Properties.Resources.Search_2;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 0);
            button4.Margin = new Padding(5);
            button4.Name = "button4";
            button4.Padding = new Padding(5);
            button4.Size = new Size(92, 55);
            button4.TabIndex = 5;
            button4.Text = "       بحث";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 30F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(92, 0);
            textBox1.Margin = new Padding(5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 56);
            textBox1.TabIndex = 7;
            // 
            // CategoryUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CategoryUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1262, 600);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonCategory;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Button button4;
        private TextBox textBox1;
    }
}
