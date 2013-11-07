using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HMIS.BaseInterfaces;

namespace HMIS.DomainModel
{
    public class NurseRepository : Subject
    {
        private static NurseRepository _instance = null;
        private List<Nurse> _listNurses = new List<Nurse>();

        private NurseRepository()
        {
        }

        public static NurseRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new NurseRepository();
            }

            return _instance;
        }

        public int Count()
        {
            return _listNurses.Count;
        }

        public void AddNurse(int ID, string name, string address, string username, int password, bool mainNurse)
        {
            foreach (Nurse currentNurse in _listNurses)
            {
                if (currentNurse.ID.Equals(ID))
                    throw new NurseIDAlreadyExsistsException();
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

            _listNurses.Add(new Nurse(ID, name, address, username, password, mainNurse));

            NotifyObservers();
        }

        public void RemoveNurse(int ID, string name)
        {
            Nurse nur = new Nurse();

            bool IDEx = false;
            bool NameEx = false;

            if (ID < 0)
                throw new RemoveDoctorException();

            foreach (Nurse currentNurse in _listNurses)
            {
                if (currentNurse.ID.Equals(ID) && currentNurse.Name.Equals(name))
                {
                    nur = currentNurse;
                }

                if (currentNurse.ID.Equals(ID))
                    IDEx = true;

                if (currentNurse.Name.Equals(name))
                    NameEx = true;
            }

            if (IDEx && NameEx)
            {
                _listNurses.Remove(nur);
            }
            else if (IDEx == false)
                throw new DoctorIDDoesntExsistsException();
            else if (NameEx == false)
                throw new DoctorNameDoesntExsistsException();

        }

        public Nurse GetNurseFromList(int num)
        {
            if (num >= 0)
            {
                return _listNurses[num];
            }
            else
            {
                throw new DoctorDoesntExsistException();
            }
        }

        public Nurse GetNurseByID(int ID)
        {
            foreach (Nurse nur in _listNurses)
            {
                if (nur.ID == ID)
                    return nur;
            }
            return null;
        }
    }
}
