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
        public static void Save(CreateRequest createRequest)
        {
            var arrayOfPersons = XmlFileData.ReadXmlFile();

            //Create new id
            var personId = arrayOfPersons.Persons.Count() + 1;

            //Get file
            var path = HttpContext.Current.Server.MapPath("/Content/Files/personer.xml");
            XDocument doc = XDocument.Load(path);
            XElement root = new XElement("ArrayOfPerson");

            //Add new person
            foreach (var person in createRequest.ListOfPersons)
            {
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
        }
    }

}
