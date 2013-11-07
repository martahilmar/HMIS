namespace HMIS.PresentationLayer
{
    partial class FormDiagnosis
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
            this.buttonDiagnosisClose = new System.Windows.Forms.Button();
            this.textBoxPDiagnosis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxPTemp = new System.Windows.Forms.CheckBox();
            this.checkBoxPPulse = new System.Windows.Forms.CheckBox();
            this.checkBoxPBloodPres = new System.Windows.Forms.CheckBox();
            this.checkBoxPSaturation = new System.Windows.Forms.CheckBox();
            this.checkBoxPMorningT = new System.Windows.Forms.CheckBox();
            this.textBoxPTemp = new System.Windows.Forms.TextBox();
            this.textBoxPPulse = new System.Windows.Forms.TextBox();
            this.textBoxPBloodPreas = new System.Windows.Forms.TextBox();
            this.textBoxPSaturation = new System.Windows.Forms.TextBox();
            this.checkBoxPDayT = new System.Windows.Forms.CheckBox();
            this.checkBoxPEveningT = new System.Windows.Forms.CheckBox();
            this.textBoxPDoctorDiag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.buttonDiagnosisSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDiagnosisClose
            // 
            this.buttonDiagnosisClose.Location = new System.Drawing.Point(285, 436);
            this.buttonDiagnosisClose.Name = "buttonDiagnosisClose";
            this.buttonDiagnosisClose.Size = new System.Drawing.Size(75, 23);
            this.buttonDiagnosisClose.TabIndex = 0;
            this.buttonDiagnosisClose.Text = "Close";
            this.buttonDiagnosisClose.UseVisualStyleBackColor = true;
            this.buttonDiagnosisClose.Click += new System.EventHandler(this.buttonDiagnosisClose_Click);
            // 
            // textBoxPDiagnosis
            // 
            this.textBoxPDiagnosis.Location = new System.Drawing.Point(117, 41);
            this.textBoxPDiagnosis.Name = "textBoxPDiagnosis";
            this.textBoxPDiagnosis.Size = new System.Drawing.Size(243, 20);
            this.textBoxPDiagnosis.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diagnosis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nurse obligations:";
            // 
            // checkBoxPTemp
            // 
            this.checkBoxPTemp.AutoSize = true;
            this.checkBoxPTemp.Location = new System.Drawing.Point(35, 104);
            this.checkBoxPTemp.Name = "checkBoxPTemp";
            this.checkBoxPTemp.Size = new System.Drawing.Size(86, 17);
            this.checkBoxPTemp.TabIndex = 9;
            this.checkBoxPTemp.Text = "Temperature";
            this.checkBoxPTemp.UseVisualStyleBackColor = true;
            this.checkBoxPTemp.CheckedChanged += new System.EventHandler(this.checkBoxPTemp_CheckedChanged);
            // 
            // checkBoxPPulse
            // 
            this.checkBoxPPulse.AutoSize = true;
            this.checkBoxPPulse.Location = new System.Drawing.Point(35, 132);
            this.checkBoxPPulse.Name = "checkBoxPPulse";
            this.checkBoxPPulse.Size = new System.Drawing.Size(52, 17);
            this.checkBoxPPulse.TabIndex = 10;
            this.checkBoxPPulse.Text = "Pulse";
            this.checkBoxPPulse.UseVisualStyleBackColor = true;
            this.checkBoxPPulse.CheckedChanged += new System.EventHandler(this.checkBoxPPulse_CheckedChanged);
            // 
            // checkBoxPBloodPres
            // 
            this.checkBoxPBloodPres.AutoSize = true;
            this.checkBoxPBloodPres.Location = new System.Drawing.Point(35, 160);
            this.checkBoxPBloodPres.Name = "checkBoxPBloodPres";
            this.checkBoxPBloodPres.Size = new System.Drawing.Size(97, 17);
            this.checkBoxPBloodPres.TabIndex = 11;
            this.checkBoxPBloodPres.Text = "Blood preasure";
            this.checkBoxPBloodPres.UseVisualStyleBackColor = true;
            this.checkBoxPBloodPres.CheckedChanged += new System.EventHandler(this.checkBoxPBloodPres_CheckedChanged);
            // 
            // checkBoxPSaturation
            // 
            this.checkBoxPSaturation.AutoSize = true;
            this.checkBoxPSaturation.Location = new System.Drawing.Point(35, 191);
            this.checkBoxPSaturation.Name = "checkBoxPSaturation";
            this.checkBoxPSaturation.Size = new System.Drawing.Size(89, 17);
            this.checkBoxPSaturation.TabIndex = 12;
            this.checkBoxPSaturation.Text = "O2 saturation";
            this.checkBoxPSaturation.UseVisualStyleBackColor = true;
            this.checkBoxPSaturation.CheckedChanged += new System.EventHandler(this.checkBoxPSaturation_CheckedChanged);
            // 
            // checkBoxPMorningT
            // 
            this.checkBoxPMorningT.AutoSize = true;
            this.checkBoxPMorningT.Location = new System.Drawing.Point(35, 222);
            this.checkBoxPMorningT.Name = "checkBoxPMorningT";
            this.checkBoxPMorningT.Size = new System.Drawing.Size(102, 17);
            this.checkBoxPMorningT.TabIndex = 13;
            this.checkBoxPMorningT.Text = "Morning therapy";
            this.checkBoxPMorningT.UseVisualStyleBackColor = true;
            this.checkBoxPMorningT.CheckedChanged += new System.EventHandler(this.checkBoxPMorningT_CheckedChanged);
            // 
            // textBoxPTemp
            // 
            this.textBoxPTemp.Location = new System.Drawing.Point(155, 102);
            this.textBoxPTemp.Name = "textBoxPTemp";
            this.textBoxPTemp.Size = new System.Drawing.Size(60, 20);
            this.textBoxPTemp.TabIndex = 14;
            // 
            // textBoxPPulse
            // 
            this.textBoxPPulse.Location = new System.Drawing.Point(155, 130);
            this.textBoxPPulse.Name = "textBoxPPulse";
            this.textBoxPPulse.Size = new System.Drawing.Size(60, 20);
            this.textBoxPPulse.TabIndex = 15;
            // 
            // textBoxPBloodPreas
            // 
            this.textBoxPBloodPreas.Location = new System.Drawing.Point(155, 157);
            this.textBoxPBloodPreas.Name = "textBoxPBloodPreas";
            this.textBoxPBloodPreas.Size = new System.Drawing.Size(60, 20);
            this.textBoxPBloodPreas.TabIndex = 16;
            // 
            // textBoxPSaturation
            // 
            this.textBoxPSaturation.Location = new System.Drawing.Point(155, 189);
            this.textBoxPSaturation.Name = "textBoxPSaturation";
            this.textBoxPSaturation.Size = new System.Drawing.Size(60, 20);
            this.textBoxPSaturation.TabIndex = 17;
            // 
            // checkBoxPDayT
            // 
            this.checkBoxPDayT.AutoSize = true;
            this.checkBoxPDayT.Location = new System.Drawing.Point(35, 251);
            this.checkBoxPDayT.Name = "checkBoxPDayT";
            this.checkBoxPDayT.Size = new System.Drawing.Size(83, 17);
            this.checkBoxPDayT.TabIndex = 18;
            this.checkBoxPDayT.Text = "Day therapy";
            this.checkBoxPDayT.UseVisualStyleBackColor = true;
            this.checkBoxPDayT.CheckedChanged += new System.EventHandler(this.checkBoxPDayT_CheckedChanged);
            // 
            // checkBoxPEveningT
            // 
            this.checkBoxPEveningT.AutoSize = true;
            this.checkBoxPEveningT.Location = new System.Drawing.Point(35, 282);
            this.checkBoxPEveningT.Name = "checkBoxPEveningT";
            this.checkBoxPEveningT.Size = new System.Drawing.Size(103, 17);
            this.checkBoxPEveningT.TabIndex = 19;
            this.checkBoxPEveningT.Text = "Evening therapy";
            this.checkBoxPEveningT.UseVisualStyleBackColor = true;
            this.checkBoxPEveningT.CheckedChanged += new System.EventHandler(this.checkBoxPEveningT_CheckedChanged);
            // 
            // textBoxPDoctorDiag
            // 
            this.textBoxPDoctorDiag.Location = new System.Drawing.Point(19, 344);
            this.textBoxPDoctorDiag.Multiline = true;
            this.textBoxPDoctorDiag.Name = "textBoxPDoctorDiag";
            this.textBoxPDoctorDiag.Size = new System.Drawing.Size(341, 76);
            this.textBoxPDoctorDiag.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nurse obligations:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Patient name:";
            // 
            // labelPatientName
            // 
            this.labelPatientName.AutoSize = true;
            this.labelPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatientName.Location = new System.Drawing.Point(133, 12);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(0, 15);
            this.labelPatientName.TabIndex = 23;
            // 
            // buttonDiagnosisSave
            // 
            this.buttonDiagnosisSave.Location = new System.Drawing.Point(186, 436);
            this.buttonDiagnosisSave.Name = "buttonDiagnosisSave";
            this.buttonDiagnosisSave.Size = new System.Drawing.Size(75, 23);
            this.buttonDiagnosisSave.TabIndex = 24;
            this.buttonDiagnosisSave.Text = "Save";
            this.buttonDiagnosisSave.UseVisualStyleBackColor = true;
            this.buttonDiagnosisSave.Click += new System.EventHandler(this.buttonDiagnosisSave_Click);
            // 
            // FormDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 471);
            this.Controls.Add(this.buttonDiagnosisSave);
            this.Controls.Add(this.labelPatientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPDoctorDiag);
            this.Controls.Add(this.checkBoxPEveningT);
            this.Controls.Add(this.checkBoxPDayT);
            this.Controls.Add(this.textBoxPSaturation);
            this.Controls.Add(this.textBoxPBloodPreas);
            this.Controls.Add(this.textBoxPPulse);
            this.Controls.Add(this.textBoxPTemp);
            this.Controls.Add(this.checkBoxPMorningT);
            this.Controls.Add(this.checkBoxPSaturation);
            this.Controls.Add(this.checkBoxPBloodPres);
            this.Controls.Add(this.checkBoxPPulse);
            this.Controls.Add(this.checkBoxPTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPDiagnosis);
            this.Controls.Add(this.buttonDiagnosisClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDiagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDiagnosis";
            this.Load += new System.EventHandler(this.FormDiagnosis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDiagnosisClose;
        private System.Windows.Forms.TextBox textBoxPDiagnosis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxPTemp;
        private System.Windows.Forms.CheckBox checkBoxPPulse;
        private System.Windows.Forms.CheckBox checkBoxPBloodPres;
        private System.Windows.Forms.CheckBox checkBoxPSaturation;
        private System.Windows.Forms.CheckBox checkBoxPMorningT;
        private System.Windows.Forms.TextBox textBoxPTemp;
        private System.Windows.Forms.TextBox textBoxPPulse;
        private System.Windows.Forms.TextBox textBoxPBloodPreas;
        private System.Windows.Forms.TextBox textBoxPSaturation;
        private System.Windows.Forms.CheckBox checkBoxPDayT;
        private System.Windows.Forms.CheckBox checkBoxPEveningT;
        private System.Windows.Forms.TextBox textBoxPDoctorDiag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPatientName;
        private System.Windows.Forms.Button buttonDiagnosisSave;
    }
}