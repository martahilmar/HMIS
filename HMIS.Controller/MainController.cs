using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HMIS.BaseInterfaces;
using HMIS.PresentationLayer;
using HMIS.DomainModel;

namespace HMIS.Controller
{
    public class MainController : IMainController
    {
        readonly DoctorRepository _doctorRepository = DoctorRepository.GetInstance();
        readonly NurseRepository _nurseRepository = NurseRepository.GetInstance();
        readonly PatientRepository _pacientRepository = PatientRepository.GetInstance();

        Nurse nurseLoged = new Nurse();
        Doctor doctorLoged = new Doctor();

        private bool _defaultModelLoaded = false;

        public MainController()
        {
            Administrator admin = new Administrator("admin", "1234");

            LoadDefaultModel();
        }

        public void LoadDefaultModel()
        {
            if (_defaultModelLoaded == false)
            {
                _doctorRepository.AddDoctor(12456, "Iva Perić", "Jakusevecka 32a", "ivaperic", 1111);
                _doctorRepository.AddDoctor(631543, "Marko Mirković", "Unska 4", "markomirkovic", 2222);
                _doctorRepository.AddDoctor(51335, "Pero Perić", "Zelinska 5", "peroperic", 1212);
                _doctorRepository.AddDoctor(61356, "Karla Vukić", "Medvedgraska 5", "karlavukic", 2121);
                _doctorRepository.AddDoctor(35125, "Ante Žalić", "Ukarijnska 12", "antezalic", 3425);
                _doctorRepository.AddDoctor(36264, "Anita Betle", "Vukovarka 7", "anitabetle", 5487);
                _doctorRepository.AddDoctor(65130, "Larisa Ole", "Karlovačka 4", "larisaole", 5471);

                _nurseRepository.AddNurse(51531, "Mirta Mirić", "Varsavska 7", "mirtamiric", 3333, true);
                _nurseRepository.AddNurse(32434, "Katarina Katić", "Frankopanska 4", "katakatic", 4444, false);
                _nurseRepository.AddNurse(23432, "Nino Beli", "Kopernikova 5", "ninobeli", 5555, false);
                _nurseRepository.AddNurse(51856, "Željko Jagatić", "Varšavksa 12", "zeljkojagatic", 4345, false);
                _nurseRepository.AddNurse(51375, "Marko Matić", "Galebska 5", "markomatic", 3642, false);
                _nurseRepository.AddNurse(32566, "Bozica Milić", "Držićeva 74", "bozicamilic", 5478, false);
                _nurseRepository.AddNurse(24256, "Ana Anić", "Vinogradska 4", "anaanic", 5476, false);
                _nurseRepository.AddNurse(12545, "Božidar Božić", "Degenova 34", "bozidarbozic", 6547, false);

                _pacientRepository.AddPacient(52424, "Karlo Tomić", "Vocarska 23", "Iva Perić", 12456);
                _pacientRepository.AddPacient(54631, "Marko Marić", "Zelinska 4", "Iva Perić", 12456);
                _pacientRepository.AddPacient(65465, "Ivo Ivić", "Medvedgradska 84", "Marko Mirkovic", 631543);
                _pacientRepository.AddPacient(64872, "Neda Violić", "Gubska 4", "Karla Vukić", 61356);
                _pacientRepository.AddPacient(48588, "Marina Pokos", "Ukrainska 5", "Iva Perić", 12456);
                _pacientRepository.AddPacient(69374, "Marijana Marković", "Petrova 12", "Larisa Ole", 65130);
                _pacientRepository.AddPacient(35472, "Marinko Prić", "Donja Stubica 4", "Ante Žalić", 35125);
                _pacientRepository.AddPacient(65667, "Boris Jelina", "Vlaška 43", "Anita Betle", 36264);
                _pacientRepository.AddPacient(38242, "Ante Perina", "Čulinečka 5", "Anita Betle", 36264);
                _pacientRepository.AddPacient(24762, "Tia Vuković", "Vukovarska 36", "Anita Betle", 36264);
                _pacientRepository.AddPacient(24522, "Tino Žanić", "Malinska 45", "Marko Mirković", 631543);
                _pacientRepository.AddPacient(25366, "Petar Danić", "Hvarska 56", "Marko Mirković", 631543);
                _pacientRepository.AddPacient(24255, "Matija Gubec", "Vukovarska 5", "Marko Mirković", 631543);

                AddPacientToDoctor();
                AddPatientDiagnosis("Karlo Tomić", 52424, "pneumonija", "Upala pluća uzrokovana mikrobakterijom Pneumina.");
                AddPatientDiagnosis("Marko Marić", 54631, "KOPB", "Kronična opstruktivna bolest pluća uzrokovana pušenjem.");
                AddPatientDiagnosis("Ivo Ivić", 65465, "Nepoznata", "Pacijent se žali na bol u prsnoj šupljini.");
                AddPatientDiagnosis("Neda Violić", 64872, "TBC", "Tuberculosis, uzrokovana bakterijom microbacteriumtuberculosis.");
                AddPatientDiagnosis("Marina Pokos", 48588, "Nepoznata", "Pacijent se žali na bol u prsnoj šupljini.");
                AddPatientDiagnosis("Marijana Marković", 69374, "Edem pluća", "Edem pluća uzrokovana prekomjernim nakupljanjem tekućine u prsnoj šupljini.");
                AddPatientDiagnosis("Marinko Prić", 35472, "pneumonija", "Upala pluća uzrokovana bakterijom Tuberculosis.");
                AddPatientDiagnosis("Boris Jelina", 65667, "Karcinom bronha", "Karcinom bronha nepoznatog uzorka.");
                AddPatientDiagnosis("Ante Perina", 38242, "Nepoznata", "Pacijent se žali na bol u prsnoj šupljini.");
                AddPatientDiagnosis("Tia Vuković", 24762, "Nepoznata", "Pacijent se žali na bol u prsnoj šupljini.");
                AddPatientDiagnosis("Tino Žanić", 24522, "Nepoznata", "Pacijent se žali na bol u prsnoj šupljini.");
                AddPatientDiagnosis("Petar Danić", 25366, "TBC", "Tuberculosis, uzrokovana bakterijom microbacteriumtuberculosis.");
                AddPatientDiagnosis("Matija Gubec", 24255, "TBC", "Tuberculosis, uzrokovana bakterijom microbacteriumtuberculosis.");
                _defaultModelLoaded = true;
            }
        }

