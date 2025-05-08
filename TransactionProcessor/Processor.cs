using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionProcessor.Classes;
using TransactionProcessor.Enums;

namespace TransactionProcessor
{
    class Processor
    {
        public static List<Transaction> transfers = new List<Transaction>();
        public static void Main(string[] args)
        {
            bool isRunning = true;
			Console.WriteLine("Welcome to the Transaction Processor...");


            while (isRunning)
            {
                Console.Write("Do you want to create a new transaction or list past transfers? (new/list).");

                string response = Console.ReadLine().Trim().ToLower();

                if (response == "list")
                {
                    foreach (Transaction t in transfers)
                    {
                        Console.WriteLine($"A {t.TransactionType} of {t.Amount} done on the {t.DateTime}");
                    }
                }

                else if (response == "new")
                {
                    Console.Write("Enter the quantity: ");
                    string stringQuantity = Console.ReadLine().Trim().ToLower();
                    int quantity;
                    if (!string.IsNullOrEmpty(stringQuantity))
                    {
                        bool parsing = int.TryParse(stringQuantity, out quantity);
                        if (!parsing)
                        {
                            Console.WriteLine("Please, enter a number.");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please, input a value.");
                        continue;
                    }
                    Console.Write("Enter the type of transaction (deposit/withdraw): ");
                    string transactionType = Console.ReadLine().Trim().ToLower();
                    if (!string.IsNullOrEmpty(transactionType))
                    {
                        if (transactionType == "deposit")
                        {
                            Transaction deposit = new Transaction(quantity, TransactionType.deposit);
                            transfers.Add(deposit);
                            Console.WriteLine($"A deposit of {quantity} has been done.");
                            continue;
                        }
                        else if (transactionType == "withdraw")
                        {
                            Transaction withdraw = new Transaction(quantity, TransactionType.withdraw);
                            transfers.Add(withdraw);
                            Console.WriteLine($"A withdraw of {quantity} has been done.");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Invalid transaction type.");
                            Console.WriteLine("Stopping operation");
                            continue;
                        } 
                    }
                }
				else
				{
					Console.WriteLine("Have a good day!");
                    isRunning = false;
					Console.Clear();
				}
			}
        }
    }
}
