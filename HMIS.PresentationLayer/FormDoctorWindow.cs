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
    public partial class FormDoctorWindow : Form, IObserver
    {
        private IMainController _controller;
        private PatientRepository _pacientRepository;
        private Doctor _doctor;
        private Patient _patient;

        public FormDoctorWindow(IMainController inController, PatientRepository inPacientRepository, Doctor doctor)
        {
            _controller = inController;
            _pacientRepository = inPacientRepository;
            _doctor = doctor;

            InitializeComponent();
        }

        private void UpdatePacientsList()
        {
            listViewDoctorPat.Items.Clear();

            foreach (Patient pat in _doctor.PacientList)
            {
                if (pat.DoctorName == _doctor.Name)
                {
                    ListViewItem listViewItem = new ListViewItem(pat.ID.ToString());
                    listViewItem.SubItems.Add(pat.Name);

                    listViewDoctorPat.Items.Add(listViewItem);
                }
            }
        }

        private void FormDoctorWindow_Load(object sender, EventArgs e)
        {
            buttonDViewDiagnosis.Enabled = false;
            buttonDAddDiag.Enabled = false;
            UpdatePacientsList();

            Doctor doctor = new Doctor();
        }

        private void listViewDoctorPat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedPacient = this.listViewDoctorPat.SelectedItems;

            foreach (ListViewItem item in selectedPacient)
            {
                int id = Convert.ToInt32(item.SubItems[0].Text);
                string name = item.SubItems[1].Text;

                Patient pacient = _pacientRepository.GetPacientByID(id);

                if (pacient != null)
                {
                    _patient = pacient;
                    buttonDViewDiagnosis.Enabled = true;
                    buttonDAddDiag.Enabled = true;
                    textBoxDPatName.Text = pacient.Name;
                    textBoxDPatID.Text = pacient.ID.ToString();
                    textBoxDPatAdd.Text = pacient.Address;

                    if (pacient.Delete)
                    {
                        pictureBoxDDischarged.BackColor = Color.Green;
                        checkBox1.Checked = true;
                    }
                    else
                    {
                        pictureBoxDDischarged.BackColor = Color.Red;
                        checkBox1.Checked = false;
                    }
                }
            }
        }

        private void buttonNClear_Click(object sender, EventArgs e)
        {
            textBoxDPatName.Text = "";
            textBoxDPatID.Text = "";
            textBoxDPatAdd.Text = "";

            pictureBoxDDischarged.BackColor = Color.Transparent;
        }

        private void toolStripMenuItemLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Patient patient = _pacientRepository.GetPacientByID(Convert.ToInt32(textBoxDPatID.Text));

            if (patient != null)
            {
                if (checkBox1.Checked)
                {
                    patient.Delete = true;
                    textBoxDPatName.Text = patient.Name;
                    textBoxDPatID.Text = patient.ID.ToString();
                    textBoxDPatAdd.Text = patient.Address;
                    if (patient.Delete)
                    {
                        pictureBoxDDischarged.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBoxDDischarged.BackColor = Color.Red;
                    }
                }
                else
                {
                    patient.Delete = false;
                    textBoxDPatName.Text = patient.Name;
                    textBoxDPatID.Text = patient.ID.ToString();
                    textBoxDPatAdd.Text = patient.Address;
                    if (patient.Delete)
                    {
                        pictureBoxDDischarged.BackColor = Color.Green;
                    }
                    else
                    {
                        pictureBoxDDischarged.BackColor = Color.Red;
                    }
                }
            }
        }

        private void buttonDViewDiagnosis_Click(object sender, EventArgs e)
        {
            _controller.ShowDiagnosisForm(_patient.Name, _patient.ID, true, false);
        }

        private void buttonDAddDiag_Click(object sender, EventArgs e)
        {
            _controller.ShowDiagnosisForm(_patient.Name, _patient.ID, false, true);
        }

        public void UpdateView()
        {
            UpdatePacientsList();
        }
    }
}
