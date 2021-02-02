using System.Xml.Linq;

namespace hw8
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = new XDocument(new XElement("MyContacts",
                new XElement("Contact",
                    new XAttribute("TelephoneNumber", "+38 099 123 45 67"),
                    new XElement("Name", "Mr. Test")),
                new XElement("Contact",
                    new XAttribute("TelephoneNumber", "+38 099 789 01 23"),
                    new XElement("Name", "Test1")),
                new XElement("Contact",
                    new XAttribute("TelephoneNumber", "+38 099 456 78 90"),
                    new XElement("Name", "Test2")),
                new XElement("Contact",
                    new XAttribute("TelephoneNumber", "+38 099 111 22 33"),
                    new XElement("Name", "Test3"))

                ));
            xdoc.Save("TelephoneBook.xml");
        }
    }
}
