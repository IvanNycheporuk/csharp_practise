using System;
using System.Xml.Serialization;

namespace task2_3
{
    [Serializable]
    [XmlRoot("PersonAttr")]
    public class PersonAttr
    {
        [XmlAttribute]
        public int personId;
        [XmlAttribute]
        public int age;
        [XmlAttribute]
        public string name;
        [XmlAttribute]
        public string nationality;

        public PersonAttr() { }
    }
}
