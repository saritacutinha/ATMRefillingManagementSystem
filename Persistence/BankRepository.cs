﻿using ATMRefillingManagementSystem.Core;
using ATMRefillingManagementSystem.Core.Models;
using ATMRefillingManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMRefillingManagementSystem.Persistence
{
    public class BankRepository : IBankRepository
    {
        private ATMRefillingManagementSystemDbContext db;

        public BankRepository(ATMRefillingManagementSystemDbContext db)
        {
            this.db = db;
        }
        public List<Bank> GetBankDetails()
        {
            return  db.Banks.ToList();
        }
    }
}
