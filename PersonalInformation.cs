using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Information_Class
{
    internal class PersonalInformation
    {
        private string _name;
        private string _address;
        private int _age;
        private string _phone;

        public PersonalInformation(string name, string address, int age, string phone)
        {
            _name = name;
            _address = address;
            _age = age;
            _phone = phone;
        }   

        public string Name { get { return _name; } }
        public string Address { get { return _address; } }
        public int Age { get { return _age; } }
        public string Phone { get { return _phone; } }



    }
}
