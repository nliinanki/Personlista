using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Personlista.Database;

namespace Personlista.ViewModel
{
    public class PersonRegisterListViewData
    {
        /// <summary>
        /// PersonList
        /// </summary>
        public List<Person> PersonList { get; set; }

        /// <summary>
        /// SearchRequest
        /// </summary>
        public Models.PersonRegister.SearchRequest SearchRequest { get; set; }
    }
}