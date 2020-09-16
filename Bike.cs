using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_Inclass_OOP
{
    class Bike : Vehicle
    {
        // private fields
        private string _make;
        private string _type;
        private int _number_of_gears;

        public Bike()
        {
            _make = "";
            _type = "";
            _number_of_gears = 0;
        }

        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        public int NumberOfGears
        {
            get
            {
                return _number_of_gears;
            }
            set
            {
                _number_of_gears = value;
            }
        }
        public void BikeDetails(string make, string type, int gears)
        {
            if (gears == 2)
            {
                Console.WriteLine("You got a regular bike with the make of " + make + ", type of " + type);
            }
            else if (gears > 2)
            {
                Console.WriteLine("You got a special bike with " + gears + " gears and with the make of " + make + " and the type of " + type);
               
            }
            else
            {
                Console.WriteLine("Please enter valid information...");
            }
        }
    }
}
