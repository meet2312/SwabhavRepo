using System;

namespace Chap9Example
{
    internal class Duck
    {
        int pounds = 6;
        float floatability = 2.1F;
        string name = "Generic";
        long[] feathers = { 1, 2, 3, 4, 5, 6, 7 };
        bool canFly = true;
        int maxSpeed = 25;

        public Duck()
        {
            Console.WriteLine("Type 1 duck");
        }

        public Duck(bool fly)
        {
            canFly = fly;
            Console.WriteLine("type 2 duck");
        }

        public Duck(String n, long[] f)
        {
            name = n;
            feathers = f;
            Console.WriteLine("type 3 duck");
        }

        public Duck(int w, float f)
        {
            pounds = w;
            floatability = f;
            Console.WriteLine("type 4 duck");
        }

        public Duck(float density, int max)
        {
            floatability = density;
            maxSpeed = max;
            Console.WriteLine("type 5 duck");

        }
    }
}