        public bool CheckAdminLogin(string name, string pass)
        {
            if (name == "admin" && pass == "1234")
                return true;
            else
                return false;
        }

        public bool CheckDoctorLogin(string username, int pass)
        {
            bool exists = false;

            for (int i = 0; i < _doctorRepository.Count(); i++)
            {
                Doctor doctor = _doctorRepository.GetDoctorFromList(i);

                if (doctor.Username == username && doctor.Password == pass)
                {
                    doctorLoged = doctor;
                    exists = true;
                }
            }

            return exists;
        }

        public bool CheckNurseLogin(string username, int pass)
        {
            bool exists = false;

            for (int i = 0; i < _nurseRepository.Count(); i++)
            {
                Nurse nurse = _nurseRepository.GetNurseFromList(i);

                if (nurse.Username == username && nurse.Password == pass)
                {
                    nurseLoged = nurse;
                    exists = true;
                }
            }

            return exists;
        }

        public void ShowAdminForm()
        {
            FormAdminWindow formAdminView = new FormAdminWindow(this, _doctorRepository, _nurseRepository);
            formAdminView.ShowDialog();
        }

        public void ShowDoctorForm()
        {
            FormDoctorWindow formDoctorView = new FormDoctorWindow(this, _pacientRepository, doctorLoged);
            formDoctorView.ShowDialog();
        }

        public void ShowNurseForm()
        {
            FormNurseWindow formNurseView = new FormNurseWindow(this, _doctorRepository, _pacientRepository, nurseLoged);
            formNurseView.ShowDialog();
        }

        public void ShowDiagnosisForm(string patientName, int patientID, bool nurseLogged, bool doctorLogged)
        {
            FormDiagnosis formDiagnosisView = new FormDiagnosis(this, _pacientRepository, patientName, patientID, nurseLogged, doctorLogged);
            formDiagnosisView.ShowDialog();
        }

