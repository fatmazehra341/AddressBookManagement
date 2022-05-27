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
                FirstName = "Fatma",
                LastName = "Zehara",
                Address = "Varanasi",
                City = "Bangalore",
                State ="UP",
                EmailAddress = "fatma341gmail.com",
                PostalCode = 221006,
                MobileNumber = 854784588
            };
            Contact address2 = new Contact()
            {
                FirstName = "Anita",
                LastName = "Kumari",
                Address = "Mumbai",
                City = "Bangalore",
                State = "UP",
                EmailAddress = "fatma341gmail.com",
                PostalCode = 221006,
                MobileNumber = 854784588
            };
            addressBook.Add(address1);
            addressBook.Add(address2);
        }
        public void AddContactToAddressBook(Contact contact)
        {
            addressBook.Add(contact);
        }
        public void Display()
        {
            foreach (var contact in addressBook)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + "" + contact.City + " " + contact.State + " " + contact.EmailAddress + " " + " " + contact.PostalCode + " " + contact.MobileNumber);
            }
        }

    }
}
