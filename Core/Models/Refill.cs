using System;
using System.Collections.Generic;
using System.Text;

namespace ATMRefillingManagementSystem.Core.Models
{
   public class Refill
    {
        public string Key { get { return KeyQualifier + RefillID.ToString(); } }
        public string KeyQualifier { get; set; } 
        public int RefillID { get; set; }
        public int BankID { get; set; }
        public Bank Bank { get; set; }
        public string Area { get; set; }
        public int Amount { get; set; }
        public DateTime RefillDate { get; set; }


    }
}
 