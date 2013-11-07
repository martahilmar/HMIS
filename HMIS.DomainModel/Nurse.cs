using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMIS.DomainModel
{
    public class Nurse
    {
        private string _name;
        private int _ID;
        private string _address;
        private string _username;
        private int _password;
        private bool _mainNurse;

        public Nurse()
        {
        }

        public Nurse(int ID, string name)
        {
            _ID = ID;
            _name = name;
        }

        public Nurse(int ID, string name, string address, string username, int password, bool mainNurse)
        {
            _ID = ID;
            _name = name;
            _address = address;
            _username = username;
            _password = password;
            _mainNurse = mainNurse;
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

        public bool MainNurse
        {
            get { return _mainNurse; }
        }
    }
}
