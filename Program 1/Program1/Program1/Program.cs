/* Grading ID: W8474
   Program 1
   February 13th, 2018
   CIS 199-01

   This program will allow a user to calculate the appropriate amount of gallons
   of paint needed to paint the walls of the desired room
  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthWall; //variable for wall length
            double heightWall; //variable for wall height
            int doors; //doors variable
            int windows; //windows variable
            int coats; //number of coats variable
            double costPerGallon; //variable for cost per gallon


            /*Displays message across screen that will direct the user to input the length of walls,
              height of walls, number of doors, number of windows, number of coats of paint,
              and finally the cost per gallon of paint. The user's input will be converted into
              doubles or integers, depending on the variable. */
            WriteLine("Welcome to the Handy-Dandy Paint Estimator");
            WriteLine();
            WriteLine();
            Write("Enter the total length of all walls (in feet): ");
            lengthWall = double.Parse(ReadLine());
            Write("Enter the height of all walls (in feet): ");
            heightWall = double.Parse(ReadLine());
            Write("Enter the number of doors (non-neg int): ");
            doors = int.Parse(ReadLine());
            Write("Enter the number of windows (non-neg int): ");
            windows = int.Parse(ReadLine());
            Write("Enter the number of coats of paint (non-neg int): ");
            coats = int.Parse(ReadLine());
            Write("Enter the cost per gallon of paint (in $): ");
            costPerGallon = double.Parse(ReadLine());
            WriteLine();
            WriteLine();



            double wallSquarefeet = lengthWall * heightWall; //calculation for the total wall square feet

            const int DOORS_SUBTRACTION = 20; //constant for door calculation
            double sumSquarefeet = (wallSquarefeet - (DOORS_SUBTRACTION * doors)); //calculates total square feet minus doors

            const int WINDOWS_SUBTRACTION = 15; //constant for windows calculation
            sumSquarefeet = (sumSquarefeet - (WINDOWS_SUBTRACTION * windows)); //calculates total sqaure feet minus windows


            sumSquarefeet = sumSquarefeet * coats; //calculates total square feet times the number of coats

            const int COATS_DIVISION = 375; //constant for # of coats calculation
            double minGallons = sumSquarefeet / COATS_DIVISION; //calculates the minimum amount of gallons needed

            double gallonsToBuy = (int)Math.Ceiling(minGallons); //calculates the gallons needed to buy by casting to integer
            double priceOfGallons = gallonsToBuy * costPerGallon; //calculates price of gallons

            /*Displays output across screen */
            WriteLine($"You need a minimum of {minGallons:F1} gallons to paint.");
            WriteLine($"You'll need to buy {gallonsToBuy} gallons, though,");
            WriteLine($"at a price of {priceOfGallons:C2}.");
           

        }
    }
}
