using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Personlista.Models
{
    [XmlRoot(ElementName = "ArrayOfPerson")]
    public class ArrayOfPerson
    {
        [XmlElement(ElementName = "Person")]
        public List<Person> Persons { get; set; }
    }

    public class Person
    {
        [XmlElement(ElementName = "ID")]
        public int Id { get; set; }

        [XmlElement(ElementName = "Firstname")]
        public string Firstname { get; set; }

        [XmlElement(ElementName = "Lastname")]
        public string Lastname { get; set; }

        [XmlElement(ElementName = "Socialnumber")]
        public string Socialnumber { get; set; }

        [XmlElement(ElementName = "PersonCategory")]
        public string PersonCategory { get; set; }
    }

    public static class XmlFileData
    {
        /// <summary>
        /// Get data from xml file
        /// </summary>
        /// <returns></returns>
        public static ArrayOfPerson ReadXmlFile()
        {
            var path = HttpContext.Current.Server.MapPath("/Content/Files/personer.xml");

            var xmlSerializer = new XmlSerializer(typeof(ArrayOfPerson));

            var arrayOfPerson = default(ArrayOfPerson);
            using (var stringReader = new StringReader(File.ReadAllText(path)))
            {
                arrayOfPerson = (ArrayOfPerson)xmlSerializer.Deserialize(stringReader);
            }

            return arrayOfPerson;
        }
    }
}