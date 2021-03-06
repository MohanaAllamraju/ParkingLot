using System;
using System.Collections.Generic;


namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * How many 2 wheeler vehicle slots available
             * How many 4 wheeler vehicle slots available
             * How many heavy wheeler vehicle slots available
             */

            /*
            Choose option 
            1. Park vehicle
            2. Unpark vehicle
            3. Print Ticket
            */
            Console.WriteLine("How many Two wheeler solts available");
            int noOfTwoWheelerSlotsAvailable = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many four wheeler solts available");
            int noOfFourWheelerSlotsAvailable = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many heavy vehicle solts available");
            int noOfHeavyWheelerSlotsAvailable = Convert.ToInt32(Console.ReadLine());

            ParkingLot parkingLot = new ParkingLot(noOfTwoWheelerSlotsAvailable,noOfFourWheelerSlotsAvailable,noOfHeavyWheelerSlotsAvailable);
            while (true)
            {
                Console.WriteLine("Choose one option: \n 1.Park Vehicle \n 2.Unpark Vehicle \n 3.Print Ticket");
                int menuOption = Convert.ToInt32(Console.ReadLine());
                switch (menuOption)
                {
                    case 1:
                    Console.WriteLine("Choose your vehicle type : \n 1. Two-Wheeler \n 2. Four-Wheeler \n 3.Heavy-vehicle");
                    String type = Console.ReadLine();
                    Console.WriteLine("Please provide your vehicle number");
                    String vehicleNumber = Console.ReadLine();
                    parkingLot.ParkVehicle((VehicleType)Int32.Parse(type), vehicleNumber);
                    break;

                    case 2:
                    Console.WriteLine("Please enter your ticket number");
                    int ticketNumber = Convert.ToInt32(Console.ReadLine());
                    parkingLot.UnParkVehicle(ticketNumber);
                    break;

                    default:
                    parkingLot.PrintParkingLot();
                    break;
                }

                Console.WriteLine("Press e to exit : ");
                if (Console.ReadLine().Equals("e"))
                {
                    break;
                }
            
            }
        }
    }
}
