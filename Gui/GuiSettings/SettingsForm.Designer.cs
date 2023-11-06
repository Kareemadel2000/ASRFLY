namespace ASRFLY.Gui.GuiSettings
{
    partial class SettingsForm
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
            groupBox1 = new GroupBox();
            buttonSaveSettings = new Button();
            linkLabelImportImage = new LinkLabel();
            pictureBoxLogo = new PictureBox();
            numericUpDownDataRow = new NumericUpDown();
            numericUpDownnotifications = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxCompany = new TextBox();
            label9 = new Label();
            textBoxServer = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            buttonSaveConnections = new Button();
            radioButtonNetworkConnections = new RadioButton();
            radioButtonLocalConnections = new RadioButton();
            textBoxDataBase = new TextBox();
            label5 = new Label();
            numericUpDownTimeOut = new NumericUpDown();
            textBoxPassword = new TextBox();
            label8 = new Label();
            textBoxUserName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDataRow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownnotifications).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTimeOut).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSaveSettings);
            groupBox1.Controls.Add(linkLabelImportImage);
            groupBox1.Controls.Add(pictureBoxLogo);
            groupBox1.Controls.Add(numericUpDownDataRow);
            groupBox1.Controls.Add(numericUpDownnotifications);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxCompany);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(459, 558);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "الاعدادات العامة";
            // 
            // buttonSaveSettings
            // 
            buttonSaveSettings.BackColor = SystemColors.ActiveCaption;
            buttonSaveSettings.FlatAppearance.BorderSize = 0;
            buttonSaveSettings.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSaveSettings.ForeColor = Color.Black;
            buttonSaveSettings.Image = Resources.Save_1;
            buttonSaveSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveSettings.Location = new Point(15, 482);
            buttonSaveSettings.Margin = new Padding(5);
            buttonSaveSettings.Name = "buttonSaveSettings";
            buttonSaveSettings.Padding = new Padding(5);
            buttonSaveSettings.Size = new Size(422, 55);
            buttonSaveSettings.TabIndex = 7;
            buttonSaveSettings.Text = "حفظ";
            buttonSaveSettings.UseVisualStyleBackColor = false;
            buttonSaveSettings.Click += buttonSaveSettings_Click;
            // 
            // linkLabelImportImage
            // 
            linkLabelImportImage.AutoSize = true;
            linkLabelImportImage.Location = new Point(148, 411);
            linkLabelImportImage.Name = "linkLabelImportImage";
            linkLabelImportImage.Size = new Size(95, 24);
            linkLabelImportImage.TabIndex = 4;
            linkLabelImportImage.TabStop = true;
            linkLabelImportImage.Text = "تحميل صورة";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Resources.Technology_1;
            pictureBoxLogo.Location = new Point(80, 288);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(247, 112);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 3;
            pictureBoxLogo.TabStop = false;
            // 
            // numericUpDownDataRow
            // 
            numericUpDownDataRow.Location = new Point(15, 161);
            numericUpDownDataRow.Name = "numericUpDownDataRow";
            numericUpDownDataRow.Size = new Size(163, 32);
            numericUpDownDataRow.TabIndex = 2;
            numericUpDownDataRow.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // numericUpDownnotifications
            // 
            numericUpDownnotifications.Location = new Point(15, 100);
            numericUpDownnotifications.Name = "numericUpDownnotifications";
            numericUpDownnotifications.Size = new Size(163, 32);
            numericUpDownnotifications.TabIndex = 2;
            numericUpDownnotifications.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(148, 244);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 0;
            label4.Text = "شعار المؤسسة";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(271, 169);
            label3.Name = "label3";
            label3.Size = new Size(166, 24);
            label3.TabIndex = 0;
            label3.Text = "عدد البيانات المعروضة";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(243, 108);
            label2.Name = "label2";
            label2.Size = new Size(194, 24);
            label2.TabIndex = 0;
            label2.Text = "فترة عرض الاشعارات(ثوانى) ";
            // 
            // textBoxCompany
            // 
            textBoxCompany.Cursor = Cursors.IBeam;
            textBoxCompany.Location = new Point(15, 47);
            textBoxCompany.Name = "textBoxCompany";
            textBoxCompany.Size = new Size(285, 32);
            textBoxCompany.TabIndex = 1;
            textBoxCompany.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(333, 55);
            label9.Name = "label9";
            label9.Size = new Size(104, 24);
            label9.TabIndex = 0;
            label9.Text = "اسم المؤسسة";
            // 
            // textBoxServer
            // 
            textBoxServer.Cursor = Cursors.IBeam;
            textBoxServer.Location = new Point(17, 72);
            textBoxServer.Name = "textBoxServer";
            textBoxServer.Size = new Size(319, 32);
            textBoxServer.TabIndex = 1;
            textBoxServer.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(430, 80);
            label1.Name = "label1";
            label1.Size = new Size(59, 24);
            label1.TabIndex = 0;
            label1.Text = "السيرفر";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(477, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(524, 571);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "قواعد البيانات";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonSaveConnections);
            groupBox4.Controls.Add(radioButtonNetworkConnections);
            groupBox4.Controls.Add(radioButtonLocalConnections);
            groupBox4.Controls.Add(textBoxDataBase);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(numericUpDownTimeOut);
            groupBox4.Controls.Add(textBoxPassword);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(textBoxUserName);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(textBoxServer);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(label6);
            groupBox4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(10, 31);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(497, 404);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "نص الأتصال";
            // 
            // buttonSaveConnections
            // 
            buttonSaveConnections.BackColor = SystemColors.ActiveCaption;
            buttonSaveConnections.FlatAppearance.BorderSize = 0;
            buttonSaveConnections.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSaveConnections.ForeColor = Color.Black;
            buttonSaveConnections.Image = Resources.Save_1;
            buttonSaveConnections.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveConnections.Location = new Point(17, 337);
            buttonSaveConnections.Margin = new Padding(5);
            buttonSaveConnections.Name = "buttonSaveConnections";
            buttonSaveConnections.Padding = new Padding(5);
            buttonSaveConnections.Size = new Size(432, 59);
            buttonSaveConnections.TabIndex = 7;
            buttonSaveConnections.Text = "حفظ";
            buttonSaveConnections.UseVisualStyleBackColor = false;
            buttonSaveConnections.Click += buttonSaveConnections_Click;
            // 
            // radioButtonNetworkConnections
            // 
            radioButtonNetworkConnections.AutoSize = true;
            radioButtonNetworkConnections.Location = new Point(17, 31);
            radioButtonNetworkConnections.Name = "radioButtonNetworkConnections";
            radioButtonNetworkConnections.Size = new Size(66, 28);
            radioButtonNetworkConnections.TabIndex = 0;
            radioButtonNetworkConnections.Text = "شبكى";
            radioButtonNetworkConnections.UseVisualStyleBackColor = true;
            // 
            // radioButtonLocalConnections
            // 
            radioButtonLocalConnections.AutoSize = true;
            radioButtonLocalConnections.Checked = true;
            radioButtonLocalConnections.Location = new Point(145, 31);
            radioButtonLocalConnections.Name = "radioButtonLocalConnections";
            radioButtonLocalConnections.Size = new Size(67, 28);
            radioButtonLocalConnections.TabIndex = 0;
            radioButtonLocalConnections.TabStop = true;
            radioButtonLocalConnections.Text = "محلى";
            radioButtonLocalConnections.UseVisualStyleBackColor = true;
            // 
            // textBoxDataBase
            // 
            textBoxDataBase.Cursor = Cursors.IBeam;
            textBoxDataBase.Location = new Point(17, 125);
            textBoxDataBase.Name = "textBoxDataBase";
            textBoxDataBase.Size = new Size(319, 32);
            textBoxDataBase.TabIndex = 1;
            textBoxDataBase.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(385, 133);
            label5.Name = "label5";
            label5.Size = new Size(106, 24);
            label5.TabIndex = 0;
            label5.Text = "قاعدة البيانات";
            // 
            // numericUpDownTimeOut
            // 
            numericUpDownTimeOut.Location = new Point(17, 178);
            numericUpDownTimeOut.Name = "numericUpDownTimeOut";
            numericUpDownTimeOut.Size = new Size(319, 32);
            numericUpDownTimeOut.TabIndex = 2;
            numericUpDownTimeOut.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // textBoxPassword
            // 
            textBoxPassword.Cursor = Cursors.IBeam;
            textBoxPassword.Location = new Point(17, 284);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(319, 32);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(414, 292);
            label8.Name = "label8";
            label8.Size = new Size(75, 24);
            label8.TabIndex = 0;
            label8.Text = "كلمة السر";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Cursor = Cursors.IBeam;
            textBoxUserName.Location = new Point(17, 231);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(319, 32);
            textBoxUserName.TabIndex = 1;
            textBoxUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(377, 239);
            label7.Name = "label7";
            label7.Size = new Size(112, 24);
            label7.TabIndex = 0;
            label7.Text = "اسم المستخدم";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(351, 186);
            label6.Name = "label6";
            label6.Size = new Size(138, 24);
            label6.TabIndex = 0;
            label6.Text = "فترة الاتصال(ثانية) ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(19, 441);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(488, 117);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "النسخ الاحتياطى والتعيين";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Image = Resources.Database_Restore;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(8, 42);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Padding = new Padding(5);
            button2.Size = new Size(258, 55);
            button2.TabIndex = 7;
            button2.Text = "     أستعادة النسخة الاحتياطية\r\n";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Image = Resources.Data_Backup;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(276, 42);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Padding = new Padding(5);
            button1.Size = new Size(204, 55);
            button1.TabIndex = 7;
            button1.Text = "النسخ الاحتياطى";
            button1.UseVisualStyleBackColor = false;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 587);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " أعدادات النظام";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDataRow).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownnotifications).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTimeOut).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxServer;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDownDataRow;
        private NumericUpDown numericUpDownnotifications;
        private LinkLabel linkLabelImportImage;
        private PictureBox pictureBoxLogo;
        private Label label4;
        private Button buttonSaveSettings;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button1;
        private Button button2;
        private GroupBox groupBox4;
        private RadioButton radioButtonNetworkConnections;
        private RadioButton radioButtonLocalConnections;
        private TextBox textBoxDataBase;
        private Label label5;
        private NumericUpDown numericUpDownTimeOut;
        private Label label6;
        private Button buttonSaveConnections;
        private TextBox textBoxPassword;
        private Label label8;
        private TextBox textBoxUserName;
        private Label label7;
        private TextBox textBoxCompany;
        private Label label9;
    }
}