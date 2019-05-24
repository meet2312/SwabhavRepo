using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp
{
    class Student:Person
    {
        private Branch _branch;
        public Student(int _id,string _address,string _dob,Branch _branch) :base(_id,_address,_dob)
        {
            this._branch = _branch;
        }
       
        public enum Branch
        {
            IT,Comps,Extc,Electronics,Mech,civil
        }

        public override string ToString()
        {
            return "id:" + _id+ "address:" + _address + "Dob:" + _dob + "_branch:" + _branch;
        }
    }
}
