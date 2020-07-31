using ATMRefillingManagementSystem.Core;
using ATMRefillingManagementSystem.Core.Models;
using ATMRefillingManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        public async Task<List<Bank>> GetBankDetailsAsync()
        {
            return await db.Banks.ToListAsync();
        }
    }
}
