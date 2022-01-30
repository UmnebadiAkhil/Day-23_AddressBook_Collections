// See https://aka.ms/new-console-template for more information

using AddressBook_Collections;

//creating a list
List<Contact> contacts = new List<Contact>();

Console.WriteLine("Hello, Welcome to Address Book!");
//choice = 0 means choice has not made yet
int choice = 0;
while (choice != 4)
{
    Console.WriteLine("\t********Main Menu***********\t");
    Console.WriteLine("Enter the following choice");
    Console.WriteLine("1. Add Contact");
    Console.WriteLine("2. Edit Contacts");
    Console.WriteLine("3. Display Contacts");
    Console.WriteLine("4. Exit");
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
            Console.WriteLine("Enter the first name of the person: ");
            string first = Console.ReadLine();
            foreach (Contact c in contacts)
            {
                if (c.first_name.Equals(first))
                {
                    int n = 0;
                    while (n != 9)
                    {
                        Console.WriteLine("Enter the following choice");
                        Console.WriteLine("1. Edit First Name");
                        Console.WriteLine("2. Edit Last Name");
                        Console.WriteLine("3. Edit Address");
                        Console.WriteLine("4. Edit City");
                        Console.WriteLine("5. Edit State");
                        Console.WriteLine("6. Edit Zip");
                        Console.WriteLine("7. Edit Phone Number");
                        Console.WriteLine("8. Edit E-mail");
                        Console.WriteLine("9. Exit");
                        Console.WriteLine("Enter your choice: ");
                        n = Convert.ToInt32(Console.ReadLine());

                        switch (n)
                        {
                            case 1:
                                Console.WriteLine("1. Edit First Name");
                                string fname = Console.ReadLine();
                                c.first_name = fname;
                                Console.WriteLine("Edited Successfully");
                                break;
                            case 2:
                                Console.WriteLine("1. Edit Last Name");
                                string lname = Console.ReadLine();
                                c.last_name = lname;
                                Console.WriteLine("Edited Successfully");
                                break;
                            case 3:
                                Console.WriteLine("1. Edit Address Name");
                                string adrss = Console.ReadLine();
                                c.address = adrss;
                                Console.WriteLine("Edited Successfully");
                                break;
                            case 4:
                                Console.WriteLine("1. Edit City Name");
                                string cty = Console.ReadLine();
                                c.city = cty;
                                Console.WriteLine("Edited Successfully");
                                break;
                            case 5:
                                Console.WriteLine("1. Edit State");
                                string ste = Console.ReadLine();
                                c.state = ste;
                                Console.WriteLine("Edited Successfully");
                                break;
                            case 6:
                                Console.WriteLine("1. Edit Zip");
                                int zp = Convert.ToInt32(Console.ReadLine());
                                c.zip = zp;
                                Console.WriteLine("Edited Successfully");
                                break;
                            case 7:
                                Console.WriteLine("1. Edit Phone Number");
                                long no = Convert.ToInt64(Console.ReadLine());
                                c.phone = no;
                                Console.WriteLine("Edited Successfully");
                                break;
                            case 8:
                                Console.WriteLine("1. Edit Email");
                                string mail = Console.ReadLine();
                                c.first_name = mail;
                                Console.WriteLine("Edited Successfully");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid name");
                }
            }
            break;

        case 3:
            foreach (Contact c in contacts)
            {
                Console.WriteLine(c);
            }
            break;
        case 4:
            
            break;
    }
}