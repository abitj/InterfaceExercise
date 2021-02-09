using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        
        public string VehicleName { get; set; }
        public bool HasSpareTire { get; set; }
        public bool Stereo { get; set; }
        public int NumberOfWheels { get; set; }
        public bool IsAutomatic { get; set; }
        

    }
}
