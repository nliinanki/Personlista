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
            var personList = arrayOfPersons.Persons.Where(x => 
                !string.IsNullOrEmpty(x.Firstname) &&
                !string.IsNullOrEmpty(x.Lastname) && 
                !string.IsNullOrEmpty(x.PersonCategory) &&
                !string.IsNullOrEmpty(x.Socialnumber));

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
            var take = 0;
            switch (searchRequest.DisplayNumber)
            {
                case DisplayNumber.Display50:
                    take = 50;
                    break;
                case DisplayNumber.Display100:
                    take = 100;
                    break;
                default:
                    take = 10;
                    break;
            }

            //Number of persons found
            var foundPersons = personList.Count();
            result.ListCount = foundPersons;

            //Number of pages
            var numberOfPages = (foundPersons + take - 1) / take;
            result.PageCount = numberOfPages;

            //List of pagenumbers


            //1,2,3,4,5 Sista
            //Första, 2,3,4,5,6, Sista
            //Första, 3,4,5,6,7, Sista   
            var listOfPageNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            result.PageNumbers = listOfPageNumbers;

            //Return list
            result.Persons = personList.Take(take).ToList();
            return result;
        }
    }
}