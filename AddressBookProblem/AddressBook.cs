using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    internal class AddressBook
    {
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

            Console.WriteLine("FirstName" + contact.FirstName+"\n"+ "LastName" + contact.LastName+"\n"+ "Address"+ contact.Address+"\n"+ "City"+ contact.City+"\n"+"State"+contact.State+"\n"+"Zip"+contact.Zip+"\n"+contact.Zip+"\n"+"email"+contact.Email+"\n"+"ph no"+contact.PhoneNumber);

        }
    }
}
