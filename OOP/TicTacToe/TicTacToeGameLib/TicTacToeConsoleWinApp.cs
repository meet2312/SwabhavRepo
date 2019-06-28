using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGameLib
{
   public class TicTacToeConsoleWinApp:Form
    {
       // Button button;
        private static Game game;
        private static Result res;
        private Player player;
        //  private static int turn = 0;
        //  private static Label displayturn = null;
        public Label displayturn;
        public Label status;
        public TicTacToeConsoleWinApp()
        {
            this.Width = 1024;
            this.Height = 600;
            this.Text = "Welcome to tic tac toe game";
            this.BackColor = System.Drawing.Color.LightBlue;

            Label label1 = new Label();
            this.Controls.Add(label1);
            label1.BackColor = Color.SkyBlue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new Point(237, 12);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 9;
            label1.Text = "Turn";
            label1.TextAlign = ContentAlignment.MiddleCenter;

            displayturn = new Label();
            this.Controls.Add(displayturn);
            displayturn.BackColor = Color.White;
            displayturn.BorderStyle = BorderStyle.FixedSingle;
            displayturn.ForeColor = Color.Black;
            displayturn.Location = new Point(237, 34);
            displayturn.Name = "displayturn";
            displayturn.Size = new Size(120, 38);
            displayturn.TabIndex = 10;

            Label label2 = new Label();
            this.Controls.Add(label2);
            label2.BackColor = Color.SkyBlue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new Point(437, 12);
            label2.Name = "label2";
            label2.Size = new Size(200, 23);
            label2.TabIndex = 10;
            label2.Text = "Game Status";


            status = new Label();
            this.Controls.Add(status);
            status.BackColor = Color.White;
            status.BorderStyle = BorderStyle.FixedSingle;
            status.ForeColor = Color.Black;
            status.Location = new Point(437, 34);
            status.Name = "status";
            status.Size = new Size(150, 38);
            status.TabIndex = 11;

            //  label1.TextAlign = ContentAlignment.MiddleCenter;

            // displayturn.TextAlign = ContentAlignment.MiddleCenter;

            // Label label1 = new Label();
            //   label1.AutoSize = false;
            //   label1.Height = 2022;
            //   label1.BorderStyle = BorderStyle.Fixed3D;
            //    this.Controls.Add(label1);

            //   Image myimage = new Bitmap(@"E:\swabhav techlabs\images1.png");
            //   this.BackgroundImage = myimage;

            for (int cellindex=0;cellindex<3;cellindex++)
            {
                Button button = new Button();
                button.Width = 100;
                button.Height = 100;
                button.BackColor = Color.DarkGray;
                button.Text = (cellindex).ToString();
                button.Location = new Point((281 * cellindex) + 181, 75);
                button.Click += new EventHandler(ButtonClick);
                button.Tag = cellindex;
                this.Controls.Add(button);
            }
            for (int cellindex = 0; cellindex < 3; cellindex++)
            {
                Button button = new Button();
                button.Width = 100;
                button.Height = 100;
                button.BackColor = Color.DarkGray;
                button.Text = (cellindex+3).ToString();
                button.Location = new Point((281 * cellindex) + 181, 250);
                button.Click += new EventHandler(ButtonClick);
                button.Tag = cellindex;
                this.Controls.Add(button);
            }
            for (int cellindex = 0; cellindex < 3; cellindex++)
            {
                Button button = new Button();
                button.Width = 100;
                button.Height = 100;
                button.BackColor = Color.DarkGray;
                button.Text = (cellindex+6).ToString();
                button.Location = new Point((281 * cellindex) + 181, 425);
                button.Click += new EventHandler(ButtonClick);
                button.Tag = cellindex;
                this.Controls.Add(button);
            }

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button b = sender as Button;
            game = new Game();
          
            int index = int.Parse(b.Text);
            
         //   MessageBox.Show(index.ToString());
            game.Play(index);
            b.Text = game.Player.Mark.ToString();
            displayturn.Text = game.Player.Name;
            // status.Text = game.Status.ToString();
            status.Text = game.getCurrentStatus();
    
        }

    }
}
