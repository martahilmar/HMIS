using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HMIS.BaseInterfaces;

namespace HMIS.DomainModel
{
    public class PatientRepository : Subject
    {
        private static PatientRepository _instance = null;
        private List<Patient> _listPacinets = new List<Patient>();

        private PatientRepository()
        {
        }

        public static PatientRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PatientRepository();
            }

            return _instance;
        }

        public int Count()
        {
            return _listPacinets.Count;
        }

        public void AddPacient(int ID, string name, string address, string doctorName, int doctorID)
        {
            if (ID < 0)
                throw new AddNewDoctorException();

            foreach (Patient currentPacinet in _listPacinets)
            {
                if (currentPacinet.ID.Equals(ID))
                    throw new PatientDAlreadyExsistsException();
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidNameException();
            }

            if (ID == 0)
            {
                throw new InvalidIDException();
            }

            if (string.IsNullOrEmpty(address))
            {
                throw new InvalidAddressException();
            }

            _listPacinets.Add(new Patient(ID, name, address, doctorName, doctorID));

            NotifyObservers();
        }

        public void RemovePacient(int ID, string name)
        {
            Patient nur = new Patient();

            bool IDEx = false;
            bool NameEx = false;

            if (ID < 0)
                throw new RemoveDoctorException();

            foreach (Patient currentPacient in _listPacinets)
            {
                if (currentPacient.ID.Equals(ID) && currentPacient.Name.Equals(name))
                {
                    nur = currentPacient;
                }

                if (currentPacient.ID.Equals(ID))
                    IDEx = true;

                if (currentPacient.Name.Equals(name))
                    NameEx = true;
            }

            if (IDEx && NameEx)
            {
                _listPacinets.Remove(nur);
            }
            else if (IDEx == false)
                throw new DoctorIDDoesntExsistsException();
            else if (NameEx == false)
                throw new DoctorNameDoesntExsistsException();

            NotifyObservers();
        }

        public Patient GetPacientFromList(int num)
        {
            if (num >= 0)
            {
                return _listPacinets[num];
            }
            else
            {
                throw new DoctorDoesntExsistException();
            }
        }

        public Patient GetPacientByID(int ID)
        {
            foreach (Patient nur in _listPacinets)
            {
                if (nur.ID == ID)
                    return nur;
            }
            return null;
        }
    }
}
