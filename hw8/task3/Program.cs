using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument document = XDocument.Load("Books.xml");

            IEnumerable<Contacts> contactList = from row in document.Element("ListOfBooks").Elements("Book")
                                         select new Contacts
                                         {
                                             Number = row.Attribute("TelephoneNumber").Value,
                                             Name = row.Element("Name").Value
                                         };

            foreach (Contacts contact in contactList)
            {
                Console.WriteLine($"Phone number is {contact.Number}");
            }

            //задержка
            Console.ReadKey();
        }

        class Contacts
        {
            public string Name { get; set; }

            public string Number { get; set; }
        }
    }
}
