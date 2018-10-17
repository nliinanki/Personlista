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
        /// The current page number in pageination
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// First number (after 1) in pageination
        /// </summary>
        public int FirstPage { get; set; }

        /// <summary>
        /// Last number in pageination
        /// </summary>
        public int LastPage { get; set; }

        /// <summary>
        /// Count of pages the result generates
        /// </summary>
        public int PageCount { get;  set; }

        /// <summary>
        /// PersonList
        /// </summary>
        public List<Database.Person> PersonList { get; set; }

        /// <summary>
        /// Count of results in list
        /// </summary>
        public int ListCount { get; set; }

        /// <summary>
        /// SearchRequest
        /// </summary>
        public SearchRequest SearchRequest { get; set; }
    }
}