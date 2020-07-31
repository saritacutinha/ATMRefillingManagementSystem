using ATMRefillingManagementSystem.Core;
using System;
using System.Threading.Tasks;

namespace ATMRefillingManagementSystem
{
    public class ATMRefillingManagementMenu
    {
        private IBankRepository db;

        public ATMRefillingManagementMenu(IBankRepository db)
        {
            this.db = db;
        }
        public async Task DisplayMenuAsync()
        {
            while (true)
            {
                Console.WriteLine("Main Menu\n");
                Console.WriteLine("1. Add Refilling Details\n");
                Console.WriteLine("2. Show Refilling Report\n");
                Console.WriteLine("3. Exit\n");

                Console.WriteLine("Please choose option [1,2,3]:");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Add Refilling Details\n");
                        await AddRefillingDetailsAsync();
                        break;
                    case 2:
                        Console.WriteLine("Hello");
                        break;
                    case 3: Environment.Exit(0); break;
                    default:
                        Console.WriteLine("Please Enter a valid Input\n");
                        break;
                }
            }
        }

        private async Task AddRefillingDetailsAsync()
        {
           
                Console.WriteLine("Bank Details\n");
                var banks = await db.GetBankDetailsAsync();
                int i = 1;
                foreach (var bank in banks)
                {                   
                    Console.WriteLine(i++ +bank.Name+"\n");
                }
                Console.Write("Choose a BANK [");
                for (int j = 1; j <= i; j++)
                Console.Write(j+",");
                Console.Write("]:");
                
           
        }
    }
}
