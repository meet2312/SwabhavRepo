using System;

namespace DogDemoApp
{
    public class DogDoor
    {
        private bool open;

        public DogDoor()
        {
            this.open = false;
        }
        public void Open()
        {
            Console.WriteLine("The dog door opens.");
            open = true;
        }

        public void Close()
        {
            Console.WriteLine("THe dog dor closes");
            open = false;
        }

        public bool isOpen()
        {
            return open;
        }
    }
}