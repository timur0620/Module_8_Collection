using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Bogus;
namespace Module_8_Collection.HomeWork
{
    internal class TaskFour
    {
        public void RunTaskFour()
        {   
             List<string>clearData =  CreatePerson();

             PrintFakePerson(clearData);

             RecordInFile(clearData);
        }
        private static List<string> CreatePerson()
        {
            var faker = new Faker();

            Random random = new Random();

            string fullName = faker.Person.FullName;
            string street = faker.Person.Address.Street;
            string houseNumber = random.Next(10, 99).ToString();
            string floorNumber = random.Next(100, 999).ToString();
            string mobilePhone = faker.Person.Phone;
            string flatPhone = faker.Person.Phone;

            List<string> listPerson = new List<string>() {fullName,  street, houseNumber,
                                                          floorNumber, mobilePhone, flatPhone
                                                         };
            return listPerson;
        }
        private static void PrintFakePerson(List<string> person)
        {
            foreach (var item in person)
            {
                Console.WriteLine(item);
            }
        }
        private static void RecordInFile(List<string> person)
        {
            string path = "F:\\c#Projects\\Module_8_Collection\\HomeWork\\DB\\person.xml";

            XElement fullNamePerson = new XElement("PERSON");
            XElement address = new XElement("ADDRESS");
            XElement phones = new XElement("PHONES");

            XAttribute fullName = new XAttribute("Person", person[0]);
            XAttribute street = new XAttribute("Street", person[1]);
            XAttribute houseNumber = new XAttribute("House_number", person[2]);
            XAttribute floorNumber = new XAttribute("Floor_number", person[3]);
            XAttribute mobilePhone = new XAttribute("Mobile_phone", person[4]);
            XAttribute flatPhone = new XAttribute("Flat_phone", person[5]);

            fullNamePerson.Add(fullName);

            address.Add(street, houseNumber, floorNumber);

            phones.Add(mobilePhone, flatPhone);

            fullNamePerson.Add(address, phones);

            fullNamePerson.Save(path);
        }
    }
}
