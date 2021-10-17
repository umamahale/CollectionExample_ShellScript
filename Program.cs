using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook1 addressBook = new AddressBook1();

            PromptUser();

            void Menu()
            {
                Console.WriteLine("TYPE:");
                Console.WriteLine("'Add' to add a contact: ");
                Console.WriteLine("'Remove' to select and remove a contact: ");
                Console.WriteLine("'Quit' to exit: ");
            }

            void UpdateAddressBook1(string userInput)
            {
                string name = "";
                string address = "";
                switch (userInput.ToLower())
                {
                    case "add":
                        Console.Write("Enter a name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter an address: ");
                        address = Console.ReadLine();
                        addressBook.AddEntry(name, address);
                        break;
                    case "remove":
                        Console.Write("Enter a name to remove: ");
                        name = Console.ReadLine();
                        addressBook.RemoveEntry(name);
                        break;
                    case "view":
                        Console.WriteLine(addressBook.View());
                        break;
                }
            }

            void PromptUser()
            {
                Menu();
                string userInput = "";
                while (userInput != "quit")
                {
                    Console.WriteLine("What would you like to do?");
                    userInput = Console.ReadLine();
                    UpdateAddressBook1(userInput);
                }
            }
        }
    }
}
