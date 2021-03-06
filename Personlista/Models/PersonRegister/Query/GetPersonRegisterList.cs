﻿using System.Linq;

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
            var arrayOfPersons = XmlFileData.ReadXmlFile();
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

            //Pagination
            var currentPage = searchRequest.PageNumber.HasValue ? searchRequest.PageNumber.Value : 1;
            var startPage = currentPage - 5;
            var endPage = currentPage + 4;

            if (startPage <= 0)
            {
                endPage -= (startPage - 1);
                startPage = 1;
            }

            if (endPage > numberOfPages)
            {
                endPage = numberOfPages;

                if (endPage > 10)
                {
                    startPage = endPage - 9;
                }
            }

            result.CurrentPage = currentPage;
            result.FirstPage = startPage;
            result.LastPage = endPage;


            //Return list
            var skip = (currentPage - 1) * take;

            result.Persons = personList.Skip(skip).Take(take).ToList();
            return result;
        }
    }
}