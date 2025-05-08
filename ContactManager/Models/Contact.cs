using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    public class Contact
    {
		private static int _nextId = 1;

		public int Id { get; }
		public string Name { get; set; }
		public string LastName { get; set; }


		public Contact(string name, string lastName)
		{
			Id = _nextId++;
			Name = name;
			LastName = lastName;
		}
	}

}
