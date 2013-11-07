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
    public partial class FormAdminWindow : Form
    {
        private IMainController _controller;
        private DoctorRepository _doctorRepository;
        private NurseRepository _nurseRepository;
        
        public FormAdminWindow(IMainController inController, DoctorRepository inDoctorRepository, NurseRepository inNurseRepository)
        {
            _controller = inController;
            _doctorRepository = inDoctorRepository;
            _nurseRepository = inNurseRepository;

            InitializeComponent();
        }

        private void FormAdminWindow_Load(object sender, EventArgs e)
        {
            UpdateDoctorList();
            UpdateNurseList();

            buttonAdminDRemove.Enabled = false;
            buttonAdminNRemove.Enabled = false;
        }

        /************************************************************
         * Doctor
         ***********************************************************/

        private void buttonAdminDAdd_Click(object sender, EventArgs e)
        {
            int id = 0;
            int pass = 0;

            try
            {
                id = Convert.ToInt32(textBoxAdminDID.Text);
            }
            catch (Exception)
            {
            }

            try
            {
                pass = Convert.ToInt32(textBoxAdminDPassword.Text);
            }
            catch (Exception)
            {
            }

            try
            {
                _controller.AddDoctor(id, textBoxAdminDName.Text, textBoxAdminDAddress.Text, textBoxAdminDUsername.Text, pass);
                UpdateDoctorList();
                textBoxAdminDName.Text = "";
                textBoxAdminDID.Text = "";
                textBoxAdminDUsername.Text = "";
                textBoxAdminDAddress.Text = "";
                textBoxAdminDPassword.Text = "";
            }
            catch (DoctorIDAlreadyExsistsException)
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
            catch (InvalidUsernameException)
            {
                MessageBox.Show("Wrong username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidPasswordException)
            {
                MessageBox.Show("Wrong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdminDRemove_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.RemoveDoctor(Convert.ToInt32(textBoxAdminDID.Text), textBoxAdminDName.Text);
                UpdateDoctorList();

                buttonGenerateID.Enabled = true;
                buttonAdminDRemove.Enabled = false;
                button1.Enabled = true;
                buttonAdminDAdd.Enabled = true;

                textBoxAdminDName.Text = "";
                textBoxAdminDID.Text = "";
                textBoxAdminDUsername.Text = "";
                textBoxAdminDAddress.Text = "";
                textBoxAdminDUsername.Text = "";
                textBoxAdminDPassword.Text = "";
            }
            catch (DoctorIDDoesntExsistsException)
            {
                MessageBox.Show("Doctor ID doesn't exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DoctorNameDoesntExsistsException)
            {
                MessageBox.Show("Doctor with that name doesn't exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDoctorList()
        {
            listViewAdminD.Items.Clear();

            for (int i = 0; i < _doctorRepository.Count(); i++)
            {
                Doctor doctor = _doctorRepository.GetDoctorFromList(i);

                ListViewItem listViewItem = new ListViewItem(doctor.ID.ToString());
                listViewItem.SubItems.Add(doctor.Name);

                listViewAdminD.Items.Add(listViewItem);
            }
        }

        public void UpdateView()
        {
        }

        private void listViewAdminD_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedDoctor = this.listViewAdminD.SelectedItems;
            
            foreach (ListViewItem item in selectedDoctor)
            {
                int id = Convert.ToInt32(item.SubItems[0].Text);
                string name = item.SubItems[1].Text;

                Doctor doctor = _doctorRepository.GetDoctorByID(id);

                if (doctor != null)
                {
                    buttonGenerateID.Enabled = false;
                    button1.Enabled = false;
                    buttonAdminDAdd.Enabled = false;

                    buttonAdminDRemove.Enabled = true;
                    textBoxAdminDName.Text = doctor.Name;
                    textBoxAdminDID.Text = doctor.ID.ToString();
                    textBoxAdminDAddress.Text = doctor.Address;
                    textBoxAdminDUsername.Text = doctor.Username;
                    textBoxAdminDPassword.Text = doctor.Password.ToString();
                }
            }
        }

        private void buttonAdminDClear_Click(object sender, EventArgs e)
        {
            textBoxAdminDName.Text = "";
            textBoxAdminDID.Text = "";
            textBoxAdminDAddress.Text = "";
            textBoxAdminDUsername.Text = "";
            textBoxAdminDPassword.Text = "";

            buttonGenerateID.Enabled = true;
            button1.Enabled = true;
            buttonAdminDAdd.Enabled = true;
        }

        private void buttonGenerateID_Click(object sender, EventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            int numIterations = 0;
            numIterations = rand.Next(1, 100000);

            textBoxAdminDID.Text = numIterations.ToString();
        }


        /************************************************************/
        // Nurse
        /***********************************************************/

        private void buttonAdminNAdd_Click(object sender, EventArgs e)
        {
            bool mainNurse = false;
            int id = 0;
            int pass = 0;

            if (checkBoxAdminNMain.Checked)
                mainNurse = true;
            else
                mainNurse = false;

            try
            {
                id = Convert.ToInt32(textBoxAdminNID.Text);
            }
            catch (Exception)
            {
            }

            try
            {
                pass = Convert.ToInt32(textBoxAdminNPass.Text);
            }
            catch (Exception)
            {
            }

            try
            {
                _controller.AddNurse(id, textBoxAdminNName.Text, textBoxAdminNAddress.Text, textBoxAdminNUsername.Text, pass, mainNurse);
                UpdateNurseList();

                textBoxAdminNName.Text = "";
                textBoxAdminNID.Text = "";
                textBoxAdminNUsername.Text = "";
                textBoxAdminNPass.Text = "";
                textBoxAdminNAddress.Text = "";
            }
            catch (NurseIDAlreadyExsistsException)
            {
                MessageBox.Show("Nurse ID already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (InvalidUsernameException)
            {
                MessageBox.Show("Wrong username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidPasswordException)
            {
                MessageBox.Show("Wrong password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdminNRemove_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.RemoveNurse(Convert.ToInt32(textBoxAdminNID.Text), textBoxAdminNName.Text);
                UpdateNurseList();

                buttonAdminNGenerateID.Enabled = true;

                buttonAdminNRemove.Enabled = false;
                buttonAdminNAdd.Enabled = true;
                buttonAdminNGenerateID.Enabled = true;
                button2.Enabled = true;

                textBoxAdminNName.Text = "";
                textBoxAdminNID.Text = "";
                textBoxAdminNUsername.Text = "";
                textBoxAdminNPass.Text = "";
                textBoxAdminNAddress.Text = "";
            }
            catch (DoctorIDDoesntExsistsException)
            {
                MessageBox.Show("Nurse ID doesn't exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DoctorNameDoesntExsistsException)
            {
                MessageBox.Show("Nurse with that name doesn't exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewAdminN_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedNurse = this.listViewAdminN.SelectedItems;

            buttonAdminNGenerateID.Enabled = false;

            foreach (ListViewItem item in selectedNurse)
            {
                int id = Convert.ToInt32(item.SubItems[0].Text);
                string name = item.SubItems[1].Text;

                Nurse nurse = _nurseRepository.GetNurseByID(id);

                if (nurse != null)
                {
                    buttonAdminNRemove.Enabled = true;
                    buttonAdminNAdd.Enabled = false;
                    buttonAdminNGenerateID.Enabled = false;
                    button2.Enabled = false;

                    textBoxAdminNName.Text = nurse.Name;
                    textBoxAdminNID.Text = nurse.ID.ToString();
                    textBoxAdminNAddress.Text = nurse.Address;
                    textBoxAdminNUsername.Text = nurse.Username;
                    textBoxAdminNPass.Text = nurse.Password.ToString();
                    checkBoxAdminNMain.Checked = nurse.MainNurse;
                }
            }
        }

        private void buttonAdminNGenerateID_Click(object sender, EventArgs e)
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            int numIterations = 0;
            numIterations = rand.Next(1, 100000);

            textBoxAdminNID.Text = numIterations.ToString();
        }

        private void buttonAdminNClear_Click(object sender, EventArgs e)
        {
            textBoxAdminNName.Text = "";
            textBoxAdminNID.Text = "";
            textBoxAdminNAddress.Text = "";
            textBoxAdminNUsername.Text = "";
            textBoxAdminNPass.Text = "";
            checkBoxAdminNMain.Checked = false;

            buttonAdminNGenerateID.Enabled = true;
            buttonAdminNAdd.Enabled = true;
            buttonAdminNGenerateID.Enabled = true;
            button2.Enabled = true;
        }

        private void UpdateNurseList()
        {
            listViewAdminN.Items.Clear();

            for (int i = 0; i < _nurseRepository.Count(); i++)
            {
                Nurse nurse = _nurseRepository.GetNurseFromList(i);

                ListViewItem listViewItem = new ListViewItem(nurse.ID.ToString());
                listViewItem.SubItems.Add(nurse.Name);

                listViewAdminN.Items.Add(listViewItem);
            }
        }

        private void toolStripMenuItemLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] string_array = textBoxAdminDName.Text.Split(' ');
            string all = "";
            bool exsists = false;
            int n = 0;

            Random random = new Random();

            foreach (string s in string_array)
            {
                string first = String.IsNullOrEmpty(s) ? "" : s;
                all += first;
            }

            for (int i = 0; i < _doctorRepository.Count(); i++)
            {
                Doctor doctor = _doctorRepository.GetDoctorFromList(i);
                if (doctor.Username == all.ToLower())
                {
                    n++;
                    exsists = true;
                }
                else if (exsists)
                    exsists = false;

            }

            if (!exsists)
            {
                textBoxAdminDUsername.Text = all.ToLower();
            }
            else
            {
                all += n;
                textBoxAdminDUsername.Text = all.ToLower();
            }

            textBoxAdminDPassword.Text = random.Next(1, 10000).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] string_array = textBoxAdminNName.Text.Split(' ');
            string all = "";
            bool exsists = false;
            int n = 0;

            Random random = new Random();

            foreach (string s in string_array)
            {
                string first = String.IsNullOrEmpty(s) ? "" : s;
                all += first;
            }

            for (int i = 0; i < _nurseRepository.Count(); i++)
            {
                Nurse nurse = _nurseRepository.GetNurseFromList(i);
                if (nurse.Username == all.ToLower())
                {
                    n++;
                    exsists = true;
                }
                else if (exsists)
                    exsists = false;

            }

            if (!exsists)
            {
                textBoxAdminNUsername.Text = all.ToLower();
            }
            else
            {
                all += n;
                textBoxAdminNUsername.Text = all.ToLower();
            }

            textBoxAdminNPass.Text = random.Next(1, 10000).ToString();
        }
    }
}
