using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeConsoleWinApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ButtonPositions position = new ButtonPositions();
            Application.Run(position);
        }
    }
}
