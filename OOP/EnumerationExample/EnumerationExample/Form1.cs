using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumerationExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum Temperature
        {
            Low,
            Medium,
            High,
        };
        private void button1_Click(object sender, EventArgs e)
        {
            Temperature value = Temperature.Medium;
            if (value == Temperature.Medium)
            {
                MessageBox.Show("Temperature is Medium..");
            }
        }

    }
}

