using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMIS.BaseInterfaces
{
    public interface IMainController
    {
        void LoadDefaultModel();
        bool CheckAdminLogin(string name, string pass);
        bool CheckDoctorLogin(string username, int pass);
        bool CheckNurseLogin(string username, int pass);

        void ShowAdminForm();
        void ShowDoctorForm();
        void ShowNurseForm();

        void AddDoctor(int ID, string name, string address, string username, int password);
        void RemoveDoctor(int ID, string name);
        void AddNurse(int ID, string name, string address, string username, int password, bool mainNurse);
        void RemoveNurse(int ID, string name);
        void AddPacient(int ID, string name, string address, string doctorName, int doctorID);
        void RemovePacient(int ID, string name);
        void AddPacientToDoctor();
        void DeletePacientFromDoctor();
        void AddPatientDiagnosis(string name, int ID, string diagnosis, string doctorDiagnosis);
        void ShowDiagnosisForm(string patientName, int patientID, bool nurseLogged, bool doctorLogged);
    }
}
