using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day9
{
    class UC4DeletePersonName
    {
        public static IEnumerable<object> People { get; private set; }

        private static void ListPeople()
        {
            if (People.LongCount)
            {
                Console.WriteLine("Here are the current people in your address book:\n");
                foreach (var person in People)
                {
                    PrintPerson(person);
                }
                Console.WriteLine("\nPress any key to continue.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
        }

        private static void PrintPerson(object person)
        {
            throw new NotImplementedException();
        }
    }
}
