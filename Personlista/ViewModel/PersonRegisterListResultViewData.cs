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
        /// Count of the list
        /// </summary>
        public int ListCount { get; set; }

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