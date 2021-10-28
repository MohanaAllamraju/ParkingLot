using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    public class Ticket
    {
        public int SlotID;
        public string VehicleNumber;
        public DateTime EntryTime;
        public DateTime ExitTime;

        public Ticket(int slotId, string vehicleNumber, DateTime time)
        {
            this.SlotID = slotId;
            this.VehicleNumber = vehicleNumber;
            this.EntryTime = time;
        }
        public void GenerateID()
        {

        }
    }
}
