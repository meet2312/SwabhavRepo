using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeGameLib;
namespace TicTacToeGameSol
{
    class Program
    {
        static void Main(string[] args)
        {
             TicTacToeConsole tictactoe = new TicTacToeConsole();
              tictactoe.Start();
            //  TicTacToeConsoleWinApp winapp = new TicTacToeGameLib.TicTacToeConsoleWinApp();
            //   Application.Run(winapp);
            GameStart start = new GameStart();
            Application.Run(start);

        }
    }
}
