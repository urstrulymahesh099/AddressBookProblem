using System;
namespace AddressBookProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("*********PLEASE SELECT THE BELOW GIVEN CHOICES*********");
            Console.ResetColor();
            AddressBook addressBook = new AddressBook();
            Console.WriteLine("");
            Console.WriteLine("1.CreateaContacts\n2.DisplayContact");
            while(true)
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        addressBook.CreateContact();
                        Console.WriteLine("*****Please select next choice*****");
                            break;
                    case 2:
                        addressBook.DisplayContact();
                        Console.WriteLine("*****Please select next choice*****");
                        break;
                        default:
                        Console.WriteLine("Please Select Choice again");
                        break;
                }
            }
        }
    }
}