using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
     public class Slot
     {
        public int Id;
        public VehicleType VehicleType;
        public bool LotStatus;
        public Ticket Ticket;

        public Slot(int id, VehicleType vehicleType,bool lotStatus)
        {
            this.Id = id;
            this.VehicleType = vehicleType;
            this.LotStatus = lotStatus;
        }
        
     }
}
