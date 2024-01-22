using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_Challenge_ParkingSystem.Vehicles
{
    public class Vehicles
    {
        List<string> vehicles = new List<string>();

        public void AddVehicle(string vehicle)
        {
            string plate  = vehicle.ToUpper();
            vehicles.Add(plate);
        }

        public void ShowVehicles()
        {
            Console.WriteLine("Parked vehicles:");
            foreach (string vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }

        public void PayVehicle(string vehicle) 
        {
            string plate = vehicle.ToUpper();
            bool vehicleExists = vehicles.Contains(plate);

            if (vehicleExists)
            {
                vehicles.Remove(plate);
            }
            else
            {
                Console.WriteLine("Vehicle not found.");
            }
            
        }
    }
}
