using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace Module_8_Collection.HomeWork
{
    internal class TaskTwo
    {
        public  void RunTask_2()
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();

            contacts = CreateFakeContact(5);

            PrintContacts(contacts);

            string searchContact = Console.ReadLine();

            SearchContact(contacts, searchContact);
        }
        private static Dictionary<string, string> CreateFakeContact(int countContact)
        {   
            Dictionary<string, string> contact = new Dictionary<string, string>();

            Random random = new Random();

            for (int i = 0; i < countContact; i++)
            {
                var fakerName = new Faker("sk");

                for (int j = 0; j < random.Next(1, 4); j++)
                {
                    var fakerNumber = new Faker("sk");

                    string randomNumber = fakerNumber.Phone.PhoneNumber();

                    string randomFullName = fakerName.Person.FullName;

                    contact.Add(randomNumber, randomFullName);
                }                
            }
            return contact;
        }
        private static void PrintContacts(Dictionary<string, string> dict)
        {
            foreach (KeyValuePair<string, string> key in dict)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("\nEntered search phone number\n");
        }
        private static void SearchContact(Dictionary<string, string> dict, string phoneNumber)
        {
            foreach (var item in dict)
            {
                if (item.Key == phoneNumber)
                {
                    Console.WriteLine($"\nFull name contact {item.Value}\n");
                    return;
                }
            }
            Console.WriteLine("Not found");
        }
    }
}
