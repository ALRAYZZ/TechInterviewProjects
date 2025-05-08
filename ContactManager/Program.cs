using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactManager.Utilities;

namespace ContactManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Contact Manager.");
            bool isRunning = true;

            ManagerContact managerContact = new ManagerContact();


            while (isRunning)
            {
                Console.WriteLine("What do you want to do?");
                Console.Write("1.Add Contact, 2.View All, 3.Search, 4.Update, 5.Delete, 6.Exit : ");
                string stringInput = Console.ReadLine().Trim().ToLower();

                if (!string.IsNullOrEmpty(stringInput) && int.TryParse(stringInput, out int input))
                {
					isRunning = managerContact.ProcessInput(input);
				}
                else
                {
					Console.WriteLine("Please enter the number of the option.");
                    continue;
                }
                
			}
        }
    }
}
