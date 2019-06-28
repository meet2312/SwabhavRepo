using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleWindowForm
{
    class WelcomeForm:Form
    {
        public WelcomeForm()
        {
         //   this.Width = 1024;
         //   this.Height = 768;
            this.Text = "MEET";   // text to be displayed on title bar
            this.ClientSize = new System.Drawing.Size(1024, 768);
        }
    }
}
