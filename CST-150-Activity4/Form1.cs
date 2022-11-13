using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity4
{
    public partial class TimeCalculator : Form
    {
        public TimeCalculator()
        {
            InitializeComponent();
        }

        private void conversionButton_Click(object sender, EventArgs e)
        {
            //convert user input from string to int
            int seconds;
            int.TryParse(elapsedSeconds.Text, out seconds);

            //if seconds is less than 1 minute, print out the number of seconds
            if(seconds < 60)
            {
                conversionLabel.Text = seconds.ToString() + " seconds";
            }
            else
            {//if seconds is less than 1 hour, print the number of minutes and seconds
                if(seconds < 3600)
                {
                    int minutes = seconds / 60;
                    int remainingSeconds = seconds % 60;
                    conversionLabel.Text = minutes.ToString() + " minutes, " + remainingSeconds.ToString() + " seconds";
                }
                else
                {
                    if(seconds < 868400)
                    {//if seconds is less than 1 day, print the number of hours, minutes and seconds
                        int hours = seconds / 3600;
                        int minutes = (seconds % 3600)/60;
                        int remainingSeconds = (seconds % 3600) % 60;
                        conversionLabel.Text = hours.ToString() + " hours, " + minutes.ToString() + " minutes, " + remainingSeconds + " seconds";
                    } 
                    else
                    {//print days, hours, minutes, seconds
                        int days = seconds / 868400;
                        int hours = (seconds % 868400) / 3600;
                        int minutes = ((seconds % 868400) % 3600)/60;
                        int remainingSeconds = ((seconds % 868400) % 3600) % 60;                       
                        conversionLabel.Text = "greater than one day";

                    }

                }
            }
        }
    }
}
