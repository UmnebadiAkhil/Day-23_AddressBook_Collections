// See https://aka.ms/new-console-template for more information

using AddressBook_Collections;

//creating a list
List<Contact> contacts = new List<Contact>();

Console.WriteLine("Hello, Welcome to Address Book!");
//choice = 0 means choice has not made yet
int choice = 0;
while (choice != 3)
{
    Console.WriteLine("\t********Main Menu***********\t");
    Console.WriteLine("Enter the following choice");
    Console.WriteLine("1. Add Contact");
    Console.WriteLine("2. Display Contacts");
    Console.WriteLine("3. Exit");
    Console.WriteLine("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("Add New Contacts: ");
            Console.WriteLine("Enter the Firstname: ");
            string first_name = Console.ReadLine();
            Console.WriteLine("Enter the Lastname: ");
            string last_name = Console.ReadLine();
            Console.WriteLine("Enter the Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the City: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the State: ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter the Zip: ");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Phone number");
            long phone = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Email: ");
            string email = Console.ReadLine();

            //Reference for c
            Contact ct1 = new Contact(first_name, last_name, address, city, state, zip, phone, email);
            contacts.Add(ct1);
            Console.WriteLine("Contact Added Successfully");
            break;

        case 2:
            foreach (Contact c in contacts)
            {
                Console.WriteLine(c);
            }
            break;
        case 3:
            
            break;
    }
}