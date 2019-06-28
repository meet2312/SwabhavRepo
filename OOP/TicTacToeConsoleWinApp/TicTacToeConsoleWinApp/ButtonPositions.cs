using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeConsoleWinApp
{
    class ButtonPositions:Form
    {
        Button b1, b2, b3, b4, b5, b6, b7, b8, b9;
        public ButtonPositions()
        {
            this.Width = 1024;
            this.Height = 768;
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            b1.Width = 100;
            b1.Height = 100;
            b2.Width = 100;
            b2.Height = 100;
            b3.Width = 100;
            b3.Height = 100;
            b1.Text="cell1";
            b4.Width = 100;
            b4.Height = 100;
            b5.Width = 100;
            b5.Height = 100;
            b6.Width = 100;
            b6.Height = 100;
            b7.Width = 100;
            b7.Height = 100;
            b8.Width = 100;
            b8.Height = 100;
            b9.Width = 100;
            b9.Height = 100;
            b1.Location = new System.Drawing.Point(181,142);
            b2.Location = new System.Drawing.Point(462,142);
            b3.Location = new System.Drawing.Point(743, 142);
            b4.Location = new System.Drawing.Point(181, 384);
            b5.Location = new System.Drawing.Point(181, 626);


            this.Controls.Add(b1);
            this.Controls.Add(b2);
            this.Controls.Add(b3);
            this.Controls.Add(b4);
            this.Controls.Add(b5);
        //    this.Controls.Add(b6);
        //    this.Controls.Add(b7);
        //    this.Controls.Add(b8);
        //    this.Controls.Add(b9);




        }
    }
}
