using System;

namespace Week3_Inclass_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string registration_input;
            string color_input;
            string car_make;
            string car_type;
            string model_year;
            string num_of_doors;
            string bike_make;
            string bike_type;
            string num_of_gears;

            Console.Write("Please enter your vehicle registration number: ");
            registration_input = Console.ReadLine();
            Console.Write("Please enter the color of your vehicle: ");
            color_input = Console.ReadLine();
            Vehicle MyVehicle = new Vehicle();
            MyVehicle.NiceVehicle(float.Parse(registration_input), color_input);

            if (int.Parse(registration_input) >= 10000000)
            {
                Console.Write("What is the make of your car?");
                car_make = Console.ReadLine();
                Console.WriteLine("What is the type pf your car?");
                car_type = Console.ReadLine();
                Console.WriteLine("What is the model year?");
                model_year = Console.ReadLine();
                Console.WriteLine("How mamy number of doors?");
                num_of_doors = Console.ReadLine();
                Car Mycar = new Car();
                Mycar.CarDetails(car_make, car_type, int.Parse(model_year), int.Parse(num_of_doors));
            }
            else if(int.Parse(registration_input) < 10000000)
            {
                Console.Write("What is the make of your bike?");
                bike_make = Console.ReadLine();
                Console.WriteLine("What is the type pf your bike?");
                bike_type = Console.ReadLine();
                Console.WriteLine("How mamy number of gears?");
                num_of_gears = Console.ReadLine();
                Bike Mybike = new Bike();
                Mybike.BikeDetails(bike_make, bike_type, int.Parse(num_of_gears));
            }
            else
            {
                Console.WriteLine("Please enter valid information...");
            }

        }
    }
}
