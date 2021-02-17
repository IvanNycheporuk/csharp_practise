using System;
using System.IO;
using System.Xml.Serialization;

namespace task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream;
            XmlSerializer serializer;


            // without attributes 
            // serialize
            Person person = new Person
            {
                age = 22,
                name = "Person Test",
                nationality = "Test_Nationality",
                personId = 1
            };            

            stream = new FileStream("Person.xml", FileMode.Create);            
            serializer = new XmlSerializer(typeof(Person));            
            serializer.Serialize(stream, person);            
            stream.Close();

            // deserialize
            stream = new FileStream("Person.xml", FileMode.Open);
            person = (Person)serializer.Deserialize(stream);
            stream.Close();

            // with attributes serialize
            PersonAttr personAttr = new PersonAttr
            {
                age = 31,
                name = "Person Attr Test",
                nationality = "Test_Nationality_Attr",
                personId = 2
            };

            stream = new FileStream("PersonAttr.xml", FileMode.Create);
            serializer = new XmlSerializer(typeof(PersonAttr));
            serializer.Serialize(stream, personAttr);
            stream.Close();

            // deserialize
            stream = new FileStream("PersonAttr.xml", FileMode.Open);
            personAttr = (PersonAttr)serializer.Deserialize(stream);
            stream.Close();
             
            foreach( var item in personAttr.GetType().GetProperties())
            {                
                Console.WriteLine(item);
            }

            Console.WriteLine(personAttr.ToString());
            Console.ReadKey();
        }
    }
}
