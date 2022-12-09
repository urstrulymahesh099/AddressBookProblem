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
            Console.WriteLine("Enetr First Nmae");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enetr First Nmae");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enetr Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enetr city");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enetr State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enetr Zip");
            contact.Zip=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enetr Phone Number");
            contact.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enetr email");
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
        
    }
}
