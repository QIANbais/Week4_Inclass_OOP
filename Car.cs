using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_Inclass_OOP
{
    class Car : Vehicle  // Car is a child of Vehicle class
    {
        // Private field
        private string _make;
        private string _type;
        private int _model_year;
        private int _number_of_doors;

        public Car()
        {
            _make = "";
            _type = "";
            _model_year = 0;
            _number_of_doors = 0;
        }

        // This is the Make property
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

        // This is the Type property
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

        // This is the Model Property
        public int ModelYear
        {
            get
            {
                return _model_year;
            }
            set
            {
                _model_year = value;
            }
        }

        // This the model Property
        public int NumberOfGears
        {
            get
            {
                return _number_of_doors;
            }
            set
            {
                _number_of_doors = value;
            }
        }
        public void CarDetails(string make, string type, int year, int doors)
        {
            if(doors == 2)
            {
                Console.WriteLine("You got a nice sports car with the make " + make + ", type " + type + ", model year " + year + ", and " + doors + " number of doors.");
            }
            else if(doors > 2)
            {
                Console.WriteLine("You got a car with the make " + make + ", type " + type + ", model year " + year + ", and " + doors + " number of doors.");
            }
            else
            {
                Console.WriteLine("Please enter valid information...");
            }
        }

    }
}
