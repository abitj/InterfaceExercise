using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create 2 Interfaces called IVehicle & ICompany --DONE
            //Create 3 classes called Car , Truck , & SUV --DONE

            //In your IVehicle --DONE
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */

            //In ICompany --DONE
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 */

            //In each of your car, truck, and suv classes --DONE
                /*Create 2 members that are specific to each class
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 *Create objects of your 3 classes and give their members values
                 *Creatively display and organize their values
                 */

            var vehicle = new List<IVehicle>();

            // Objects for Car 
            var camry = new Car();
            camry.VehicleName = "Toyota Camry";
            camry.CompanyName = "Toyota";
            camry.Slogan = "Let's us go places";
            camry.NumberOfSeats = 5;
            camry.NumberOfDoors = 4;
            camry.HasSpareTire = true;
            camry.Stereo = false;
            camry.NumberOfWheels = 4;
            camry.IsAutomatic = true;

            vehicle.Add(camry);

            // Objects for Truck
            var tanker = new Truck();
            tanker.VehicleName = "Bulkheads";
            tanker.CompanyName = "Safe Rack";
            tanker.Slogan = "Orange. Safety has color";
            tanker.HasTruckBed = true;
            tanker.HasFourWheelsDrive = true;
            tanker.HasSpareTire = true;
            tanker.Stereo = true;
            tanker.NumberOfWheels = 20;
            tanker.IsAutomatic = true;
        
            vehicle.Add(tanker);
            

            // Objects for SUV
            var suv = new Suv();
            suv.VehicleName = "Jeep Wrangler Unlimited";
            suv.CompanyName = "Jeep";
            suv.Slogan = "Go Anywhere. Do Anything.";
            suv.EngineType = "Electrical Engine";
            suv.Mileage = 666;
            suv.HasSpareTire = true;
            suv.Stereo = true;
            suv.IsAutomatic = true;
            suv.NumberOfWheels = 4;

            vehicle.Add(suv);

            foreach (var veh in vehicle) 
            { 
                Console.WriteLine();
                Console.WriteLine($"{veh.VehicleName} has {veh.NumberOfWheels} wheels. Is automatic? {veh.IsAutomatic}. Has spare tire? {veh.HasSpareTire}. What about stereo? {veh.Stereo}. ");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");


            }
        }
    }
}
