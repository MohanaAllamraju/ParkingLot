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
                String Mode = Console.ReadLine();
                if (Mode == "1")
                {
                    Console.WriteLine("Choose your vehicle type : \n 1. Two-Wheeler \n 2. Four-Wheeler \n 3.Heavy-vehicle");
                    String type = Console.ReadLine();
                    Console.WriteLine("Please provide your vehicle number");
                    String vehicleNumber = Console.ReadLine();
                    if (type == "1")
                    {
                        int TicketID =parkingLot.GenerteID();
                        parkingLot.ParkVehicle("Two-wheeler" , vehicleNumber);
                        Console.WriteLine("Your Ticket ID is : " + TicketID);
                    }
                    else if (type == "2")
                    {   
                        parkingLot.ParkVehicle("Four-wheeler", vehicleNumber);
                    }
                    else if (type == "3")
                    {
                        parkingLot.ParkVehicle("Heavy-vehicle" , vehicleNumber);
                    }
                }
                else if(Mode == "2")
                {
                    Console.WriteLine("Choose your vehicle type : \n 1. Two-Wheeler \n 2. Four-Wheeler \n 3.Heavy-vehicle");
                    String type = Console.ReadLine();
                    if(type =="1")
                    {
                        parkingLot.UnParkVehicle("Two-Wheeler");
                    }
                    else if(type == "2")
                    {
                        parkingLot.UnParkVehicle("Four-Wheeler");
                    }
                    else if(type == "3")
                    {
                        parkingLot.UnParkVehicle("Heavy-Vehicle");
                    }

                }
                else if (Mode == "3")
                {
                    parkingLot.PrintParkingLot();
                }

                Console.WriteLine("Press e to continue : ");
                if (Console.ReadLine().Equals("e"))
                {
                    break;
                }
            }
        }
    }
}
