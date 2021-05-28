using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Stream_Countdown_Timer
{
    public partial class StreamCountdownTimer : Form
    {
        int hours;
        int minutes;
        int seconds;
        DateTime currentTime;
        DateTime start;

        public StreamCountdownTimer ()
        {
            InitializeComponent();
            t.Enabled = false;
        }

        private void label1_Click ( object sender, EventArgs e )
        {

        }

        private void label2_Click ( object sender, EventArgs e )
        {

        }

        private void SetTimerText_TextChanged ( object sender, EventArgs e )
        {

        }

        private void SetStartTimeText_TextChanged ( object sender, EventArgs e )
        {

        }

        private void button1_Click ( object sender, EventArgs e )
        {
            currentTime = DateTime.Now;
            String timer = SetTimerText.Text;
            String startTime = SetStartTimeText.Text;

            if ( !startTime.Equals("") && !timer.Equals("") )
            {
                MessageBox.Show("You cannot input a timer and specific starting time at the same time.");
            }
            else if ( startTime.Equals("") && timer.Equals("") )
            {
                MessageBox.Show("You need to input either a timer or a specific starting time.");
            }
            else if ( !timer.Equals("") )
            {
                t.Enabled = true;

                if ( timer.Substring(timer.Length - 1).Equals("h") )
                {
                    hours = Int32.Parse(timer.Substring(0, timer.Length - 2));
                    minutes = 0;
                    seconds = 0;
                    t.Start();
                }
                else if ( timer.Substring(timer.Length - 1).Equals("m") )
                {
                    minutes = Int32.Parse(timer.Substring(0, timer.Length - 2));
                    hours = minutes / 60;
                    minutes %= 60;
                    seconds = 0;
                    t.Start();
                }
                else {
                    MessageBox.Show("Incorrect format. Make sure your timer is in the format 't (h/m)'");
                }
                

            }
            else if ( !startTime.Equals("") ) {
                if ( startTime.Substring(startTime.Length - 2).Equals("PM") ) {
                    start = DateTime.Parse(currentTime.Date + " " + startTime + " AM");
                }
                start = DateTime.Parse(currentTime.Date + " " + startTime + " AM");

                while ( start != currentTime ) {
                    minutes = ( Int32.Parse(currentTime.ToShortTimeString().Substring(3, 2)) - Int32.Parse(start.ToShortTimeString().Substring(3, 2)) );
                    hours = minutes / 60;
                    minutes %= 60;
                    seconds = 0;
                    t.Start();

                }
                
            }


        }

        private void Instructions_Click ( object sender, EventArgs e )
        {

        }

        private void label2_Click_1 ( object sender, EventArgs e )
        {

        }

        private void timer_Tick ( object sender, EventArgs e )
        {
            String hourFormat = "";
            String minuteFormat = "";
            String secondFormat = "";

            if ( hours < 10 )
            {
                hourFormat = "0" + hours;
            }
            else {
                hourFormat = hours.ToString();
            }

            if ( minutes < 10 )
            {
                minuteFormat = "0" + minutes;
            }
            else
            {
                minuteFormat = minutes.ToString();
            }

            if ( seconds < 10 )
            {
                secondFormat = "0" + seconds;
            }
            else
            {
                secondFormat = seconds.ToString();
            }

            timeLeft.Text = ( hourFormat + ":" + minuteFormat + ":" + secondFormat );
            seconds--;
            if ( seconds < 0 )
            {
                if ( minutes == 0 )
                {
                    if ( hours == 0 )
                    {
                        t.Stop();
                    }
                    else {
                        hours--;
                        minutes = 59;
                    }
                }
                else
                {
                    minutes--;
                }
                seconds = 59;
            }
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            t.Stop();
            timeLeft.Text = "00:00:00";
        }
    }
}
