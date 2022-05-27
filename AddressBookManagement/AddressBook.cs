using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagement
{
    internal class AddressBook
    {

        List<Contact> addressBook = new List<Contact>();
        public AddressBook()
        {
            Contact address1 = new Contact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                EmailAddress = Console.ReadLine(),
                PostalCode = Convert.ToInt32(Console.ReadLine()),
                MobileNumber = Convert.ToInt64(Console.ReadLine())
            };
        }
    }
}
