using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGameLib
{
   public class GameStart:Form
    {
        Button button;
        public GameStart()
        {
            this.Width = 1024;
            this.Height = 600;
            this.Text = "TIC TAC TOE GAME";
            Image myimage = new Bitmap(@"E:\swabhav techlabs\images.jpg");
            this.BackgroundImage = myimage;
            button = new Button();
            button.Text = "START GAME";
            button.Width = 150;
            button.Height = 60;
            button.BackColor = Color.Aquamarine;
            
            button.Location = new Point(450,250);
            button.Click += new EventHandler(ButtonClickStart);
            this.Controls.Add(button);

        }

        private void ButtonClickStart(object sender, EventArgs e)
        {
            this.Hide();
            TicTacToeConsoleWinApp winapp = new TicTacToeGameLib.TicTacToeConsoleWinApp();
            winapp.ShowDialog();
        }
    }
}
