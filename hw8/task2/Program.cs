using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument document = XDocument.Load("TelephoneBook.xml");

            foreach (XElement phoneElement in document.Element("MyContacts").Elements("Contacts"))
            {
                XAttribute nameAttribute = phoneElement.Attribute("TelephoneNumber");
                XElement companyElement = phoneElement.Element("Name");                

                if (nameAttribute != null && companyElement != null)
                {
                    Console.WriteLine($"Смартфон: {nameAttribute.Value}");
                    Console.WriteLine($"Компания: {companyElement.Value}");                    
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
