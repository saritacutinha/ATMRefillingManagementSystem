using ATMRefillingManagementSystem.Core;
using ATMRefillingManagementSystem.Core.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ATMRefillingManagementSystem
{
    public class ATMRefillingManagementMenu
    {
        private IBankRepository bankDb;
        private IRefillRepository refillDb;
        private int[] bankIdArray;

        public ATMRefillingManagementMenu(IBankRepository db, IRefillRepository refillDb)
        {
            this.bankDb = db;
            this.refillDb = refillDb;
        }

        public void DisplayMenu()
        {
            CultureInfo enUS = new CultureInfo("en-US");
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
                        AddRefillingDetails();
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

            void AddRefillingDetails()
            {
                var refillRecord = new Refill();
                var format = new[] { "MM/dd/yyyy" };
                DateTime validRefillDate;
                DisplayBankDetails();
                int id = Convert.ToInt32(Console.ReadLine());
                while (!bankIdArray.Contains(id))
                {
                    Console.WriteLine("Error Message: Invalid Bank");
                    DisplayBankDetails();
                    id = Convert.ToInt32(Console.ReadLine());
                }
                refillRecord.BankID = id;
                Console.WriteLine("Enter the area for refilling:");
                refillRecord.Area = Console.ReadLine();
                Console.WriteLine("Enter the amount for refilling:");
                refillRecord.Amount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Refilling Date:(MM/DD/YYYY)");
                string refillDateInput = Console.ReadLine();
                while (!DateTime.TryParseExact(refillDateInput, format, enUS, DateTimeStyles.None, out validRefillDate))
                {                    
                    Console.WriteLine("The date format should be in the MM/DD/YYYY format");
                    refillDateInput = Console.ReadLine();
                }
                refillRecord.RefillDate = validRefillDate;
                string key = refillDb.AddRefillRecord(refillRecord);
                Console.WriteLine("The ATM refilling details have been saved successfully and the refilling id is " + key);
            }

            void DisplayBankDetails()
            {
                Console.WriteLine("Bank Details\n");
                var banks = bankDb.GetBankDetails();
                bankIdArray = new int[banks.Count()];
                foreach (var bank in banks)
                {
                    bankIdArray[bank.Id - 1] = bank.Id;
                    Console.WriteLine(bank.Id + bank.Name + "\n");
                }
                Console.Write("Choose a BANK[");
                for (int i = 0; i < bankIdArray.Count(); i++)
                {
                    Console.Write(bankIdArray[i] + ",");
                }
                Console.Write("]\n");
            }

           
        }

     
    }
}
