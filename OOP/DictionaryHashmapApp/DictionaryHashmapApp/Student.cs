using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryHashmapApp
{
    class Student:IEqualityComparer<Dictionary<Student, Student>>
    {
        private string _name;
        private int _rollno;
        private int _standard;

        public Student(string name,int rollno,int standard)
        {
            this._name = name;
            this._rollno = rollno;
            this._standard = standard;
        }
        
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int Rollno
        {
            get
            {
                return _rollno;
            }
        }

        public int Standard
        {
            get
            {
                return _standard;
            }
        }

        public bool Equals(Dictionary<Student, Student> x, Dictionary<Student, Student> y)
        {
            if (x.Keys == y.Keys && (x.Values == y.Values) && (x.Values == y.Values))
                return true;

            return false;

        }

        public int GetHashCode(Dictionary<Student, Student> obj)
        {
            Console.WriteLine(obj.Keys.GetHashCode());
            return obj.Keys.GetHashCode();
        }

        public override string ToString()
        {
            return " Name:" + _name + " roll no:" + _rollno + " standard:" + _standard;

        }
    }
}
