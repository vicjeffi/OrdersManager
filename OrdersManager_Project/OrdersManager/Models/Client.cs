using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManager.Models
{
    class Client
    {
        private string _firstName;
        private string _lastName;
        private string _fatherName;
        public Client()
        {
            Name = "None"; FatherName = "None"; LastName = "None";
        }
        public Client(string firstname, string lastname, string fathername)
        {
            Name = firstname; FatherName = lastname; LastName = fathername;
        }
        public string Name
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string FatherName
        {
            get { return _fatherName; }
            set { _fatherName = value; }
        }
        public string FullName
        {
            get { return string.Join(" ", Name, LastName, FatherName); }
        }
        public override string ToString()
        {
            return FullName;
        }
    }
}
