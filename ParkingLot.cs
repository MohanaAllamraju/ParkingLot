﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp7
{
    class ParkingLot
    {
        List<Lot> Lots = new List<Lot>();
        int NoOfTwoWheelerSlotsAvailable;
        int NoOfFourWheelerSlotsAvailable;
        int NoOfHeavyWheelerSlotsAvailable;
        String VehicleNumber;
        int TicketID = 1;
        int LotId = 1;

        public ParkingLot(int noOfTwoWheelerSlotsAvailable, int noOfFourWheelerSlotsAvailable, int noOfHeavyWheelerSlotsAvailable)
        {
            this.NoOfTwoWheelerSlotsAvailable = noOfTwoWheelerSlotsAvailable;
            this.NoOfFourWheelerSlotsAvailable = noOfFourWheelerSlotsAvailable;
            this.NoOfHeavyWheelerSlotsAvailable = noOfHeavyWheelerSlotsAvailable;
            for(int i = 0; i< noOfTwoWheelerSlotsAvailable; i++)
            {
                this.Lots.Add(new Lot(LotId++, "Two-wheeler", false));
            }
            for(int i=0; i<noOfFourWheelerSlotsAvailable; i++)
            {
                this.Lots.Add(new Lot(LotId++, "Four-wheeler", false));
            }
            for (int i= 0; i<noOfHeavyWheelerSlotsAvailable; i++)
            {
                this.Lots.Add(new Lot(LotId++, "Heavy-Vehicle", false));
            }
            
        }
               
        public void ParkVehicle(string type, string vehicleNumber)
        {
             if(type.Equals("Two-wheeler" , StringComparison.CurrentCultureIgnoreCase))
             {
                var freeSlot = this.Lots.Find(e => e.LotType.Equals(type, StringComparison.CurrentCultureIgnoreCase) && e.LotStatus == false);
                if(freeSlot == null)
                {
                    Console.WriteLine("Two wheeler parking lot is full.");
                    return;
                }

                freeSlot.LotStatus = true;
                this.VehicleNumber = vehicleNumber;
             }

             else if(type.Equals("Four-wheeler" ,StringComparison.CurrentCultureIgnoreCase))
             {
                var freeSlot = this.Lots.Find(e => e.LotType.Equals(type, StringComparison.CurrentCultureIgnoreCase) && e.LotStatus == false);
                if(freeSlot== null)
                {
                    Console.WriteLine("Four wheeler parking lot is full.");
                    return;
                }

                freeSlot.LotStatus = true;

             }
             else if(type.Equals("Heavy-vehicle" , StringComparison.CurrentCultureIgnoreCase))
             {
                var freeSlot = this.Lots.Find(e => e.LotType.Equals(type , StringComparison.CurrentCultureIgnoreCase) && e.LotStatus == false);
                if(freeSlot == null)
                {
                    Console.WriteLine("Heavy Vehicle parking lot is full");
                    return;
                }

                freeSlot.LotStatus = true;

             }
        }
        public void UnParkVehicle(string type)
        {
            if (type.Equals("Two-wheeler", StringComparison.CurrentCultureIgnoreCase))
            {
                var AvailableSlot = this.Lots.Find(e => e.LotType.Equals(type, StringComparison.CurrentCultureIgnoreCase) && e.LotStatus == true);
                if (AvailableSlot == null)
                {
                    Console.WriteLine("Parking lot is empty");
                    return;
                }

                AvailableSlot.LotStatus = false;
            }
            else if(type.Equals("Four-wheeler" , StringComparison.CurrentCultureIgnoreCase))
            {
                var AvailableSlot = this.Lots.Find(e => e.LotType.Equals(type, StringComparison.CurrentCultureIgnoreCase) && e.LotStatus == true);
                if(AvailableSlot == null)
                {
                    Console.WriteLine("Parking lot is empty");
                    return;
                }
                AvailableSlot.LotStatus = false;
            }
            else if(type.Equals("Heavy-Vehicle", StringComparison.CurrentCultureIgnoreCase))
            {
                var AvailableSlot = this.Lots.Find(e => e.LotType.Equals(type, StringComparison.CurrentCultureIgnoreCase) && e.LotStatus == true);
                if(AvailableSlot == null)
                {
                    Console.WriteLine("Parking lot is empty");
                }
                AvailableSlot.LotStatus = false;
            }
        }
        public void PrintParkingLot()
        {
            foreach(var lot in this.Lots.Where(e => e.LotStatus))
            {
                Console.WriteLine($"{lot.LotType} {VehicleNumber} is parked in {lot.LotID}");
            }
        }

        public int GenerteID()
        {
            return TicketID++;
        }
    }
}
