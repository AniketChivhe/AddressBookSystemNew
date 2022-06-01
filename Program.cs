using System;

namespace UC5_MultipleContacts 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding Contact
            Console.WriteLine("------------Welcome To Adderess Book Program-------------");
            Console.WriteLine("1.Enter to add the details\n2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove or Delete the  COntact details");
            Console.WriteLine("5.Multiplke Contact Details");
            Console.WriteLine("Enter a option");
            switch (Console.ReadLine())
            {
                case "1":
                    UC5AddressBook.GetContact(); //adding 1st contact in Address book
                    UC5AddressBook.ListContact(); 

                    break;
                case "2":
                    UC5AddressBook.GetContact();
                    UC5AddressBook.EditContact(); //editing contact details
                    UC5AddressBook.ListContact();
                    break;
                case "3":
                    UC5AddressBook.GetContact();
                    UC5AddressBook.ListContact(); //listing the contact in address book
                    break;
                case "4":
                    UC5AddressBook.GetContact();
                    UC5AddressBook.DeletePeople(); //Deleting Contact

                    break;
                case "5":
                    UC5AddressBook.GetContact();
                    UC5AddressBook.GetContact(); //Adding other contacts in AddressBook
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;

            }


        }
    }
}