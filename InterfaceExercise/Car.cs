using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : ICompany, IVehicle  
    {
        public Car()
        {

        }
        public int NumberOfSeats { get; set; }
        public int NumberOfDoors { get; set; }

        //Inherit from ICompany NumberOfSeats
        public string CompanyName { get; set; }
        public string Slogan { get; set; }

        //Inherit from IVehicle
        public string VehicleName { get; set; }
        public bool HasSpareTire { get; set; }
        public bool Stereo { get; set; }
        public int NumberOfWheels { get; set; }
        public bool IsAutomatic { get; set; }
        


        public void Driveable()
        {
            Console.WriteLine();
            Console.Write("This car is drivable");
        }
    }
}

