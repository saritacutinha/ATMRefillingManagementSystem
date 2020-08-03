using ATMRefillingManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMRefillingManagementSystem.Core
{
    public interface IRefillRepository
    {
        public string AddRefillRecord(Refill refillRecord);
    }
}
