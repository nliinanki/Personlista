using Personlista.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Personlista.Models
{
    public static partial class PersonRegister
    {
        /// <summary>
        /// Save to file
        /// </summary>
        private static void Save(CreatedPerson person)
        {
            var arrayOfPersons = FakeDatabase.ReadXmlFile();

            //Create new id
            var personId = arrayOfPersons.Persons.Count() +1;

            //Get file
            var path = HttpContext.Current.Server.MapPath("/Content/Files/personer.xml");
            XDocument doc = XDocument.Load(path);
            XElement root = new XElement("ArrayOfPerson");

            //Add new person
            doc.Root.Add(
                new XElement("Person", 
                    new XElement("ID", personId),
                    new XElement("Firstname", person.FirstName),
                    new XElement("Lastname", person.LastName),
                    new XElement("Socialnumber", person.PersonNumber),
                    new XElement("PersonCategory", person.PersonType)
                    ));
            doc.Save(path);
        }

        /// <summary>
        /// Save many
        /// </summary>
        public static void SaveAllNew(CreateRequest createRequest)
        {
            foreach (var person in createRequest.ListOfPersons)
            {
                Save(person);
            }

        }

        public static void SaveOneNew(CreateRequest createRequest)
        {
            Save(createRequest.CreatedPerson);
        }

    }
}