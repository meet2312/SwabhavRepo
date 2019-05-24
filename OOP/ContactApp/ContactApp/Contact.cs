using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    class Contact
    {
        private string _firstname, _lastname;
        private string _email;
        double _phoneno;

        public Contact(string firstname,string lastname,string email,double phoneno)
        {
            _firstname = firstname;
            _lastname = lastname;
            _email = email;
            _phoneno = phoneno;
        }

        public string Firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public double Phoneno
        {
            get
            {
                return _phoneno;
            }
            set
            {
                _phoneno = value;
            }
        }

        public void Display()
        {
            Console.WriteLine(" First name:" + _firstname + " Last name:" + _lastname + " Email:" + _email + " Phone no:" + _phoneno);
        }
        public override string ToString()
        {
            return " First name:" + _firstname + " Last name:" + _lastname + " Email:" + _email + " Phone no:" + _phoneno;
        }
    }
}
