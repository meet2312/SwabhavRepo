using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Man
    {
        public virtual void Play()
        {
            Console.WriteLine("Man is playing");
        }
        public void Eat()
        {
            Console.WriteLine("Man is eating");
        }

    }
}
