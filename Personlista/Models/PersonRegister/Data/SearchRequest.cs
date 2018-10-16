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
        public class SearchRequest
        {
            /// <summary>
            /// The number of item to display before splitting to new page
            /// </summary>
            public int? NumberToDisplayPerPage { get; set; }

            /// <summary>
            /// Search in list
            /// </summary>
            public string SearchString { get; set; }
        }
    }
}