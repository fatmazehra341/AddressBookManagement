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
                State = "UP",
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
        public void EditContactInAddressBook(string name)
        {
            foreach (var contact in addressBook)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("Enter the Option To Update");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the FirstName to Update");
                            contact.FirstName = Console.ReadLine(); break;
                        case 2:
                            Console.WriteLine("Enter the LastName to Update");
                            contact.LastName = Console.ReadLine(); break;
                        case 3:
                            Console.WriteLine("Enter the Address to Update");
                            contact.Address = Console.ReadLine(); break;
                        case 4:
                            Console.WriteLine("Enter the City to Update");
                            contact.City = Console.ReadLine(); break;
                        case 5:
                            Console.WriteLine("Enter the State to Update");
                            contact.State = Console.ReadLine(); break;
                        case 6:
                            Console.WriteLine("Enter the Email to Update");
                            contact.EmailAddress = Console.ReadLine(); break;
                        case 7:
                            Console.WriteLine("Enter the Postal to Update");
                            contact.PostalCode = Convert.ToInt32(Console.ReadLine()); break;
                        case 8:
                            Console.WriteLine("Enter the MobileNumber to Update");
                            contact.MobileNumber = Convert.ToInt64(Console.ReadLine()); break;
                    }
                }
                Display();
            }
        }
    }
}