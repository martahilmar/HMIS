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
    public partial class FormMainWindow : Form
    {
        private IMainController _controller;

        public FormMainWindow(IMainController inController)
        {
            _controller = inController;
            InitializeComponent();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';   
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            try
            {
                if(_controller.CheckAdminLogin(textBoxUsername.Text, textBoxPassword.Text.ToString()))
                {
                    _controller.ShowAdminForm();
                    textBoxUsername.Text = "";
                    textBoxPassword.Text = "";
                }

                else if(_controller.CheckDoctorLogin(textBoxUsername.Text, Convert.ToInt32(textBoxPassword.Text)))
                {
                    _controller.ShowDoctorForm();
                    textBoxUsername.Text = "";
                    textBoxPassword.Text = "";                    
                }

                else if (_controller.CheckNurseLogin(textBoxUsername.Text, Convert.ToInt32(textBoxPassword.Text)))
                {
                    _controller.ShowNurseForm();
                    textBoxUsername.Text = "";
                    textBoxPassword.Text = "";
                }
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

        private void toolStripHelp_Click(object sender, EventArgs e)
        {
            FormHelp helpForm = new FormHelp();
            helpForm.Show();
        }
    }
}
