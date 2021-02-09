using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Suv : ICompany, IVehicle
    {
        public Suv()
        {
        }

        public string EngineType { get; set; }
        public int Mileage { get; set; }

        //Inherit from ICompany
        public string CompanyName { get; set; }
        public string Slogan { get; set; }

        //Inherit from IVehicle 
        public string VehicleName { get; set; }
        public bool HasSpareTire { get; set; }
        public bool Stereo { get; set; }
        public int NumberOfWheels { get; set; }
        public bool IsAutomatic { get; set; }

        public void EngineNoise()
        {
            Console.WriteLine();
            Console.WriteLine(" This Suv makes no engine noise at all");

        }

    }

}
