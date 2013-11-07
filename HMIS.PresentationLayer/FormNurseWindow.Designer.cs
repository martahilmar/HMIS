namespace HMIS.PresentationLayer
{
    partial class FormNurseWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageNPacInfo = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxNDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNClear = new System.Windows.Forms.Button();
            this.buttonNViewDiagnosis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNPatAdd = new System.Windows.Forms.TextBox();
            this.textBoxNPatID = new System.Windows.Forms.TextBox();
            this.textBoxNPatName = new System.Windows.Forms.TextBox();
            this.listViewNursePat = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.tabPageNPacAdd = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxMNDoctorPat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxMNDoctorAdd = new System.Windows.Forms.TextBox();
            this.textBoxMNDoctorID = new System.Windows.Forms.TextBox();
            this.textBoxMNDoctorName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMNGenerateID = new System.Windows.Forms.Button();
            this.buttonAddPacient = new System.Windows.Forms.Button();
            this.comboBoxMNDoctor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxMNAdd = new System.Windows.Forms.TextBox();
            this.textBoxMNID = new System.Windows.Forms.TextBox();
            this.textBoxMNName = new System.Windows.Forms.TextBox();
            this.tabPageNPacRemove = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxMNPRDoctor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonMNPRClear = new System.Windows.Forms.Button();
            this.buttonMNPRRemove = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxMNPRAdd = new System.Windows.Forms.TextBox();
            this.textBoxMNPRID = new System.Windows.Forms.TextBox();
            this.textBoxMNPRName = new System.Windows.Forms.TextBox();
            this.listViewMNPacRemove = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.pictureBoxDischarged = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageNPacInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPageNPacAdd.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageNPacRemove.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDischarged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLogout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 11;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageNPacInfo);
            this.tabControl1.Controls.Add(this.tabPageNPacAdd);
            this.tabControl1.Controls.Add(this.tabPageNPacRemove);
            this.tabControl1.Location = new System.Drawing.Point(9, 178);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 341);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPageNPacInfo
            // 
            this.tabPageNPacInfo.Controls.Add(this.panel2);
            this.tabPageNPacInfo.Controls.Add(this.listViewNursePat);
            this.tabPageNPacInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageNPacInfo.Name = "tabPageNPacInfo";
            this.tabPageNPacInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNPacInfo.Size = new System.Drawing.Size(771, 315);
            this.tabPageNPacInfo.TabIndex = 0;
            this.tabPageNPacInfo.Text = "Pacient info";
            this.tabPageNPacInfo.UseVisualStyleBackColor = true;
            this.tabPageNPacInfo.Click += new System.EventHandler(this.tabPageNPacInfo_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxNDoc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonNClear);
            this.panel2.Controls.Add(this.buttonNViewDiagnosis);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxNPatAdd);
            this.panel2.Controls.Add(this.textBoxNPatID);
            this.panel2.Controls.Add(this.textBoxNPatName);
            this.panel2.Location = new System.Drawing.Point(368, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 228);
            this.panel2.TabIndex = 8;
            // 
            // textBoxNDoc
            // 
            this.textBoxNDoc.Location = new System.Drawing.Point(108, 137);
            this.textBoxNDoc.Name = "textBoxNDoc";
            this.textBoxNDoc.ReadOnly = true;
            this.textBoxNDoc.Size = new System.Drawing.Size(191, 20);
            this.textBoxNDoc.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Doctor:";
            // 
            // buttonNClear
            // 
            this.buttonNClear.Location = new System.Drawing.Point(197, 187);
            this.buttonNClear.Name = "buttonNClear";
            this.buttonNClear.Size = new System.Drawing.Size(75, 23);
            this.buttonNClear.TabIndex = 5;
            this.buttonNClear.Text = "Clear";
            this.buttonNClear.UseVisualStyleBackColor = true;
            this.buttonNClear.Click += new System.EventHandler(this.buttonNClear_Click);
            // 
            // buttonNViewDiagnosis
            // 
            this.buttonNViewDiagnosis.Location = new System.Drawing.Point(44, 187);
            this.buttonNViewDiagnosis.Name = "buttonNViewDiagnosis";
            this.buttonNViewDiagnosis.Size = new System.Drawing.Size(106, 23);
            this.buttonNViewDiagnosis.TabIndex = 13;
            this.buttonNViewDiagnosis.Text = "View diagnosis";
            this.buttonNViewDiagnosis.UseVisualStyleBackColor = true;
            this.buttonNViewDiagnosis.Click += new System.EventHandler(this.buttonNViewDiagnosis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Name:";
            // 
            // textBoxNPatAdd
            // 
            this.textBoxNPatAdd.Location = new System.Drawing.Point(108, 95);
            this.textBoxNPatAdd.Name = "textBoxNPatAdd";
            this.textBoxNPatAdd.ReadOnly = true;
            this.textBoxNPatAdd.Size = new System.Drawing.Size(191, 20);
            this.textBoxNPatAdd.TabIndex = 2;
            // 
            // textBoxNPatID
            // 
            this.textBoxNPatID.Location = new System.Drawing.Point(108, 57);
            this.textBoxNPatID.Name = "textBoxNPatID";
            this.textBoxNPatID.ReadOnly = true;
            this.textBoxNPatID.Size = new System.Drawing.Size(191, 20);
            this.textBoxNPatID.TabIndex = 1;
            // 
            // textBoxNPatName
            // 
            this.textBoxNPatName.Location = new System.Drawing.Point(108, 20);
            this.textBoxNPatName.Name = "textBoxNPatName";
            this.textBoxNPatName.ReadOnly = true;
            this.textBoxNPatName.Size = new System.Drawing.Size(191, 20);
            this.textBoxNPatName.TabIndex = 0;
            // 
            // listViewNursePat
            // 
            this.listViewNursePat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewNursePat.Location = new System.Drawing.Point(12, 5);
            this.listViewNursePat.Name = "listViewNursePat";
            this.listViewNursePat.Size = new System.Drawing.Size(272, 305);
            this.listViewNursePat.TabIndex = 5;
            this.listViewNursePat.UseCompatibleStateImageBehavior = false;
            this.listViewNursePat.View = System.Windows.Forms.View.Details;
            this.listViewNursePat.SelectedIndexChanged += new System.EventHandler(this.listViewNursePat_SelectedIndexChanged);
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
            // tabPageNPacAdd
            // 
            this.tabPageNPacAdd.Controls.Add(this.panel3);
            this.tabPageNPacAdd.Controls.Add(this.panel1);
            this.tabPageNPacAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageNPacAdd.Name = "tabPageNPacAdd";
            this.tabPageNPacAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNPacAdd.Size = new System.Drawing.Size(771, 315);
            this.tabPageNPacAdd.TabIndex = 1;
            this.tabPageNPacAdd.Text = "Add pacient";
            this.tabPageNPacAdd.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBoxMNDoctorPat);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.textBoxMNDoctorAdd);
            this.panel3.Controls.Add(this.textBoxMNDoctorID);
            this.panel3.Controls.Add(this.textBoxMNDoctorName);
            this.panel3.Location = new System.Drawing.Point(401, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 271);
            this.panel3.TabIndex = 8;
            // 
            // comboBoxMNDoctorPat
            // 
            this.comboBoxMNDoctorPat.FormattingEnabled = true;
            this.comboBoxMNDoctorPat.Location = new System.Drawing.Point(108, 171);
            this.comboBoxMNDoctorPat.Name = "comboBoxMNDoctorPat";
            this.comboBoxMNDoctorPat.Size = new System.Drawing.Size(191, 21);
            this.comboBoxMNDoctorPat.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Patients:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Address:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Name:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(224, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxMNDoctorAdd
            // 
            this.textBoxMNDoctorAdd.Location = new System.Drawing.Point(108, 126);
            this.textBoxMNDoctorAdd.Name = "textBoxMNDoctorAdd";
            this.textBoxMNDoctorAdd.ReadOnly = true;
            this.textBoxMNDoctorAdd.Size = new System.Drawing.Size(191, 20);
            this.textBoxMNDoctorAdd.TabIndex = 2;
            // 
            // textBoxMNDoctorID
            // 
            this.textBoxMNDoctorID.Location = new System.Drawing.Point(108, 77);
            this.textBoxMNDoctorID.Name = "textBoxMNDoctorID";
            this.textBoxMNDoctorID.ReadOnly = true;
            this.textBoxMNDoctorID.Size = new System.Drawing.Size(191, 20);
            this.textBoxMNDoctorID.TabIndex = 1;
            // 
            // textBoxMNDoctorName
            // 
            this.textBoxMNDoctorName.Location = new System.Drawing.Point(108, 24);
            this.textBoxMNDoctorName.Name = "textBoxMNDoctorName";
            this.textBoxMNDoctorName.ReadOnly = true;
            this.textBoxMNDoctorName.Size = new System.Drawing.Size(191, 20);
            this.textBoxMNDoctorName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonMNGenerateID);
            this.panel1.Controls.Add(this.buttonAddPacient);
            this.panel1.Controls.Add(this.comboBoxMNDoctor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBoxMNAdd);
            this.panel1.Controls.Add(this.textBoxMNID);
            this.panel1.Controls.Add(this.textBoxMNName);
            this.panel1.Location = new System.Drawing.Point(40, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 271);
            this.panel1.TabIndex = 7;
            // 
            // buttonMNGenerateID
            // 
            this.buttonMNGenerateID.Location = new System.Drawing.Point(46, 228);
            this.buttonMNGenerateID.Name = "buttonMNGenerateID";
            this.buttonMNGenerateID.Size = new System.Drawing.Size(96, 23);
            this.buttonMNGenerateID.TabIndex = 16;
            this.buttonMNGenerateID.Text = "GenerateID";
            this.buttonMNGenerateID.UseVisualStyleBackColor = true;
            this.buttonMNGenerateID.Click += new System.EventHandler(this.buttonMNGenerateID_Click);
            // 
            // buttonAddPacient
            // 
            this.buttonAddPacient.Location = new System.Drawing.Point(180, 228);
            this.buttonAddPacient.Name = "buttonAddPacient";
            this.buttonAddPacient.Size = new System.Drawing.Size(96, 23);
            this.buttonAddPacient.TabIndex = 13;
            this.buttonAddPacient.Text = "Add pacient";
            this.buttonAddPacient.UseVisualStyleBackColor = true;
            this.buttonAddPacient.Click += new System.EventHandler(this.buttonAddPacient_Click);
            // 
            // comboBoxMNDoctor
            // 
            this.comboBoxMNDoctor.FormattingEnabled = true;
            this.comboBoxMNDoctor.Location = new System.Drawing.Point(108, 130);
            this.comboBoxMNDoctor.Name = "comboBoxMNDoctor";
            this.comboBoxMNDoctor.Size = new System.Drawing.Size(191, 21);
            this.comboBoxMNDoctor.TabIndex = 15;
            this.comboBoxMNDoctor.SelectedIndexChanged += new System.EventHandler(this.comboBoxMNDoctor_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Doctor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxMNAdd
            // 
            this.textBoxMNAdd.Location = new System.Drawing.Point(108, 95);
            this.textBoxMNAdd.Name = "textBoxMNAdd";
            this.textBoxMNAdd.Size = new System.Drawing.Size(191, 20);
            this.textBoxMNAdd.TabIndex = 2;
            // 
            // textBoxMNID
            // 
            this.textBoxMNID.Location = new System.Drawing.Point(108, 59);
            this.textBoxMNID.Name = "textBoxMNID";
            this.textBoxMNID.ReadOnly = true;
            this.textBoxMNID.Size = new System.Drawing.Size(191, 20);
            this.textBoxMNID.TabIndex = 1;
            // 
            // textBoxMNName
            // 
            this.textBoxMNName.Location = new System.Drawing.Point(108, 24);
            this.textBoxMNName.Name = "textBoxMNName";
            this.textBoxMNName.Size = new System.Drawing.Size(191, 20);
            this.textBoxMNName.TabIndex = 0;
            // 
            // tabPageNPacRemove
            // 
            this.tabPageNPacRemove.Controls.Add(this.panel4);
            this.tabPageNPacRemove.Controls.Add(this.listViewMNPacRemove);
            this.tabPageNPacRemove.Location = new System.Drawing.Point(4, 22);
            this.tabPageNPacRemove.Name = "tabPageNPacRemove";
            this.tabPageNPacRemove.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNPacRemove.Size = new System.Drawing.Size(771, 315);
            this.tabPageNPacRemove.TabIndex = 2;
            this.tabPageNPacRemove.Text = "Remove pacient";
            this.tabPageNPacRemove.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBoxDischarged);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.textBoxMNPRDoctor);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.buttonMNPRClear);
            this.panel4.Controls.Add(this.buttonMNPRRemove);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.textBoxMNPRAdd);
            this.panel4.Controls.Add(this.textBoxMNPRID);
            this.panel4.Controls.Add(this.textBoxMNPRName);
            this.panel4.Location = new System.Drawing.Point(375, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(323, 253);
            this.panel4.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Discharge:";
            // 
            // textBoxMNPRDoctor
            // 
            this.textBoxMNPRDoctor.Location = new System.Drawing.Point(108, 137);
            this.textBoxMNPRDoctor.Name = "textBoxMNPRDoctor";
            this.textBoxMNPRDoctor.ReadOnly = true;
            this.textBoxMNPRDoctor.Size = new System.Drawing.Size(191, 20);
            this.textBoxMNPRDoctor.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Doctor:";
            // 
            // buttonMNPRClear
            // 
            this.buttonMNPRClear.Location = new System.Drawing.Point(203, 212);
            this.buttonMNPRClear.Name = "buttonMNPRClear";
            this.buttonMNPRClear.Size = new System.Drawing.Size(75, 23);
            this.buttonMNPRClear.TabIndex = 5;
            this.buttonMNPRClear.Text = "Clear";
            this.buttonMNPRClear.UseVisualStyleBackColor = true;
            this.buttonMNPRClear.Click += new System.EventHandler(this.buttonMNPRClear_Click);
            // 
            // buttonMNPRRemove
            // 
            this.buttonMNPRRemove.Location = new System.Drawing.Point(37, 212);
            this.buttonMNPRRemove.Name = "buttonMNPRRemove";
            this.buttonMNPRRemove.Size = new System.Drawing.Size(106, 23);
            this.buttonMNPRRemove.TabIndex = 13;
            this.buttonMNPRRemove.Text = "Remove pacient";
            this.buttonMNPRRemove.UseVisualStyleBackColor = true;
            this.buttonMNPRRemove.Click += new System.EventHandler(this.buttonMNPRRemove_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Address:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "ID:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Name:";
            // 
            // textBoxMNPRAdd
            // 
            this.textBoxMNPRAdd.Location = new System.Drawing.Point(108, 95);
            this.textBoxMNPRAdd.Name = "textBoxMNPRAdd";
            this.textBoxMNPRAdd.ReadOnly = true;
            this.textBoxMNPRAdd.Size = new System.Drawing.Size(191, 20);
            this.textBoxMNPRAdd.TabIndex = 2;
            // 
            // textBoxMNPRID
            // 
            this.textBoxMNPRID.Location = new System.Drawing.Point(108, 57);
            this.textBoxMNPRID.Name = "textBoxMNPRID";
            this.textBoxMNPRID.ReadOnly = true;
            this.textBoxMNPRID.Size = new System.Drawing.Size(191, 20);
            this.textBoxMNPRID.TabIndex = 1;
            // 
            // textBoxMNPRName
            // 
            this.textBoxMNPRName.Location = new System.Drawing.Point(108, 20);
            this.textBoxMNPRName.Name = "textBoxMNPRName";
            this.textBoxMNPRName.ReadOnly = true;
            this.textBoxMNPRName.Size = new System.Drawing.Size(191, 20);
            this.textBoxMNPRName.TabIndex = 0;
            // 
            // listViewMNPacRemove
            // 
            this.listViewMNPacRemove.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listViewMNPacRemove.Location = new System.Drawing.Point(12, 5);
            this.listViewMNPacRemove.Name = "listViewMNPacRemove";
            this.listViewMNPacRemove.Size = new System.Drawing.Size(272, 305);
            this.listViewMNPacRemove.TabIndex = 6;
            this.listViewMNPacRemove.UseCompatibleStateImageBehavior = false;
            this.listViewMNPacRemove.View = System.Windows.Forms.View.Details;
            this.listViewMNPacRemove.SelectedIndexChanged += new System.EventHandler(this.listViewMNPacRemove_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            this.columnHeader6.Width = 207;
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
            // pictureBoxDischarged
            // 
            this.pictureBoxDischarged.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDischarged.Location = new System.Drawing.Point(108, 177);
            this.pictureBoxDischarged.Name = "pictureBoxDischarged";
            this.pictureBoxDischarged.Size = new System.Drawing.Size(14, 14);
            this.pictureBoxDischarged.TabIndex = 17;
            this.pictureBoxDischarged.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::HMIS.PresentationLayer.Properties.Resources.nurse1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(779, 145);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormNurseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 537);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormNurseWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNurseWindow";
            this.Load += new System.EventHandler(this.FormNurseWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageNPacInfo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageNPacAdd.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageNPacRemove.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDischarged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLogout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageNPacInfo;
        private System.Windows.Forms.TabPage tabPageNPacAdd;
        private System.Windows.Forms.ListView listViewNursePat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAddPacient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxMNAdd;
        private System.Windows.Forms.TextBox textBoxMNID;
        private System.Windows.Forms.TextBox textBoxMNName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxNDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNViewDiagnosis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonNClear;
        private System.Windows.Forms.TextBox textBoxNPatAdd;
        private System.Windows.Forms.TextBox textBoxNPatID;
        private System.Windows.Forms.TextBox textBoxNPatName;
        private System.Windows.Forms.ComboBox comboBoxMNDoctor;
        private System.Windows.Forms.Button buttonMNGenerateID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBoxMNDoctorAdd;
        private System.Windows.Forms.TextBox textBoxMNDoctorID;
        private System.Windows.Forms.TextBox textBoxMNDoctorName;
        private System.Windows.Forms.ComboBox comboBoxMNDoctorPat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPageNPacRemove;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxMNPRDoctor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonMNPRClear;
        private System.Windows.Forms.Button buttonMNPRRemove;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxMNPRAdd;
        private System.Windows.Forms.TextBox textBoxMNPRID;
        private System.Windows.Forms.TextBox textBoxMNPRName;
        private System.Windows.Forms.ListView listViewMNPacRemove;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBoxDischarged;
    }
}