        public void AddDoctor(int ID, string name, string address, string username, int password)
        {
            try
            {
                _doctorRepository.AddDoctor(ID, name, address, username, password);
            }
            catch (DoctorIDAlreadyExsistsException existsException)
            {
                throw existsException;
            }
        }

        public void RemoveDoctor(int ID, string name)
        {
            try
            {
                _doctorRepository.RemoveDoctor(ID, name);
            }
            catch (DoctorIDDoesntExsistsException doesntexistsException)
            {
                throw doesntexistsException;
            }
            catch (DoctorNameDoesntExsistsException doesntexistsException)
            {
                throw doesntexistsException;
            }
        }

        public void AddNurse(int ID, string name, string address, string username, int password, bool mainNurse)
        {
            try
            {
                _nurseRepository.AddNurse(ID, name, address, username, password, mainNurse);
            }
            catch (DoctorIDAlreadyExsistsException existsException)
            {
                throw existsException;
            }
        }

        public void RemoveNurse(int ID, string name)
        {
            try
            {
                _nurseRepository.RemoveNurse(ID, name);
            }
            catch (DoctorIDDoesntExsistsException doesntexistsException)
            {
                throw doesntexistsException;
            }
            catch (DoctorNameDoesntExsistsException doesntexistsException)
            {
                throw doesntexistsException;
            }
        }

        public void AddPacient(int ID, string name, string address, string doctorName, int doctorID)
        {
            try
            {
                _pacientRepository.AddPacient(ID, name, address, doctorName, doctorID);
            }
            catch (DoctorIDAlreadyExsistsException existsException)
            {
                throw existsException;
            }
        }

        public void RemovePacient(int ID, string name)
        {
            try
            {
                _pacientRepository.RemovePacient(ID, name);
            }
            catch (DoctorIDDoesntExsistsException doesntexistsException)
            {
                throw doesntexistsException;
            }
            catch (DoctorNameDoesntExsistsException doesntexistsException)
            {
                throw doesntexistsException;
            }
        }

        public void AddPacientToDoctor()
        {
            Doctor doctor = new Doctor();
            Patient pacient = new Patient();

            for (int j = 0; j < _pacientRepository.Count(); j++)
            {
                pacient = _pacientRepository.GetPacientFromList(j);

                for (int i = 0; i < _doctorRepository.Count(); i++)
                {
                    doctor = _doctorRepository.GetDoctorFromList(i);
                    if (pacient.DoctorName == doctor.Name && pacient.DoctorID == doctor.ID)
                    {
                        doctor.PacientList.Add(new Patient(pacient.ID, pacient.Name, pacient.Address, doctor.Name, doctor.ID));
                    }
                }
            }
        }

        public void DeletePacientFromDoctor()
        {
            Doctor doctor = new Doctor();
            Patient pacient = new Patient();

            for (int i = 0; i < _doctorRepository.Count(); i++)
            {
                Doctor doc = _doctorRepository.GetDoctorFromList(i);

                doc.PacientList.Clear();
            }

            for (int j = 0; j < _pacientRepository.Count(); j++)
            {
                pacient = _pacientRepository.GetPacientFromList(j);

                for (int i = 0; i < _doctorRepository.Count(); i++)
                {
                    doctor = _doctorRepository.GetDoctorFromList(i);
                    if (pacient.DoctorName == doctor.Name && pacient.DoctorID == doctor.ID)
                    {
                        doctor.PacientList.Add(new Patient(pacient.ID, pacient.Name, pacient.Address, doctor.Name, doctor.ID));
                    }
                }
            }
        }

        public void AddPatientDiagnosis(string name, int ID, string diagnosis, string doctorDiagnosis)
        {
            Patient patient = new Patient();

            for (int j = 0; j < _pacientRepository.Count(); j++)
            {
                patient = _pacientRepository.GetPacientFromList(j);
                if (patient.Name == name && patient.ID == ID)
                {
                    patient.Diagnosis = diagnosis;
                    patient.DoctorDiagnosis = doctorDiagnosis;
                }
            }
        }
    }
}
