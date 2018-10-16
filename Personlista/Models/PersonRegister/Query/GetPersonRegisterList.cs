using Personlista.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Personlista.Models
{
    /// <summary>
    /// Repository for register of persons
    /// </summary>
    public static partial class PersonRegister
    {



        /// <summary>
        /// Get list of persons
        /// </summary>
        public static List<Person> GetPersonRegisterList(SearchRequest searchRequest)
        {
            //Get data
            var arrayOfPersons = FakeDatabase.ReadXmlFile();
            var personList = arrayOfPersons.Persons;


            //Search in list

       
            //Filter items per page if set
            if (searchRequest.NumberToDisplayPerPage.HasValue)
            {
                personList = personList.Take(searchRequest.NumberToDisplayPerPage.Value).ToList();   
            }
            else
            {
                personList = personList.Take(10).ToList();
            }




            return personList.ToList();
        }
    }
}