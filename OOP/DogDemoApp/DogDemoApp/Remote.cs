using System;

namespace DogDemoApp
{
    public class Remote
    {
        private DogDoor door;
        public Remote(DogDoor door)
        {
            this.door = door;
        }
        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button....");
            if (door.isOpen())
            {
                door.Close();
            }
            else
            {
                door.Open();
            }
        }
    }
}