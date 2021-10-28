using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp7
{
    class ParkingLot
    {
        List<Slot> Lots = new List<Slot>();

        int NoOfTwoWheelerSlotsAvailable;
        int NoOfFourWheelerSlotsAvailable;
        int NoOfHeavyWheelerSlotsAvailable;
        int SlotId = 1;

        public ParkingLot(int noOfTwoWheelerSlotsAvailable, int noOfFourWheelerSlotsAvailable, int noOfHeavyWheelerSlotsAvailable)
        {
            this.NoOfTwoWheelerSlotsAvailable = noOfTwoWheelerSlotsAvailable;
            this.NoOfFourWheelerSlotsAvailable = noOfFourWheelerSlotsAvailable;
            this.NoOfHeavyWheelerSlotsAvailable = noOfHeavyWheelerSlotsAvailable;
            for(int i = 0; i< noOfTwoWheelerSlotsAvailable; i++)
            {
                this.Lots.Add(new Slot(SlotId++, VehicleType.TwoWheeler, false));
            }
            for(int i=0; i<noOfFourWheelerSlotsAvailable; i++)
            {
                this.Lots.Add(new Slot(SlotId++,VehicleType.FourWheeler, false));
            }
            for (int i= 0; i<noOfHeavyWheelerSlotsAvailable; i++)
            {
                this.Lots.Add(new Slot(SlotId++, VehicleType.HeavyVehicle, false));
            }
        }    
        
        public void ParkVehicle(VehicleType vehicleType, string vehicleNumber)
        {
                var freeSlot = this.Lots.Find(e => e.VehicleType == vehicleType && e.LotStatus == false);
                if(freeSlot == null)
                {
                    Console.WriteLine("Two wheeler parking lot is full.");
                    return;
                }
                freeSlot.LotStatus = true;
                freeSlot.Ticket = new Ticket(freeSlot.Id, vehicleNumber, DateTime.Now);
                Console.WriteLine("Your vehicle is parked and your ticket ID is :" + freeSlot.Ticket.SlotID);
        }

        public void UnParkVehicle(int ticketNumber)
        {
                var AvailableSlot = this.Lots.Find(lot => lot.LotStatus == true && lot.Ticket.SlotID == ticketNumber);
                if (AvailableSlot == null)
                {
                    Console.WriteLine("Parking lot is empty");
                    return;
                }

                AvailableSlot.LotStatus = false;
                AvailableSlot.Ticket.ExitTime = DateTime.Now;
        }

        public void PrintParkingLot()
        {
            foreach(var lot in this.Lots.Where(e => e.Ticket != null))
            {
                Console.WriteLine($" {lot.Id} \t {lot.Ticket?.VehicleNumber} \t {lot.Ticket?.EntryTime} \t {lot.Ticket?.ExitTime} \t {lot.LotStatus}");
            }
        }

    }
}
