using System;


namespace UC3UC4_EditAndDeleteContacts
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
            Console.WriteLine("Enter a option");
            switch (Console.ReadLine())
            {
                case "1":
                    EditAndDeleteContact.GetContact();  //adding 1st contact in Address book
                    EditAndDeleteContact.ListContact();

                    break;
                case "2":
                    EditAndDeleteContact.GetContact();
                    EditAndDeleteContact.EditContact();//editing contact details
                    EditAndDeleteContact.ListContact();
                    break;
                case "3":
                    EditAndDeleteContact.GetContact();
                    EditAndDeleteContact.ListContact();//listing the contact in address book
                    break;
                case "4":
                    EditAndDeleteContact.GetContact();
                    EditAndDeleteContact.DeletePeople();//Deleting Contact

                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;

            }


        }
    }
}