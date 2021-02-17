using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Tom", 29);


            // XML Serialize
            XmlSerializer formatterXML = new XmlSerializer(typeof(Person));
            
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                formatterXML.Serialize(fs, person);
            }
            
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                Person newPerson = (Person)formatterXML.Deserialize(fs);                
                Console.WriteLine($"Name: {newPerson.Name} --- Age: {newPerson.Age}");
            }

            Console.ReadLine();

            // Binary
            FileStream stream = File.Create("PersonData.dat");
            BinaryFormatter formatterBinary = new BinaryFormatter();
            formatterBinary.Serialize(stream, person);
            stream.Close();
                        
            stream = File.OpenRead("CarData.dat");            
            Person personDeserializeBinary = formatterBinary.Deserialize(stream) as Person;
            stream.Close();
            Console.ReadKey();

            // SOAP
            FileStream streamSOAP = File.Create("PersonData.xml");
            SoapFormatter formatterSOAP = new SoapFormatter();            
            formatterSOAP.Serialize(streamSOAP, person);            
            streamSOAP.Close();            
            streamSOAP = File.OpenRead("PersonData.xml");            
            person = formatterSOAP.Deserialize(streamSOAP) as Person;
            stream.Close();

            Console.ReadKey();
        }
    }

}
