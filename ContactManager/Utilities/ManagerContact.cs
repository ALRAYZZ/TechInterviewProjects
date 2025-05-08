using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Utilities
{
    public class ManagerContact
    {
        private readonly List<Contact> _contacts = new List<Contact>();


        public bool ProcessInput(int command)
        {

			switch (command)
			{
				case 1:
					Console.WriteLine("Starting contact creation...");
					AddContact();
					return true;

				case 2:
					Console.WriteLine("Listing all contacts saved...");
					ListContacts();
					return true;

				case 3:
					Console.WriteLine("Starting search...");
					ListAContact();
					return true;

				case 4:
					Console.WriteLine("Starting update...");
					UpdateContact();
					return true;

				case 5:
					Console.WriteLine("Starting delete process...");
					RemoveContact();
					return true;

				case 6:
					Console.WriteLine("Exiting Contact Manager...");
					ExitApp();
					return false;

				default:
					Console.WriteLine("Invalid option. Please choose between 1 - 6.");
					return true;
			}
        }
        private void AddContact()
        {
			bool creatingContact = true;
			Console.Write("Enter (Name, Last Name) with a ', ' separator: ");

			while (creatingContact)
			{

				string[] stringInput = Console.ReadLine().Trim().Split(", ");

				if (stringInput.Length == 2)
				{
					Contact newContact = new Contact(stringInput[0].Trim(), stringInput[1].Trim());
					_contacts.Add(newContact);
					Console.WriteLine($"Contact created: {newContact.Name}, {newContact.LastName}.");
					creatingContact = false;
				}
				else
				{
					Console.WriteLine("Wrong input. Please enter Name and Last Name with ', ' as separator. ");
					continue;
				}
			}
		}
        private void ListContacts()
        {
			foreach (Contact contact in _contacts)
			{
				Console.WriteLine($"{contact.Id} | {contact.Name}, {contact.LastName}");
			}
		}
		private void ListAContact()
        {
			bool searching = true;

			while (searching)
			{
				Console.WriteLine("Do you have a 1.Name or 2.Last Name? ");
				string input = Console.ReadLine().Trim();

				if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int intInput))
				{
					if (intInput == 1)
					{
						bool byName = true;

						while (byName)
						{
							Console.Write("Enter the Name you want to search: ");
							string name = Console.ReadLine().Trim();

							if (!string.IsNullOrEmpty(name))
							{
								List<Contact> matches = _contacts.Where(c => c.Name == name).ToList();

								if (matches.Count > 0)
								{
									foreach (Contact contact in matches)
									{
										Console.WriteLine($"{contact.Id} | {contact.Name}, {contact.LastName}");
									}
									byName = false;
									searching = false;
								}
								else
								{
									Console.WriteLine("No matches found.");
									byName = false;
									searching = false;
								}
							}
							else
							{
								Console.WriteLine("Enter a valid name.");
								continue;
							}
						}

					}
					else if (intInput == 2)
					{
						bool byLastName = true;

						while (byLastName)
						{
							Console.Write("Enter the Last Name you want to search: ");
							string lastName = Console.ReadLine().Trim();

							if (!string.IsNullOrEmpty(lastName))
							{
								List<Contact> matches = _contacts.Where(c => c.LastName == lastName).ToList();

								if (matches.Count > 0)
								{
									foreach (Contact contact in matches)
									{
										Console.WriteLine($"{contact.Id} | {contact.Name}, {contact.LastName}");
									}
									byLastName = false;
									searching = false;
								}
								else
								{
									Console.WriteLine("No matches found");
									byLastName = false;
									searching = false;
								}
							}
							else
							{
								Console.WriteLine("Enter a valid Last Name.");
								continue;
							}
						}
					}
				}
				else
				{
					Console.WriteLine("Please enter a valid input based on the numbers of the options.");
					continue;
				}
			}
		}
		private void UpdateContact()
        {
			throw new NotImplementedException();
        }
		private void RemoveContact()
        {
			throw new NotImplementedException();
        }
        private void ExitApp()
        {
			Console.Clear();
			Environment.Exit(0);
        }
    }
}
