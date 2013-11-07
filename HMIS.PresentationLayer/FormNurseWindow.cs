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
    public partial class FormNurseWindow : Form, IObserver
    {
        private IMainController _controller;
        private DoctorRepository _doctorRepository;
        private PatientRepository _pacientRepository;
        private Nurse _nurse;
        private Doctor _doctor;
        private Patient _patient;

        public FormNurseWindow(IMainController inController, DoctorRepository inDoctorRepository, PatientRepository inPacientRepository, Nurse nurse)
        {
            _controller = inController;
            _doctorRepository = inDoctorRepository;
            _pacientRepository = inPacientRepository;              
            _nurse = nurse;

            InitializeComponent();
        }

        private void FormNurseWindow_Load(object sender, EventArgs e)
        {
            if (!_nurse.MainNurse)
            {
                tabControl1.TabPages.Remove(tabPageNPacAdd);
                tabControl1.TabPages.Remove(tabPageNPacRemove);
            }

            UpdatePacientsList();

            Doctor doctor = new Doctor();

            for (int i = 0; i < _doctorRepository.Count(); i++)
            {
                doctor = _doctorRepository.GetDoctorFromList(i);
                comboBoxMNDoctor.Items.Add(doctor.Name);
            }

            buttonNViewDiagnosis.Enabled = false;
            buttonMNPRRemove.Enabled = false;
        }

        private void tabPageNPacInfo_Click(object sender, EventArgs e)
        {
        }

        private void buttonAddPacient_Click(object sender, EventArgs e)
        {
            int id = 0;
            string doctorName = "";

            try
            {
                id = Convert.ToInt32(textBoxMNID.Text);
            }
            catch (Exception)
            {
            }

            if (!String.IsNullOrEmpty(textBoxMNDoctorName.Text))
            {
                try
                {
                    string name = textBoxMNName.Text;
                    string add = textBoxMNAdd.Text;

                    _controller.AddPacient(id, textBoxMNName.Text, textBoxMNAdd.Text, doctorName, _doctor.ID);
                    _doctor.PacientList.Add(new Patient(Convert.ToInt32(textBoxMNID.Text), textBoxMNName.Text, textBoxMNAdd.Text, _doctor.Name, _doctor.ID));

                    UpdatePacientsList();

                    textBoxMNName.Text = "";
                    textBoxMNID.Text = "";
                    textBoxMNAdd.Text = "";
                    comboBoxMNDoctor.Text = "";

                    textBoxMNDoctorName.Text = "";
                    textBoxMNDoctorID.Text = "";
                    textBoxMNDoctorAdd.Text = "";
                    comboBoxMNDoctorPat.Text = "";
                }
                catch (PatientDAlreadyExsistsException)
                {
                    MessageBox.Show("Doctor ID already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidNameException)
                {
                    MessageBox.Show("Wrong name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidAddressException)
                {
                    MessageBox.Show("Wrong address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidIDException)
                {
                    MessageBox.Show("Wrong ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Wrong doctor name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBoxMNDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();

            for (int i = 0; i < _doctorRepository.Count(); i++)
            {
                doctor = _doctorRepository.GetDoctorFromList(i);

                if (doctor.Name == comboBoxMNDoctor.Text)
                {
                    comboBoxMNDoctorPat.Items.Clear();

                    _doctor = doctor;
                    textBoxMNDoctorName.Text = doctor.Name;
                    textBoxMNDoctorID.Text = doctor.ID.ToString();
                    textBoxMNDoctorAdd.Text = doctor.Address;
                    foreach (Patient pac in doctor.PacientList)
                    {
                        comboBoxMNDoctorPat.Items.Add(pac.Name);
                    }
                }
            }
        }

        private void UpdatePacientsList()
        {
            listViewNursePat.Items.Clear();
            listViewMNPacRemove.Items.Clear();

            for (int i = 0; i < _pacientRepository.Count(); i++)
            {
                Patient pacient = _pacientRepository.GetPacientFromList(i);

                ListViewItem listViewItem = new ListViewItem(pacient.ID.ToString());
                listViewItem.SubItems.Add(pacient.Name);

                listViewNursePat.Items.Add(listViewItem);
            }

            for (int i = 0; i < _pacientRepository.Count(); i++)
            {
                Patient pacient = _pacientRepository.GetPacientFromList(i);

                ListViewItem listViewItem = new ListViewItem(pacient.ID.ToString());
                listViewItem.SubItems.Add(pacient.Name);

                listViewMNPacRemove.Items.Add(listViewItem);
            }
        }

        private void buttonMNGenerateID_Click(object sender, EventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            int numIterations = 0;
            numIterations = rand.Next(1, 100000);

            textBoxMNID.Text = numIterations.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxMNName.Text = "";
            textBoxMNID.Text = "";
            textBoxMNAdd.Text = "";
            comboBoxMNDoctor.Text = "";

            textBoxMNDoctorName.Text = "";
            textBoxMNDoctorID.Text = "";
            textBoxMNDoctorAdd.Text = "";
            comboBoxMNDoctorPat.Text = "";
        }

        private void listViewNursePat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedPacient = this.listViewNursePat.SelectedItems;

            foreach (ListViewItem item in selectedPacient)
            {
                int id = Convert.ToInt32(item.SubItems[0].Text);
                string name = item.SubItems[1].Text;

                Patient pacient = _pacientRepository.GetPacientByID(id);

                if (pacient != null)
                {
                    buttonNViewDiagnosis.Enabled = true;
                    _patient = pacient;
                    textBoxNPatName.Text = pacient.Name;
                    textBoxNPatID.Text = pacient.ID.ToString();
                    textBoxNPatAdd.Text = pacient.Address;
                    textBoxNDoc.Text = pacient.DoctorName;
                }
            }
        }

        private void buttonNClear_Click(object sender, EventArgs e)
        {
            textBoxNPatName.Text = "";
            textBoxNPatID.Text = "";
            textBoxNPatAdd.Text = "";
            textBoxNDoc.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxMNDoctorName.Text = "";
            textBoxMNDoctorID.Text = "";
            textBoxMNDoctorAdd.Text = "";
            comboBoxMNDoctorPat.Text = "";

            comboBoxMNDoctor.Text = "";
        }

        private void toolStripMenuItemLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewMNPacRemove_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedPacient = this.listViewMNPacRemove.SelectedItems;

            foreach (ListViewItem item in selectedPacient)
            {
                int id = Convert.ToInt32(item.SubItems[0].Text);
                string name = item.SubItems[1].Text;

                Patient pacient = _pacientRepository.GetPacientByID(id);

                if (pacient != null)
                {
                    textBoxMNPRName.Text = pacient.Name;
                    textBoxMNPRID.Text = pacient.ID.ToString();
                    textBoxMNPRAdd.Text = pacient.Address;
                    textBoxMNPRDoctor.Text = pacient.DoctorName;
                    if (pacient.Delete)
                    {
                        pictureBoxDischarged.BackColor = Color.Green;
                        buttonMNPRRemove.Enabled = true;
                    }
                    else
                    {
                        pictureBoxDischarged.BackColor = Color.Red;
                        buttonMNPRRemove.Enabled = false;
                    }
                }
            }
        }

        private void buttonMNPRClear_Click(object sender, EventArgs e)
        {
            textBoxMNPRName.Text = "";
            textBoxMNPRID.Text = "";
            textBoxMNPRAdd.Text = "";
            textBoxMNPRDoctor.Text = "";
            pictureBoxDischarged.BackColor = Color.Transparent;
        }

        private void buttonMNPRRemove_Click(object sender, EventArgs e)
        {
            _controller.RemovePacient(Convert.ToInt32(textBoxMNPRID.Text), textBoxMNPRName.Text);
            _controller.DeletePacientFromDoctor();
            textBoxMNPRName.Text = "";
            textBoxMNPRID.Text = "";
            textBoxMNPRAdd.Text = "";
            textBoxMNPRDoctor.Text = "";

            buttonMNPRRemove.Enabled = false;
            UpdatePacientsList();
        }

        private void buttonNViewDiagnosis_Click(object sender, EventArgs e)
        {
            _controller.ShowDiagnosisForm(_patient.Name, _patient.ID, true, false);
        }

        public void UpdateView()
        {
            UpdatePacientsList();
        }
    }
}
