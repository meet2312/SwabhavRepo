using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    public class Player
    {
        private string _name;
        private int _age;
        private int _id;
        static int _count;
        public Player(string _name,int _age,int _id)
        {
           this._name = _name;
           this._age = _age;
           this._id = _id;
           _count++;
        }

        static Player()
        {
            Console.WriteLine("Inside static constructor");
        }

        public Player(string _name,int _id) : this(_name,18,_id)
        {
          
        }
       
        public Player WhoIsElder(Player secondplayer)
        {
            if(secondplayer._age>this._age )
            {
                return secondplayer;
            }
            return this;
        }

        public static int GetCount()
        {
            return _count;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }
        
    }
}
