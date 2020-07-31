using ATMRefillingManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ATMRefillingManagementSystem.Core
{
    public interface IBankRepository
    {
      
            Task<List<Bank>> GetBankDetailsAsync();
      
    }
}
