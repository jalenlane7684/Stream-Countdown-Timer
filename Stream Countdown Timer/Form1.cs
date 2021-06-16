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
using System.IO;


namespace Stream_Countdown_Timer
{
    public partial class StreamCountdownTimer : Form
    {
        int hours;
        int minutes;
        int seconds;
        DateTime currentTime;
        DateTime start;
        DateTime currentYear = DateTime.Now;
        String path;

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
            String timer = SetTimerText.Text;
            String startTime = SetStartTimeText.Text;
            path = "C:\\Users\\" + userText.Text + "\\Desktop\\StreamTimer.txt";

            if ( userText.Text.Equals("") )
            {
                MessageBox.Show("You must input your username.");
            }
            else {


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
                    } else if (timer.Contains(":"))
                    {
                        String[] timeNumbers = timer.Split(':');
                        try
                        {
                            hours = Int32.Parse(timeNumbers[0]);
                            minutes = Int32.Parse(timeNumbers[1]);
                            seconds = Int32.Parse(timeNumbers[2]);
                            if (seconds >= 60)
                            {
                                minutes = seconds / 60;
                                seconds %= 60;
                            }
                            if ( minutes >= 60 )
                            {
                                hours += minutes / 60;
                                minutes %= 60;
                            }
                            t.Start();
                            File.WriteAllText(path, timeLeft.Text);


                        } catch
                        {
                            MessageBox.Show("Incorrect format. Please make sure your timer is in the format 't (h/m)' or 'hh:mm:ss'");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect format. Make sure your timer is in the format 't (h/m)' or 'hh:mm:ss'");
                    }


                }
                else if ( !startTime.Equals("") )
                {
                    if ( SetStartTimeText.Text.Length < 12 || !SetStartTimeText.Text.Contains(':') || SetStartTimeText.Text.Length > 14 )
                    {
                        MessageBox.Show("Incorrect format. Please make sure your format is the same as described above.");
                    }
                    else 
                    {
                        currentTime = DateTime.Now;
                        String[] timeDigits = SetStartTimeText.Text.Split(':');
                        if ( timeDigits.Length > 4 ) 
                        {
                            MessageBox.Show("Incorrect format. When trying to find each part of the time, there was an error.");
                        } else
                        {
                            int startHour = Int32.Parse(timeDigits[0]);
                            int startMinute = Int32.Parse(timeDigits[1]);
                            int startSecond = Int32.Parse(timeDigits[2]);
                            String when = timeDigits[3];
                            start = new DateTime(currentYear.Year, currentYear.Month, currentYear.Day, startHour, startMinute, startSecond);

                            if ( DateTime.Compare(currentTime, start) >= 0 && when.Equals("today"))
                            {
                                MessageBox.Show("You cannot input a time that is earlier than the current time.");
                            } else
                            {
                                if ( when.Equals("tom") )
                                {
                                    hours = start.Hour - currentTime.Hour + 24;
                                } else
                                {
                                    hours = start.Hour - currentTime.Hour;
                                }
                                minutes = start.Minute - currentTime.Minute;
                                if (minutes < 0)
                                {
                                    hours--;
                                    minutes = 59 + (start.Minute - currentTime.Minute);
                                }
                                seconds = start.Second - currentTime.Second;
                                if ( seconds < 0 )
                                {
                                    minutes--;
                                    seconds = 59 + ( start.Second - currentTime.Second );
                                }
                                t.Start();
                            }
                        }
                    }

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

            if ( hours == 0 && minutes == 0 && seconds == 0 )
            {
                t.Stop();
            }

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

            File.WriteAllText(path, timeLeft.Text);
        }

        private void button2_Click ( object sender, EventArgs e )
        {

            if ( userText.Text.Equals("") )
            {
                MessageBox.Show("You must input your username.");
            } else
            {
                path = "C:\\Users\\" + userText.Text + "\\Desktop\\StreamTimer.txt";
                hours = 0;
                minutes = 0;
                seconds = 0;
            }
        }

        private void textBox1_TextChanged ( object sender, EventArgs e )
        {

        }

        private void label1_Click_1 ( object sender, EventArgs e )
        {

        }

        private void howToUseBut_Click ( object sender, EventArgs e )
        {
            MessageBox.Show(howToString());
        }

        private String howToString()
        {
            StringBuilder howTo = new StringBuilder();
            howTo.AppendLine("Set timer allows you to set a timer for when you want your stream to start.\nFormats:");
            howTo.AppendLine("t(h / m) or hh:mm: ss\nt means time number (hours or minutes)\nh means hours, m means minutes, and s means seconds");
            howTo.AppendLine("");
            howTo.AppendLine("Specific time allows you to set a specific time you want the timer to go off.");
            howTo.AppendLine("Format: hh:mm:ss\nMake sure you use military time\nAfter ss, type :today to set a time for the current date, and :tom for a time for the next day.");
            howTo.AppendLine("\nYou cannot set a specific time for a time that has already passed (same day).");
            howTo.AppendLine("\nAdditionally, the application needs your computer username so that it can create a text file on your desktop that will be updated with the timer.");
            howTo.AppendLine("Add the text file onto your OBS or Streamlabs stream scene, and the text will update with the timer.");

            return howTo.ToString();
        }
    }
}

//Formats
//Timer: t(h / m) or hh:mm: ss
//Specific Time: hh: mm: ss(Military Time)
//Note: For specific time, type: today if the time is for the current date, and :tom if it's for tomorrow.
