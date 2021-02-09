using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : ICompany, IVehicle
    {
        public Truck()
        { 
        }

        public bool HasTruckBed { get; set; }
        public bool HasFourWheelsDrive { get; set; }

        //Inherit from ICompany
        public string CompanyName { get; set; }
        public string Slogan { get; set; }

        //Inherit from IVehicle
        public string VehicleName { get; set; }
        public bool HasSpareTire { get; set; }
        public bool Stereo { get; set; }
        public int NumberOfWheels { get; set; }
        public bool IsAutomatic { get; set; }

        public void TalkWireless ()
        {
            Console.WriteLine();
            Console.WriteLine("You can answer your phone and talk wirelessly");
        }
    }
}




