/*Grading ID:
 *Program 4
 *April 24th, 2018
 * 
 * This program will use the idea of classes and objects in order to display and change information.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_4
{
    class Program
    {
        static void Main(string[] args)
        {   
            //GroundPackage objects 
            GroundPackage nordstrom = new GroundPackage(30231, 23111, 3.0, 2.3, 5.6, 4.0);
            GroundPackage jcpenny = new GroundPackage(49732, 10009, 4.0, 3.2, 6.5, 4.3);
            GroundPackage marshalls = new GroundPackage(35416, 12143, 5.0, 2.3, 5.6, 4.4);
            GroundPackage payless = new GroundPackage(74878, 29332, 6.0, 3.2, 6.5, 4.5);
            GroundPackage target = new GroundPackage(58832, 19209, 7.0, 2.3, 5.6, 4.6);

            //packages array
            GroundPackage[] packages = new GroundPackage[] { nordstrom, jcpenny, marshalls, payless, target };
            DisplayPackages(packages);//displays packages array

            //GroundPackage new properties
            nordstrom.Weight = 4.6;
            jcpenny.Height = 2.2;
            marshalls.Length = 5.0;
            payless.OriginZip = 45231;
            target.DestinationZip = 21421;

            DisplayPackages(packages);//displays packages array

        }

        //DisplayPackages method
        //pre condition: the user must have input for boxes array
        //post condition: will display the packages
        public static void DisplayPackages(GroundPackage[] boxes)
        {
            for (int i = 0; i < boxes.Length; i++)
            {

                WriteLine(boxes[i].ToString());
                WriteLine($"Cost: {boxes[i].CalcCost():C}");
                WriteLine($"{Environment.NewLine}");
            }
        }
    }
}
    



