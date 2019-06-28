using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonEventApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ButtonCLickEvent button = new ButtonCLickEvent();
            Application.Run(button);

        }
    }
}
