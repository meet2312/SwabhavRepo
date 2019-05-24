using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetApp
{
    class Student : IEquatable<Student>
    {
        private string _name;
        private int _age;

        public Student(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
        }

        public override string ToString()
        {
            return " Name:" + _name + "  Age" + _age;
        }

        public bool Equals(Student other)
        {
            Console.WriteLine(this.Name.Equals(other.Name));
            return this._name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            Console.WriteLine(this.Name.GetHashCode());
            return this.Name.GetHashCode();
        }
    }
}
