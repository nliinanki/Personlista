using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personlista.Models
{
    public static partial class PersonRegister
    {
        /// <summary>
        /// 
        /// </summary>
        public class PersonRegisterListData
        {
            /// <summary>
            /// List of persons 
            /// </summary>
            public List<Person> Persons { get; set; }

            /// <summary>
            /// Count of the found persons in list
            /// </summary>
            public int ListCount { get; set; }

            /// <summary>
            /// Count of pages
            /// </summary>
            public int PageCount { get; set; }

            /// <summary>
            /// The current page number in pageination
            /// </summary>
            public int CurrentPage { get; set; }

            /// <summary>
            /// The first page number in pageination
            /// </summary>
            public int FirstPage { get; set; }

            /// <summary>
            /// The last page number in pageination
            /// </summary>
            public int LastPage { get; set; }
        }
    }
}