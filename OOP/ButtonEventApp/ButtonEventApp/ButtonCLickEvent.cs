using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonEventApp
{
  class ButtonCLickEvent:Form
    {
        Button b,b1;
        public  ButtonCLickEvent()
        {
            // CaseStudy1();
            CaseStudy2();

        }

        private void CaseStudy2()
        {
            this.Width = 1024;
            this.Height = 768;
            b = new Button();
            b1 = new Button();
            b.Width = 100;
            b.Height = 100;
            b.Text = "red";
            b1.Width = 100;
            b1.Height = 100;
            b1.Text = "blue";
            b.Location = new System.Drawing.Point(30, 30);
            b1.Location = new System.Drawing.Point(150, 150);
            this.Controls.Add(b);
            this.Controls.Add(b1);
            b.Click += new EventHandler(Colour);
            b1.Click += new EventHandler(Colour);
        }

        private void CaseStudy1()
        {
            this.Width = 1024;
            this.Height = 768;
            b = new Button();
            b.Width = 100;
            b.Height = 100;
            b.Text = "save";
            b.Location = new System.Drawing.Point(30, 30);
            this.Controls.Add(b);
            b.Click += new EventHandler(ClickEvent);
            b.Click += ClickEventReq;
        }

        private void ClickEvent(object sender , EventArgs args)
        {
            MessageBox.Show("Subscriber 1 called");
        }
        private void ClickEventReq(object sender, EventArgs args)
        {
            MessageBox.Show("Subscriber 2 called");
        }
        private void Colour(object sender, EventArgs args)
        {
            var button = (Button)sender;
          //  button.BackColor = Color.White;


              switch (button.Text)
              {
                  case "red":
                    this.BackColor = Color.Red;
                      break;
                  case "blue":
                    this.BackColor = Color.Blue;
                      break;
                  default: { button.BackColor = Color.White; } break;


              }
              

        }
    }
}
