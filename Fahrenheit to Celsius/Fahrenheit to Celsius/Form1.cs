using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrenheit_to_Celsius
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double input8;
        double input12;
        double input5;
        double output8;
        double output12;
        double output5;


        private void btnToCelsius_Click(object sender, EventArgs e)
        {
            input8 = Convert.ToInt32(txtMorning.Text);
            input12 = Convert.ToInt32(txtNoon.Text);
            input5 = Convert.ToInt32(txtAfternoon.Text);

            output8 = (input8 - 32) * 5/9;
            output12 = (input12 - 32) * 5/9;
            output5 = (input5 - 32) * 5/9;

            if (output8 < 0)
                lblOutput1.Text = ("It is freezing " + Math.Round(output8, 2));
            else if (output8 > 37)
                lblOutput2.Text = ("It is hotttt " + Math.Round(output12, 2));
            else
                lblOutput3.Text = ("It is " + output5 + " degrees out");

        }

        private void btnToF_Click(object sender, EventArgs e)
        {

        }
    }
}
