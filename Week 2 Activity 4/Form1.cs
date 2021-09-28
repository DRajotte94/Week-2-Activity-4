using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_2_Activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // variables
            int seconds, minutes, hours, days;

            // converts input from string to integer
            if (int.TryParse(inputBox.Text, out seconds))
            {
                if (seconds >= 60) // counts and displays minutes
                {
                    minutes = seconds / 60;
                    minuteBox.Text = minutes.ToString() + " minute(s)";
                }
                else // resets to 0
                {
                    minutes = 0;
                    minuteBox.Text = minutes.ToString() + " minute(s)";
                }

                if (seconds >= 3600) // counts and displays hours
                {
                    hours = seconds / 3600;
                    hourBox.Text = hours.ToString() + " hour(s)";
                }
                else // resets to 0
                {
                    hours = 0;
                    hourBox.Text = hours.ToString() + " hour(s)";
                }

                if (seconds >= 86400) // counts and displays days
                {
                    days = seconds / 86400;
                    dayBox.Text = days.ToString() + " day(s)";
                }
                else // resets to 0
                {
                    days = 0;
                    dayBox.Text = days.ToString() + " day(s)";
                }

            } 
            else
            {
                // if unable to convert input to integer, show error message
                MessageBox.Show("Please enter a number");
            }
        }
    }
}
