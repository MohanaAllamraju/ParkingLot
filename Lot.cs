using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
     public class Lot
     {
        public int LotID;
        public string LotType;
        public bool LotStatus;

        public Ticket Ticket;
        


       public Lot(int lotID, string lotType,bool lotStatus)
       {
            this.LotID = lotID;
            this.LotType = lotType;
            this.LotStatus = lotStatus;
       }



     }
}
