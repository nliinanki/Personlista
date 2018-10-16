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
        public static PersonRegisterListData GetPersonRegisterList(SearchRequest searchRequest)
        {
            var result = new PersonRegisterListData();

            //Get data
            var arrayOfPersons = FakeDatabase.ReadXmlFile();
            var personList = arrayOfPersons.Persons;

            //Count the list before take
            result.ListCount = personList.Count();


            //Filter by search string in list
            if (!string.IsNullOrEmpty(searchRequest.SearchString))
            {
                personList = personList.Where(x => 
                    x.Firstname.ToLower().Contains(searchRequest.SearchString.ToLower()) ||
                    x.Lastname.ToLower().Contains(searchRequest.SearchString.ToLower()) ||
                    x.PersonCategory.ToLower().Contains(searchRequest.SearchString.ToLower()) ||
                    x.Socialnumber.ToLower().Contains(searchRequest.SearchString.ToLower())).ToList();
            }


            //Filter number of items per page
            switch (searchRequest.DisplayNumber)
            {
                case DisplayNumber.Display50:
                    personList = personList.Take(50).ToList();
                    break;
                case DisplayNumber.Display100:
                    personList = personList.Take(100).ToList();
                    break;
                default:
                    personList = personList.Take(10).ToList();
                    break;
            }

            result.Persons = personList;

            return result;
        }
    }
}