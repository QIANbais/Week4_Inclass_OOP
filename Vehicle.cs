using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_Inclass_OOP
{
    class Vehicle
    {
        // Declare fields to represent registration_number and color
        private float regristration_number;
        private string color;

        // Constructor
        public Vehicle()
        {
            regristration_number = 00000000;
            color = "";
        }

        public void NiceVehicle(float registrationnumber, string color)
        {
            if(registrationnumber < 10000000)
            {
                Console.WriteLine("Nice " + color + " bike!");
            }
            else if(registrationnumber >= 10000000)
            {
                Console.WriteLine("Nice " + color + " car!");
            }
            else
            {
                Console.WriteLine("Please enter valid inputs...");
            }
        }
    }

}
