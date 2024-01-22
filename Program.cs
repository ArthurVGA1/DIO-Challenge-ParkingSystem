using System;
using DIO_Challenge_ParkingSystem.Vehicles;
using DIO_Challenge_ParkingSystem.Vehicles.Prices;
class Parking
{    
    static void Main(string[] args)
    {
        Prices prices = new Prices();
        Vehicles vehicles = new Vehicles();

        bool loop = true;
        string option;
        string plate;
        int parkingTime;

        while (loop)
        {
            Console.Clear();
            Console.WriteLine("PARKING SYSTEM:\n1 - Register vehicle.\n2 - Show vehicles.\n3 - Pay vehicle.\n4 - Show price list\n5 - Close.");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Enter your vehicle's license plate:");
                    plate = Console.ReadLine();

                    vehicles.AddVehicle(plate);

                    Console.WriteLine("\n*Press enter to return to the beginning.*");
                    Console.ReadLine();
                    break;

                case "2":
                    Console.Clear();
                    vehicles.ShowVehicles();

                    Console.WriteLine("\n*Press enter to return to the beginning.*");
                    Console.ReadLine();
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("What is the size of your vehicle?\n1 - Small.\n2 - Medium.\n3 - Large.\n");
                    Console.WriteLine("*If you want to go back, press 0*");

                    option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("What is your vehicle's license plate?");
                            plate = Console.ReadLine();

                            vehicles.PayVehicle(plate);
                            
                            Console.WriteLine("How long were you parked?");
                            parkingTime = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine($"Pay: ${prices.PriceCalculation(Prices.VehiclesStartingPrice.smallVehicles, parkingTime)}");

                            Console.WriteLine("\n*Press enter to return to the beginning.*");
                            Console.ReadLine();
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("What is your vehicle's license plate?");
                            plate = Console.ReadLine();

                            vehicles.PayVehicle(plate);

                            Console.WriteLine("How long were you parked?");
                            parkingTime = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine($"Pay: ${prices.PriceCalculation(Prices.VehiclesStartingPrice.mediumVehicles, parkingTime)}");

                            Console.WriteLine("\n*Press enter to return to the beginning.*");
                            Console.ReadLine();
                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine("What is your vehicle's license plate?");
                            plate = Console.ReadLine();

                            vehicles.PayVehicle(plate);

                            Console.WriteLine("How long were you parked?");
                            parkingTime = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine($"Pay: ${prices.PriceCalculation(Prices.VehiclesStartingPrice.largeVehicles, parkingTime)}");

                            Console.WriteLine("\n*Press enter to return to the beginning.*");
                            Console.ReadLine();
                            break;

                        case "0":
                            loop = true;
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid option");

                            Console.WriteLine("\n*Press enter to return to the beginning.*");
                            Console.ReadLine();
                            break;
                    }
                    break;

                case "4":
                    Console.Clear();
                    prices.PriceList();

                    Console.WriteLine("\n*Press enter to return to the beginning.*");
                    Console.ReadLine();
                    break;


                case "5":
                    loop = false;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid option");

                    Console.WriteLine("\n*Press enter to return to the beginning.*");
                    Console.ReadLine();
                    break;
            }
        }
    }
}