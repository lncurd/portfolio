/* GRADING ID: W8474
 * Program 2
 * March 8th, 2018
 * CIS 199-01
 * 
 * This program will determine the user's earliest date and time of registration for classes. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Program2 : Form
    {
        public Program2()
        {
            InitializeComponent();
        }

        //Enter button containing calculations
        private void enterButton_Click(object sender, EventArgs e)
        {

            //constants for credit hours
            const int SENIOR_HOUR = 90;
            const int JUNIOR_HOUR = 60;
            const int SOPHOMORE_HOUR = 30;
            
            //constants for dates
            const string DATE_1 = "March 28th";
            const string DATE_2 = "March 29th";
            const string DATE_3 = "March 30th";
            const string DATE_4 = "April 2nd";
            const string DATE_5 = "April 3rd";
            const string DATE_6 = "April 4th";

            //constants for times
            const string TIME_1 = "8:30 a.m.";
            const string TIME_2 = "10:00 a.m.";
            const string TIME_3 = "11:30 a.m.";
            const string TIME_4 = "2:00 p.m.";
            const string TIME_5 = "4:00 p.m.";

            
            uint creditHour = uint.Parse(creditTextBox.Text);//decalres creditHour variable and parses user input
            char lastNameInitial = initialTextBox.Text[0];//declares lastNameInitial variable that will get from user input
            lastNameInitial = char.ToUpper(lastNameInitial);//changes the lastNameInitial to uppercase if needed
            uint.TryParse(creditTextBox.Text, out creditHour);//parses user input to make sure it is non-negative integer
            
              //beginning of if else statement if user is determined to be a senior 
             if (creditHour >= SENIOR_HOUR)
             {
                if (lastNameInitial <= 'D')

                {
                    dateLabel.Text = (DATE_1);
                    timeLabel.Text = (TIME_1);
                }
                else if (lastNameInitial <= 'I')
                {
                    dateLabel.Text = (DATE_1);
                    timeLabel.Text = (TIME_2);
                }
                else if (lastNameInitial <= 'O')
                {
                    dateLabel.Text = (DATE_1);
                    timeLabel.Text = (TIME_3);
                }
                else if (lastNameInitial <= 'S')
                {
                    dateLabel.Text = (DATE_1);
                    timeLabel.Text = (TIME_4);
                }
                else
                {
                    dateLabel.Text = (DATE_1);
                    timeLabel.Text = (TIME_5);
                }
             }

             //beginning of if else statement if user is determined to be a junior
                if (creditHour >= JUNIOR_HOUR && creditHour < SENIOR_HOUR)
                {
                    if (lastNameInitial <= 'D')
                    {
                        dateLabel.Text = (DATE_2);
                        timeLabel.Text = (TIME_1);
                    }
                    else if (lastNameInitial <= 'I')
                    {
                        dateLabel.Text = (DATE_2);
                        timeLabel.Text = (TIME_2);
                    }
                    else if (lastNameInitial <= 'O')
                    {
                        dateLabel.Text = (DATE_2);
                        timeLabel.Text = (TIME_3);
                    }
                    else if (lastNameInitial <= 'S')
                    {
                        dateLabel.Text = (DATE_2);
                        timeLabel.Text = (TIME_4);
                    }
                    else
                    {
                        dateLabel.Text = (DATE_2);
                        timeLabel.Text = (TIME_5);
                    }
                }

            //beginning of if else statement if user is determined to be a sophomore
            if (creditHour >= SOPHOMORE_HOUR && creditHour < JUNIOR_HOUR)
            {
                if (lastNameInitial <= 'B')
                {
                    dateLabel.Text = (DATE_3);
                    timeLabel.Text = (TIME_1);
                }
                else if (lastNameInitial <= 'D')
                {
                    dateLabel.Text = (DATE_3);
                    timeLabel.Text = (TIME_2);
                }
                else if (lastNameInitial <= 'F')
                {
                    dateLabel.Text = (DATE_3);
                    timeLabel.Text = (TIME_3);
                }
                else if (lastNameInitial <= 'I')
                {
                    dateLabel.Text = (DATE_3);
                    timeLabel.Text = (TIME_4);
                }
                else if (lastNameInitial <= 'L')
                {
                    dateLabel.Text = (DATE_3);
                    timeLabel.Text = (TIME_5);
                }
                else if (lastNameInitial <= 'O')
                {
                    dateLabel.Text = (DATE_4);
                    timeLabel.Text = (TIME_1);
                }
                else if (lastNameInitial <= 'Q')
                {
                    dateLabel.Text = (DATE_4);
                    timeLabel.Text = (TIME_2);
                }
                else if (lastNameInitial <= 'S')
                {
                    dateLabel.Text = (DATE_4);
                    timeLabel.Text = (TIME_3);
                }
                else if (lastNameInitial <= 'V')
                {
                    dateLabel.Text = (DATE_4);
                    timeLabel.Text = (TIME_4);
                }
                else
                {
                    dateLabel.Text = (DATE_4);
                    timeLabel.Text = (TIME_5);
                }
            }

            //beginning of if else statement if user is determined to be a freshmen
            if (creditHour < SOPHOMORE_HOUR)
            {
                if (lastNameInitial <= 'B')
                {
                    dateLabel.Text = (DATE_5);
                    timeLabel.Text = (TIME_1);
                }
                else if (lastNameInitial <= 'D')
                {
                    dateLabel.Text = (DATE_5);
                    timeLabel.Text = (TIME_2);
                }
                else if (lastNameInitial <= 'F')
                {
                    dateLabel.Text = (DATE_5);
                    timeLabel.Text = (TIME_3);
                }
                else if (lastNameInitial <= 'I')
                {
                    dateLabel.Text = (DATE_5);
                    timeLabel.Text = (TIME_4);
                }
                else if (lastNameInitial <= 'L')
                {
                    dateLabel.Text = (DATE_5);
                    timeLabel.Text = (TIME_5);
                }
                else if (lastNameInitial <= 'O')
                {
                    dateLabel.Text = (DATE_6);
                    timeLabel.Text = (TIME_1);
                }
                else if (lastNameInitial <= 'Q')
                {
                    dateLabel.Text = (DATE_6);
                    timeLabel.Text = (TIME_2);
                }
                else if (lastNameInitial <= 'S')
                {
                    dateLabel.Text = (DATE_6);
                    timeLabel.Text = (TIME_3);
                }
                else if (lastNameInitial <= 'V')
                {
                    dateLabel.Text = (DATE_6);
                    timeLabel.Text = (TIME_4);
                }
                else
                {
                    dateLabel.Text = (DATE_6);
                    timeLabel.Text = (TIME_5);
                }
            }

        }
        }
}
