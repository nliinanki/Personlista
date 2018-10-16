using Personlista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personlista.ViewModel
{
    public class PersonRegisterListResultViewData
    {
        /// <summary>
        /// The current page number
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// Count of results in list
        /// </summary>
        public int ListCount { get; set; }

        /// <summary>
        /// Count of pages the result generates
        /// </summary>
        public int PageCount { get;  set; }

        /// <summary>
        /// List of page numbers to display
        /// </summary>
        public List<int> PageNumbers { get; set; }

        /// <summary>
        /// PersonList
        /// </summary>
        public List<Database.Person> PersonList { get; set; }

        /// <summary>
        /// SearchRequest
        /// </summary>
        public SearchRequest SearchRequest { get; set; }
    }
}