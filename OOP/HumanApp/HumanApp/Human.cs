using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanApp
{
    public class Human
    {
        private string _name;
        private int _age;
        private float _height,_weight;
        private GenderOptions _gender;


        public Human(string name, int age, float height, float weight, GenderOptions gender)
        {
            this._name = name;
            this._age = age;
            this._height = height;
            this._weight = weight;
            this._gender = gender;

        }

        public void Eat()
        {
            float Weight1 = (_weight + (_weight * 5) / 100);
            _weight = Weight1;
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

        public float Height
        {
            get
            {
                return _height;
            }
        }

        public float Weight
        {
            get
            {
                return _weight;
            }
        }

        public GenderOptions Gender
        {
            get
            {
                return _gender;
            }
        }
    }
   
}
