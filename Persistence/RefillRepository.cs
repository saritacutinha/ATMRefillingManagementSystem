using ATMRefillingManagementSystem.Core;
using ATMRefillingManagementSystem.Core.Models;
using ATMRefillingManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMRefillingManagementSystem.Persistence
{
   public  class RefillRepository :IRefillRepository
    {
        private ATMRefillingManagementSystemDbContext db;

        public RefillRepository(ATMRefillingManagementSystemDbContext db)
        {
            this.db = db;
        }

        public string AddRefillRecord(Refill refillRecord)
        {
            db.Refills.Add(refillRecord);
            db.SaveChanges();
            return refillRecord.Key;

        }
    }
}
