using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HMIS.BaseInterfaces;
using HMIS.DomainModel;

namespace HMIS.PresentationLayer
{
    public partial class FormDiagnosis : Form
    {
        private IMainController _controller;
        private PatientRepository _patientRepository;
        private Patient _patient;
        private bool _doctorLogged;
        private bool _nurseLogged;

        public FormDiagnosis(IMainController inController, PatientRepository inPatientRepository, string name, int id, bool nurseLogged, bool doctorLogged)
        {
            _controller = inController;
            _patientRepository = inPatientRepository;
            _doctorLogged = doctorLogged;
            _nurseLogged = nurseLogged;

            Patient patient = _patientRepository.GetPacientByID(id);
            if (patient != null)
                _patient = patient;

            InitializeComponent();
        }

        private void FormDiagnosis_Load(object sender, EventArgs e)
        {
            if (_nurseLogged)
            {
                textBoxPDiagnosis.Enabled = false;
                textBoxPDoctorDiag.Enabled = false;
            }

            labelPatientName.Text = _patient.Name;

            textBoxPDiagnosis.Text = _patient.Diagnosis;
            textBoxPTemp.Text = _patient.TemperatureValue;
            textBoxPPulse.Text = _patient.PulseValue;
            textBoxPSaturation.Text = _patient.SaturationValue;
            textBoxPBloodPreas.Text = _patient.BloodPreasureValue;

            checkBoxPTemp.Checked = _patient.Temperature;
            checkBoxPPulse.Checked = _patient.Pulse;
            checkBoxPBloodPres.Checked = _patient.BloodPreasure;
            checkBoxPSaturation.Checked = _patient.Saturation;
            checkBoxPMorningT.Checked = _patient.MorningTherapy;
            checkBoxPDayT.Checked = _patient.DayTherapy;
            checkBoxPEveningT.Checked = _patient.EveningTherapy;

            textBoxPDoctorDiag.Text = _patient.DoctorDiagnosis;
        }
        private void checkBoxPTemp_CheckedChanged(object sender, EventArgs e)
        {
            _patient.Temperature = checkBoxPTemp.Checked;
        }

        private void checkBoxPPulse_CheckedChanged(object sender, EventArgs e)
        {
            _patient.Pulse = checkBoxPPulse.Checked;
        }

        private void checkBoxPBloodPres_CheckedChanged(object sender, EventArgs e)
        {
            _patient.BloodPreasure = checkBoxPBloodPres.Checked;
        }

        private void checkBoxPSaturation_CheckedChanged(object sender, EventArgs e)
        {
            _patient.Saturation = checkBoxPSaturation.Checked;
        }

        private void checkBoxPMorningT_CheckedChanged(object sender, EventArgs e)
        {
            _patient.MorningTherapy = checkBoxPMorningT.Checked;
        }

        private void checkBoxPDayT_CheckedChanged(object sender, EventArgs e)
        {
            _patient.DayTherapy = checkBoxPDayT.Checked;
        }

        private void checkBoxPEveningT_CheckedChanged(object sender, EventArgs e)
        {
            _patient.EveningTherapy = checkBoxPEveningT.Checked;
        }

        private void buttonDiagnosisClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDiagnosisSave_Click(object sender, EventArgs e)
        {
            if (_doctorLogged)
            {
                _patient.Diagnosis = textBoxPDiagnosis.Text;
                _patient.DoctorDiagnosis = textBoxPDoctorDiag.Text;
            }

            _patient.TemperatureValue = textBoxPTemp.Text;
            _patient.BloodPreasureValue = textBoxPBloodPreas.Text;
            _patient.PulseValue = textBoxPPulse.Text;
            _patient.SaturationValue = textBoxPSaturation.Text;

            this.Close();
        }
    }
}
