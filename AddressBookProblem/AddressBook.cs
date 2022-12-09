using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    internal class AddressBook
    {
        List<Contacts> data = new List<Contacts>();
        public void CreateContact()
        {
            Contacts contact = new Contacts();
            Console.WriteLine("Enetr First Name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enetr Last Nmae");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter city");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            contact.Zip=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter email");
            contact.Email = Console.ReadLine();
            data.Add(contact);

        }
        public void DisplayContact()
        {
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("*********Contacts*********");
            Console.ResetColor();
            foreach(Contacts records in data)
            {
                Console.WriteLine("FirstName==>>  " + records.FirstName + "\n" + "LastName==>>  " + records.LastName + "\n" + "Address==>>  " + records.Address + "\n" + "City==>>  " + records.City + "\n" + "State==>>  " + records.State + "\n" + "Zip==>> " + records.Zip + "\n" + "email==>>  " + records.Email + "\n" + "ph no==>>  " + records.PhoneNumber);
            }
        }
        public void EditContact()
        {
            Console.WriteLine("To edit contact enter contact first name");
            string name = Console.ReadLine();
            foreach(var record in data)
            {
                if(record.FirstName==name)
                {
                    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("*********Contacts*********");
                    Console.ResetColor();
                    Console.WriteLine("To edit details enter" +
                        "\n1.Lastname\n2.Address\n3.City\n4.State\n5.zip\n6.Ph number\n7.email");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                            Console.WriteLine("Enetr new Last name");
                            string newLastName = Console.ReadLine();
                            record.LastName=newLastName;
                            break;
                        case 2:
                            Console.WriteLine("Enetr new Address");
                            string newAddress = Console.ReadLine();
                            record.Address =newAddress;
                            break;
                        case 3:
                            Console.WriteLine("Enetr new City");
                            string newCity = Console.ReadLine();
                            record.City = newCity;
                            break;
                        case 4:
                            Console.WriteLine("Enetr new State");
                            string newState = Console.ReadLine();
                            record.State = newState;
                            break;
                        case 5:
                            Console.WriteLine("Enetr new Zip");
                            int newZip = Convert.ToInt32(Console.ReadLine());
                            record.Zip = newZip;
                            break;
                        case 6:
                            Console.WriteLine("Enetr new Ph Number");
                            int newPhoneNumber = Convert.ToInt32(Console.ReadLine());
                            record.PhoneNumber = newPhoneNumber;
                            break;
                        case 7:
                            Console.WriteLine("Enetr new Email");
                            string newEmail = Console.ReadLine();
                            record.Email = newEmail;
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("*********Contacts*********");
                    Console.ResetColor();
                }
            }

        }
        public void DeleteContact()
        {

            Console.WriteLine("Select the name what you want to delete Contact");
            string name = Console.ReadLine();
            foreach (var contact in data.ToList())
            {

                if (contact.FirstName == name || contact.LastName == name)
                {
                    data.Remove(contact);
                }
                Console.WriteLine("Contact Deleted Successfully");
            }
        }

    }
}
