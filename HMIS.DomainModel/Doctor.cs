using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMIS.DomainModel
{
    public class Doctor
    {
        private string _name;
        private int _ID;
        private string _address;
        private string _username;
        private int _password;
        private List<Patient> _listPacinets = new List<Patient>();

        public Doctor()
        {
        }

        public Doctor(int ID, string name)
        {
            _ID = ID;
            _name = name;
        }

        public Doctor(int ID, string name, string address, string username, int password)
        {
            _ID = ID;
            _name = name;
            _address = address;
            _username = username;
            _password = password;
        }

        public int ID
        {
            get { return _ID; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Username
        {
            get { return _username; }
        }

        public int Password
        {
            get { return _password; }
        }

        public List<Patient> PacientList
        {
            get { return _listPacinets; }
            set { _listPacinets = value; }
        }
    }
}
