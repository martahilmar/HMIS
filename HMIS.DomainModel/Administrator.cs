using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMIS.DomainModel
{
    public class Administrator
    {
        private string _name;
        private string _pass;

        public Administrator(string name, string pass)
        {
            _name = name;
            _pass = pass;
        }

        public string Name
        {
            get { return _name; }
        }

        public string Pass
        {
            get { return _pass; }
        }
    }
}
