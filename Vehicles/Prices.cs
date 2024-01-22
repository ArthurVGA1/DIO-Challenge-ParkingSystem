using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_Challenge_ParkingSystem.Vehicles.Prices
{
    public class Prices
    {        
        public enum VehiclesStartingPrice
        {
            smallVehicles = 3,
            mediumVehicles = 5,
            largeVehicles = 7
        }

        public void PriceList()
        {
            Console.WriteLine($"PRICE LIST\n\nStarting Price:\nSmall vehicles: $3.\nMedium vehicles: $5.\nLarge vehicles: $7.");
            Console.WriteLine("\nPrice per hour: $2.");
        }

        public int PriceCalculation(VehiclesStartingPrice vehicleType, int parkingTime)
        {
            int pricePerHour = 2;
            int initialPrice = (int)vehicleType;
            int finalPrice = parkingTime * pricePerHour + initialPrice;

            return finalPrice;
        }
    }
}
