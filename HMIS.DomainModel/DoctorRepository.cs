using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HMIS.BaseInterfaces;
using System.Text.RegularExpressions;

namespace HMIS.DomainModel
{
    public class DoctorRepository : Subject
    {
        private static DoctorRepository _instance = null;
        private List<Doctor> _listDoctors = new List<Doctor>();

        private DoctorRepository()
        {
        }

        public static DoctorRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DoctorRepository();
            }

            return _instance;
        }

        public int Count()
        {
            return _listDoctors.Count;
        }

        public void AddDoctor(int ID, string name, string address, string username, int password)
        {
            foreach (Doctor currentDoctor in _listDoctors)
            {
                if (currentDoctor.ID.Equals(ID))
                    throw new DoctorIDAlreadyExsistsException();
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

            if (string.IsNullOrEmpty(username))
            {
                throw new InvalidUsernameException();
            }

            if (password == 0)
            {
                throw new InvalidPasswordException();
            }

            _listDoctors.Add(new Doctor(ID, name, address, username, password));

            NotifyObservers();
        }

        public void RemoveDoctor(int ID, string name)
        {
            Doctor doc = new Doctor();

            bool IDEx = false;
            bool NameEx = false;

            if (ID < 0)
                throw new RemoveDoctorException();

            foreach (Doctor currentDoctor in _listDoctors)
            {
                if (currentDoctor.ID.Equals(ID) && currentDoctor.Name.Equals(name))
                {
                    doc = currentDoctor;
                }

                if (currentDoctor.ID.Equals(ID))
                    IDEx = true;

                if (currentDoctor.Name.Equals(name))
                    NameEx = true;
            }

            if (IDEx && NameEx)
            {
                _listDoctors.Remove(doc);
            }
            else if(IDEx == false)
                throw new DoctorIDDoesntExsistsException();
            else if(NameEx == false)
                throw new DoctorNameDoesntExsistsException();
                
        }

        public Doctor GetDoctorFromList(int num)
        {
            if (num >= 0)
            {
                return _listDoctors[num];
            }
            else
            {
                throw new DoctorDoesntExsistException();
            }
        }

        public Doctor GetDoctorByID(int ID)
        {
            foreach (Doctor doc in _listDoctors)
            {
                if (doc.ID == ID)
                    return doc;
            }
            return null;
        }
    }
}
