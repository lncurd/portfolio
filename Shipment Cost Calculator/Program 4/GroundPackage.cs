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
    //GroundPackage class
    public class GroundPackage
    {
        //backing fields for GroundPackage Class
        private int _originZip;
        private int _destinationZip;
        private double _length;
        private double _width;
        private double _height;
        private double _weight;

        //constants for origin zip and destination zip properties 
        const int DEFAULT_ZIP = 40202;
        const int DEST_ZIP = 90210;
        const int MIN_ZIP = 00000;
        const int MAX_ZIP = 99999;

        //OriginZip property
        public int OriginZip
        {
            get
            {
                return _originZip;
            }
            set
            {
                if (value >= MIN_ZIP && value <= MAX_ZIP)//determines origin zipcode
                {
                    _originZip = value;
                }
                else
                    _originZip = DEFAULT_ZIP;
            }
        }

        //DestinationZip property
        public int DestinationZip
        {
            get
            {
                return _destinationZip;
            }
            set
            {
                if (value >= MIN_ZIP && value <= MAX_ZIP)//determines destination zip code
                {
                    _destinationZip = value;
                }
                else
                    _destinationZip = DEST_ZIP;
            }
        }

        //constants for dimensions of Length, Width, Height, and Weight
        const double MIN_DIM = 0;
        const double DEFAULT_DIM = 1.0;

        //Length property
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > MIN_DIM)//determines length dimension
                {
                    _length = value;
                }
                else
                    _length = DEFAULT_DIM;
            }
        }

        //Width property
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > MIN_DIM)//determines width dimension
                {
                    _width = value;
                }
                else
                    _width = DEFAULT_DIM;
            }
        }

        //Height property 
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > MIN_DIM)//determines height dimension
                {
                    _height = value;
                }
                else
                    _height = DEFAULT_DIM;
            }
        }

        //Weight property 
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > MIN_DIM)//determines weight dimension
                {
                    _weight = value;
                }
                else
                    _weight = DEFAULT_DIM;
            }
        }

        //constants for Zone Distance 
        const int ZONE_NUM = 10000;
        const int DIFF_NUM = 0;

        //Zone Distance property 
        public int ZoneDistance
        {
            get
            {
                int difference = _originZip / ZONE_NUM - _destinationZip / ZONE_NUM;//calculates zone distance
                if (difference < DIFF_NUM)//determines zone distance if statement
                {
                    return -difference;
                }
                else
                {
                    return difference;
                }

            }
        }

        //GroundPackage Constructer with parameters
        public GroundPackage(int originZip, int destZip, double length,
                             double width, double height, double weight)
        {
            OriginZip = originZip;
            DestinationZip = destZip;
            Length = length;
            Width = width;
            Height = height;
            Weight = weight;

        }

        //constants used in cost variable 
        const double PACK_SIZE = .20;
        const double PACK_DIST = .5;

        //Calculation Cost method 
        //precondition: none
        //post condition: Returns the cost of the package 
        public double CalcCost()
        {
            double cost;
            cost = PACK_SIZE * (Length + Width + Height) + PACK_DIST * (ZoneDistance + 1) * Weight;
            return cost;
        }

        //ToString() Method 
        //pre condition: none
        //post condition: outputs the origin zip code, destination zip cpde, length, width, height, weight, and zone distance.
        public override string ToString()
        {
            return $"Origin Zip: {OriginZip}" +
                $"{Environment.NewLine} Destination Zip: {DestinationZip}" +
                $"{Environment.NewLine} Length: {Length}" +
                $"{Environment.NewLine} Width: {Width}" +
                $"{Environment.NewLine} Height: {Height}" +
                $"{Environment.NewLine} Weight: {Weight}" +
                $"{Environment.NewLine} Zone Distance: {ZoneDistance}";
        }
    }
}