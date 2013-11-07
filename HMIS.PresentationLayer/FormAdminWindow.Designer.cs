namespace HMIS.PresentationLayer
{
    partial class FormAdminWindow
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
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabPageDoctors = new System.Windows.Forms.TabPage();
            this.listViewAdminD = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.buttonAdminDRemove = new System.Windows.Forms.Button();
            this.buttonAdminDAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGenerateID = new System.Windows.Forms.Button();
            this.textBoxAdminDPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdminDClear = new System.Windows.Forms.Button();
            this.textBoxAdminDUsername = new System.Windows.Forms.TextBox();
            this.textBoxAdminDAddress = new System.Windows.Forms.TextBox();
            this.textBoxAdminDID = new System.Windows.Forms.TextBox();
            this.textBoxAdminDName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonAdminNRemove = new System.Windows.Forms.Button();
            this.buttonAdminNAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxAdminNMain = new System.Windows.Forms.CheckBox();
            this.buttonAdminNGenerateID = new System.Windows.Forms.Button();
            this.textBoxAdminNPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAdminNClear = new System.Windows.Forms.Button();
            this.textBoxAdminNUsername = new System.Windows.Forms.TextBox();
            this.textBoxAdminNAddress = new System.Windows.Forms.TextBox();
            this.textBoxAdminNID = new System.Windows.Forms.TextBox();
            this.textBoxAdminNName = new System.Windows.Forms.TextBox();
            this.listViewAdminN = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabAdmin.SuspendLayout();
            this.tabPageDoctors.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabPageDoctors);
            this.tabAdmin.Controls.Add(this.tabPage2);
            this.tabAdmin.Location = new System.Drawing.Point(12, 178);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(779, 347);
            this.tabAdmin.TabIndex = 7;
            // 
            // tabPageDoctors
            // 
            this.tabPageDoctors.Controls.Add(this.listViewAdminD);
            this.tabPageDoctors.Controls.Add(this.buttonAdminDRemove);
            this.tabPageDoctors.Controls.Add(this.buttonAdminDAdd);
            this.tabPageDoctors.Controls.Add(this.panel2);
            this.tabPageDoctors.Location = new System.Drawing.Point(4, 22);
            this.tabPageDoctors.Name = "tabPageDoctors";
            this.tabPageDoctors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoctors.Size = new System.Drawing.Size(771, 321);
            this.tabPageDoctors.TabIndex = 0;
            this.tabPageDoctors.Text = "Doctors";
            this.tabPageDoctors.UseVisualStyleBackColor = true;
            // 
            // listViewAdminD
            // 
            this.listViewAdminD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewAdminD.Location = new System.Drawing.Point(7, 7);
            this.listViewAdminD.Name = "listViewAdminD";
            this.listViewAdminD.Size = new System.Drawing.Size(272, 305);
            this.listViewAdminD.TabIndex = 4;
            this.listViewAdminD.UseCompatibleStateImageBehavior = false;
            this.listViewAdminD.View = System.Windows.Forms.View.Details;
            this.listViewAdminD.SelectedIndexChanged += new System.EventHandler(this.listViewAdminD_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 207;
            // 
            // buttonAdminDRemove
            // 
            this.buttonAdminDRemove.Location = new System.Drawing.Point(628, 60);
            this.buttonAdminDRemove.Name = "buttonAdminDRemove";
            this.buttonAdminDRemove.Size = new System.Drawing.Size(96, 23);
            this.buttonAdminDRemove.TabIndex = 3;
            this.buttonAdminDRemove.Text = "Remove doctor";
            this.buttonAdminDRemove.UseVisualStyleBackColor = true;
            this.buttonAdminDRemove.Click += new System.EventHandler(this.buttonAdminDRemove_Click);
            // 
            // buttonAdminDAdd
            // 
            this.buttonAdminDAdd.Location = new System.Drawing.Point(628, 26);
            this.buttonAdminDAdd.Name = "buttonAdminDAdd";
            this.buttonAdminDAdd.Size = new System.Drawing.Size(96, 23);
            this.buttonAdminDAdd.TabIndex = 2;
            this.buttonAdminDAdd.Text = "Add doctor";
            this.buttonAdminDAdd.UseVisualStyleBackColor = true;
            this.buttonAdminDAdd.Click += new System.EventHandler(this.buttonAdminDAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonGenerateID);
            this.panel2.Controls.Add(this.textBoxAdminDPassword);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonAdminDClear);
            this.panel2.Controls.Add(this.textBoxAdminDUsername);
            this.panel2.Controls.Add(this.textBoxAdminDAddress);
            this.panel2.Controls.Add(this.textBoxAdminDID);
            this.panel2.Controls.Add(this.textBoxAdminDName);
            this.panel2.Location = new System.Drawing.Point(285, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 303);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Generate username and password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGenerateID
            // 
            this.buttonGenerateID.Location = new System.Drawing.Point(15, 267);
            this.buttonGenerateID.Name = "buttonGenerateID";
            this.buttonGenerateID.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateID.TabIndex = 13;
            this.buttonGenerateID.Text = "Generate ID";
            this.buttonGenerateID.UseVisualStyleBackColor = true;
            this.buttonGenerateID.Click += new System.EventHandler(this.buttonGenerateID_Click);
            // 
            // textBoxAdminDPassword
            // 
            this.textBoxAdminDPassword.Location = new System.Drawing.Point(84, 161);
            this.textBoxAdminDPassword.Name = "textBoxAdminDPassword";
            this.textBoxAdminDPassword.ReadOnly = true;
            this.textBoxAdminDPassword.Size = new System.Drawing.Size(191, 20);
            this.textBoxAdminDPassword.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // buttonAdminDClear
            // 
            this.buttonAdminDClear.Location = new System.Drawing.Point(201, 267);
            this.buttonAdminDClear.Name = "buttonAdminDClear";
            this.buttonAdminDClear.Size = new System.Drawing.Size(75, 23);
            this.buttonAdminDClear.TabIndex = 5;
            this.buttonAdminDClear.Text = "Clear";
            this.buttonAdminDClear.UseVisualStyleBackColor = true;
            this.buttonAdminDClear.Click += new System.EventHandler(this.buttonAdminDClear_Click);
            // 
            // textBoxAdminDUsername
            // 
            this.textBoxAdminDUsername.Location = new System.Drawing.Point(85, 124);
            this.textBoxAdminDUsername.Name = "textBoxAdminDUsername";
            this.textBoxAdminDUsername.ReadOnly = true;
            this.textBoxAdminDUsername.Size = new System.Drawing.Size(191, 20);
            this.textBoxAdminDUsername.TabIndex = 3;
            // 
            // textBoxAdminDAddress
            // 
            this.textBoxAdminDAddress.Location = new System.Drawing.Point(85, 84);
            this.textBoxAdminDAddress.Name = "textBoxAdminDAddress";
            this.textBoxAdminDAddress.Size = new System.Drawing.Size(191, 20);
            this.textBoxAdminDAddress.TabIndex = 2;
            // 
            // textBoxAdminDID
            // 
            this.textBoxAdminDID.Location = new System.Drawing.Point(85, 46);
            this.textBoxAdminDID.Name = "textBoxAdminDID";
            this.textBoxAdminDID.ReadOnly = true;
            this.textBoxAdminDID.Size = new System.Drawing.Size(191, 20);
            this.textBoxAdminDID.TabIndex = 1;
            // 
            // textBoxAdminDName
            // 
            this.textBoxAdminDName.Location = new System.Drawing.Point(85, 12);
            this.textBoxAdminDName.Name = "textBoxAdminDName";
            this.textBoxAdminDName.Size = new System.Drawing.Size(191, 20);
            this.textBoxAdminDName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonAdminNRemove);
            this.tabPage2.Controls.Add(this.buttonAdminNAdd);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.listViewAdminN);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(771, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nurses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAdminNRemove
            // 
            this.buttonAdminNRemove.Location = new System.Drawing.Point(629, 60);
            this.buttonAdminNRemove.Name = "buttonAdminNRemove";
            this.buttonAdminNRemove.Size = new System.Drawing.Size(96, 23);
            this.buttonAdminNRemove.TabIndex = 8;
            this.buttonAdminNRemove.Text = "Remove nurse";
            this.buttonAdminNRemove.UseVisualStyleBackColor = true;
            this.buttonAdminNRemove.Click += new System.EventHandler(this.buttonAdminNRemove_Click);
            // 
            // buttonAdminNAdd
            // 
            this.buttonAdminNAdd.Location = new System.Drawing.Point(629, 26);
            this.buttonAdminNAdd.Name = "buttonAdminNAdd";
            this.buttonAdminNAdd.Size = new System.Drawing.Size(96, 23);
            this.buttonAdminNAdd.TabIndex = 7;
            this.buttonAdminNAdd.Text = "Add nurse";
            this.buttonAdminNAdd.UseVisualStyleBackColor = true;
            this.buttonAdminNAdd.Click += new System.EventHandler(this.buttonAdminNAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.checkBoxAdminNMain);
            this.panel1.Controls.Add(this.buttonAdminNGenerateID);
            this.panel1.Controls.Add(this.textBoxAdminNPass);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.buttonAdminNClear);
            this.panel1.Controls.Add(this.textBoxAdminNUsername);
            this.panel1.Controls.Add(this.textBoxAdminNAddress);
            this.panel1.Controls.Add(this.textBoxAdminNID);
            this.panel1.Controls.Add(this.textBoxAdminNName);
            this.panel1.Location = new System.Drawing.Point(284, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 303);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Generate username and password";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxAdminNMain
            // 
            this.checkBoxAdminNMain.AutoSize = true;
            this.checkBoxAdminNMain.Location = new System.Drawing.Point(7, 201);
            this.checkBoxAdminNMain.Name = "checkBoxAdminNMain";
            this.checkBoxAdminNMain.Size = new System.Drawing.Size(78, 17);
            this.checkBoxAdminNMain.TabIndex = 15;
            this.checkBoxAdminNMain.Text = "Main nurse";
            this.checkBoxAdminNMain.UseVisualStyleBackColor = true;
            // 
            // buttonAdminNGenerateID
            // 
            this.buttonAdminNGenerateID.Location = new System.Drawing.Point(16, 266);
            this.buttonAdminNGenerateID.Name = "buttonAdminNGenerateID";
            this.buttonAdminNGenerateID.Size = new System.Drawing.Size(75, 23);
            this.buttonAdminNGenerateID.TabIndex = 13;
            this.buttonAdminNGenerateID.Text = "Generate ID";
            this.buttonAdminNGenerateID.UseVisualStyleBackColor = true;
            this.buttonAdminNGenerateID.Click += new System.EventHandler(this.buttonAdminNGenerateID_Click);
            // 
            // textBoxAdminNPass
            // 
            this.textBoxAdminNPass.Location = new System.Drawing.Point(85, 160);
            this.textBoxAdminNPass.Name = "textBoxAdminNPass";
            this.textBoxAdminNPass.ReadOnly = true;
            this.textBoxAdminNPass.Size = new System.Drawing.Size(191, 20);
            this.textBoxAdminNPass.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Name:";
            // 
            // buttonAdminNClear
            // 
            this.buttonAdminNClear.Location = new System.Drawing.Point(202, 266);
            this.buttonAdminNClear.Name = "buttonAdminNClear";
            this.buttonAdminNClear.Size = new System.Drawing.Size(75, 23);
            this.buttonAdminNClear.TabIndex = 5;
            this.buttonAdminNClear.Text = "Clear";
            this.buttonAdminNClear.UseVisualStyleBackColor = true;
            this.buttonAdminNClear.Click += new System.EventHandler(this.buttonAdminNClear_Click);
            // 
            // textBoxAdminNUsername
            // 
            this.textBoxAdminNUsername.Location = new System.Drawing.Point(86, 123);
            this.textBoxAdminNUsername.Name = "textBoxAdminNUsername";
            this.textBoxAdminNUsername.ReadOnly = true;
            this.textBoxAdminNUsername.Size = new System.Drawing.Size(191, 20);
            this.textBoxAdminNUsername.TabIndex = 3;
            // 
            // textBoxAdminNAddress
            // 
            this.textBoxAdminNAddress.Location = new System.Drawing.Point(86, 83);
            this.textBoxAdminNAddress.Name = "textBoxAdminNAddress";
            this.textBoxAdminNAddress.Size = new System.Drawing.Size(191, 20);
            this.textBoxAdminNAddress.TabIndex = 2;
            // 
            // textBoxAdminNID
            // 
            this.textBoxAdminNID.Location = new System.Drawing.Point(86, 45);
            this.textBoxAdminNID.Name = "textBoxAdminNID";
            this.textBoxAdminNID.ReadOnly = true;
            this.textBoxAdminNID.Size = new System.Drawing.Size(191, 20);
            this.textBoxAdminNID.TabIndex = 1;
            // 
            // textBoxAdminNName
            // 
            this.textBoxAdminNName.Location = new System.Drawing.Point(86, 11);
            this.textBoxAdminNName.Name = "textBoxAdminNName";
            this.textBoxAdminNName.Size = new System.Drawing.Size(191, 20);
            this.textBoxAdminNName.TabIndex = 0;
            // 
            // listViewAdminN
            // 
            this.listViewAdminN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewAdminN.Location = new System.Drawing.Point(7, 7);
            this.listViewAdminN.Name = "listViewAdminN";
            this.listViewAdminN.Size = new System.Drawing.Size(272, 305);
            this.listViewAdminN.TabIndex = 5;
            this.listViewAdminN.UseCompatibleStateImageBehavior = false;
            this.listViewAdminN.View = System.Windows.Forms.View.Details;
            this.listViewAdminN.SelectedIndexChanged += new System.EventHandler(this.listViewAdminN_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 207;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemLogout
            // 
            this.toolStripMenuItemLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItemLogout.Name = "toolStripMenuItemLogout";
            this.toolStripMenuItemLogout.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItemLogout.Text = "Logout";
            this.toolStripMenuItemLogout.Click += new System.EventHandler(this.toolStripMenuItemLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::HMIS.PresentationLayer.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(779, 145);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormAdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAdminWindow";
            this.Load += new System.EventHandler(this.FormAdminWindow_Load);
            this.tabAdmin.ResumeLayout(false);
            this.tabPageDoctors.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabPageDoctors;
        private System.Windows.Forms.Button buttonAdminDRemove;
        private System.Windows.Forms.Button buttonAdminDAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAdminDClear;
        private System.Windows.Forms.TextBox textBoxAdminDUsername;
        private System.Windows.Forms.TextBox textBoxAdminDAddress;
        private System.Windows.Forms.TextBox textBoxAdminDID;
        private System.Windows.Forms.TextBox textBoxAdminDName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewAdminD;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdminDPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGenerateID;
        private System.Windows.Forms.Button buttonAdminNRemove;
        private System.Windows.Forms.Button buttonAdminNAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdminNGenerateID;
        private System.Windows.Forms.TextBox textBoxAdminNPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonAdminNClear;
        private System.Windows.Forms.TextBox textBoxAdminNUsername;
        private System.Windows.Forms.TextBox textBoxAdminNAddress;
        private System.Windows.Forms.TextBox textBoxAdminNID;
        private System.Windows.Forms.TextBox textBoxAdminNName;
        private System.Windows.Forms.ListView listViewAdminN;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.CheckBox checkBoxAdminNMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;


    }
}