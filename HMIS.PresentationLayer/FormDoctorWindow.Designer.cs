namespace HMIS.PresentationLayer
{
    partial class FormDoctorWindow
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBoxDDischarged = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonDAddDiag = new System.Windows.Forms.Button();
            this.buttonNClear = new System.Windows.Forms.Button();
            this.buttonDViewDiagnosis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDPatAdd = new System.Windows.Forms.TextBox();
            this.textBoxDPatID = new System.Windows.Forms.TextBox();
            this.textBoxDPatName = new System.Windows.Forms.TextBox();
            this.listViewDoctorPat = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageNPacInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDDischarged)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
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
            this.tabControl1.Location = new System.Drawing.Point(7, 178);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 341);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPageNPacInfo
            // 
            this.tabPageNPacInfo.Controls.Add(this.panel2);
            this.tabPageNPacInfo.Controls.Add(this.listViewDoctorPat);
            this.tabPageNPacInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageNPacInfo.Name = "tabPageNPacInfo";
            this.tabPageNPacInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNPacInfo.Size = new System.Drawing.Size(771, 315);
            this.tabPageNPacInfo.TabIndex = 0;
            this.tabPageNPacInfo.Text = "Pacient info";
            this.tabPageNPacInfo.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.pictureBoxDDischarged);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.buttonDAddDiag);
            this.panel2.Controls.Add(this.buttonNClear);
            this.panel2.Controls.Add(this.buttonDViewDiagnosis);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxDPatAdd);
            this.panel2.Controls.Add(this.textBoxDPatID);
            this.panel2.Controls.Add(this.textBoxDPatName);
            this.panel2.Location = new System.Drawing.Point(377, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 283);
            this.panel2.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 168);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Discharge";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBoxDDischarged
            // 
            this.pictureBoxDDischarged.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDDischarged.Location = new System.Drawing.Point(108, 132);
            this.pictureBoxDDischarged.Name = "pictureBoxDDischarged";
            this.pictureBoxDDischarged.Size = new System.Drawing.Size(14, 14);
            this.pictureBoxDDischarged.TabIndex = 19;
            this.pictureBoxDDischarged.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 132);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Discharge:";
            // 
            // buttonDAddDiag
            // 
            this.buttonDAddDiag.Location = new System.Drawing.Point(180, 238);
            this.buttonDAddDiag.Name = "buttonDAddDiag";
            this.buttonDAddDiag.Size = new System.Drawing.Size(106, 23);
            this.buttonDAddDiag.TabIndex = 16;
            this.buttonDAddDiag.Text = "Add diagnosis";
            this.buttonDAddDiag.UseVisualStyleBackColor = true;
            this.buttonDAddDiag.Click += new System.EventHandler(this.buttonDAddDiag_Click);
            // 
            // buttonNClear
            // 
            this.buttonNClear.Location = new System.Drawing.Point(224, 190);
            this.buttonNClear.Name = "buttonNClear";
            this.buttonNClear.Size = new System.Drawing.Size(75, 23);
            this.buttonNClear.TabIndex = 5;
            this.buttonNClear.Text = "Clear";
            this.buttonNClear.UseVisualStyleBackColor = true;
            this.buttonNClear.Click += new System.EventHandler(this.buttonNClear_Click);
            // 
            // buttonDViewDiagnosis
            // 
            this.buttonDViewDiagnosis.Location = new System.Drawing.Point(34, 238);
            this.buttonDViewDiagnosis.Name = "buttonDViewDiagnosis";
            this.buttonDViewDiagnosis.Size = new System.Drawing.Size(106, 23);
            this.buttonDViewDiagnosis.TabIndex = 13;
            this.buttonDViewDiagnosis.Text = "View diagnosis";
            this.buttonDViewDiagnosis.UseVisualStyleBackColor = true;
            this.buttonDViewDiagnosis.Click += new System.EventHandler(this.buttonDViewDiagnosis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Name:";
            // 
            // textBoxDPatAdd
            // 
            this.textBoxDPatAdd.Location = new System.Drawing.Point(108, 91);
            this.textBoxDPatAdd.Name = "textBoxDPatAdd";
            this.textBoxDPatAdd.ReadOnly = true;
            this.textBoxDPatAdd.Size = new System.Drawing.Size(191, 20);
            this.textBoxDPatAdd.TabIndex = 2;
            // 
            // textBoxDPatID
            // 
            this.textBoxDPatID.Location = new System.Drawing.Point(108, 53);
            this.textBoxDPatID.Name = "textBoxDPatID";
            this.textBoxDPatID.ReadOnly = true;
            this.textBoxDPatID.Size = new System.Drawing.Size(191, 20);
            this.textBoxDPatID.TabIndex = 1;
            // 
            // textBoxDPatName
            // 
            this.textBoxDPatName.Location = new System.Drawing.Point(108, 16);
            this.textBoxDPatName.Name = "textBoxDPatName";
            this.textBoxDPatName.ReadOnly = true;
            this.textBoxDPatName.Size = new System.Drawing.Size(191, 20);
            this.textBoxDPatName.TabIndex = 0;
            // 
            // listViewDoctorPat
            // 
            this.listViewDoctorPat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewDoctorPat.Location = new System.Drawing.Point(12, 5);
            this.listViewDoctorPat.Name = "listViewDoctorPat";
            this.listViewDoctorPat.Size = new System.Drawing.Size(272, 305);
            this.listViewDoctorPat.TabIndex = 5;
            this.listViewDoctorPat.UseCompatibleStateImageBehavior = false;
            this.listViewDoctorPat.View = System.Windows.Forms.View.Details;
            this.listViewDoctorPat.SelectedIndexChanged += new System.EventHandler(this.listViewDoctorPat_SelectedIndexChanged);
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
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::HMIS.PresentationLayer.Properties.Resources.cover_top;
            this.pictureBox1.Location = new System.Drawing.Point(7, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(779, 145);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormDoctorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 531);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormDoctorWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoctorWindow";
            this.Load += new System.EventHandler(this.FormDoctorWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageNPacInfo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDDischarged)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonNClear;
        private System.Windows.Forms.Button buttonDViewDiagnosis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDPatAdd;
        private System.Windows.Forms.TextBox textBoxDPatID;
        private System.Windows.Forms.TextBox textBoxDPatName;
        private System.Windows.Forms.ListView listViewDoctorPat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonDAddDiag;
        private System.Windows.Forms.PictureBox pictureBoxDDischarged;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}