/* Grading ID: W8474
 * Progam 3
 * April 3rd, 2018
 * CIS 199-01
 * 
 * The purpose of this program is to determine the earliest time and date of
 * registration, this particular program uses parallel arrays and range
 * matching. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        // Find and display earliest registration time
        private void findRegTimeBtn_Click(object sender, EventArgs e)
        {
            const string DAY1 = "March 28"; // 1st day of registration
            const string DAY2 = "March 29"; // 2nd day of registration
            const string DAY3 = "March 30"; // 3rd day of registration
            const string DAY4 = "April 2";  // 4th day of registration
            const string DAY5 = "April 3";  // 5th day of registration
            const string DAY6 = "April 4";  // 6th day of registration

            const float SOPHOMORE = 30; // Hours needed to be sophomore
            const float JUNIOR = 60;    // Hours needed to be junior
            const float SENIOR = 90;    // Hours needed to be senior

            string lastNameStr;         // Entered last name
            char lastNameLetterCh;      // First letter of last name, as char
            string dateStr = "Error";   // Holds date of registration
            string timeStr = "Error";   // Holds time of registration
            float creditHours;          // Previously earned credit hours
            bool isUpperClass;          // Upperclass or not?

            

            lastNameStr = lastNameTxt.Text;
            if (lastNameStr.Length > 0) // Empty string?
            {
                lastNameLetterCh = lastNameStr[0];   // First char of last name
                lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                if (float.TryParse(creditHoursTxt.Text, out creditHours) && creditHours >= 0)
                {
                    if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                    {
                        isUpperClass = (creditHours >= JUNIOR);

                        // Juniors and Seniors share same schedule but different days
                        if (isUpperClass)
                        {
                            if (creditHours >= SENIOR)
                                dateStr = DAY1;
                            else // Must be juniors
                                dateStr = DAY2;

                            char[] lastNamesLimits = { 'A', 'E', 'J','P', 'T' };//last name lower range limits array
                            string[] times = { "8:30 AM", "10:00 AM", "11:30 AM", "2:00 PM", "4:00 PM" };//times array
                            int index = lastNamesLimits.Length - 1;//index variable used to determine arryays length & to stay within bound of array

                            //while loop that will determine and output the time of registration 
                            while (index >= 0 && lastNameLetterCh < lastNamesLimits[index])
                                --index;
                            timeStr = times[index];
                            dateTimeLbl.Text = timeStr;
                        }
                        // Sophomores and Freshmen
                        else // Must be soph/fresh
                        {
                            if (creditHours >= SOPHOMORE)
                            {
                                // A-L on day one
                                if ((lastNameLetterCh <= 'L'))   // <= L
                                    dateStr = DAY3;
                                else // All other letters on next day
                                    dateStr = DAY4;
                            }
                            else // must be freshman
                            {
                                // A-L on day one
                                if ((lastNameLetterCh <= 'L'))   // <= L
                                    dateStr = DAY5;
                                else // All other letters on next day
                                    dateStr = DAY6;
                            }


                            char[] lastNamesLimits = { 'A', 'C', 'E', 'G', 'J', 'M', 'P', 'R', 'T', 'W' };//last name lower range limits array
                            string[] times = { "8:30 AM", "10:00 AM", "11:30 AM", "2:00 PM", "4:00 PM",
                                "8:30 AM", "10:00 AM", "11:30 AM", "2:00 PM", "4:00 PM" };//times array
                            int index = lastNamesLimits.Length - 1;//index variable used to determine arryays length & to stay within bound of array

                            //while loop that will determine and output the time of registration
                            while (index >= 0 && lastNameLetterCh < lastNamesLimits[index])
                                --index;
                            timeStr = times[index];
                            dateTimeLbl.Text = timeStr;

                        }

                        // Output results
                        dateTimeLbl.Text = dateStr + " at " + timeStr;
                    }
                    else // Not A-Z
                        MessageBox.Show("Make sure last name starts with a letter!");
                }
                else
                    MessageBox.Show("Enter a valid number of credit hours!");
            }
            else // Empty textbox
                MessageBox.Show("Please enter last name!");
        }
    }
}
