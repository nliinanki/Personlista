using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personlista.Models
{

    /// <summary>
    /// Search request to filter list
    /// </summary>
    public class SearchRequest
    {
        /// <summary>
        /// Search in list
        /// </summary>
        public string SearchString { get; set; }

        /// <summary>
        /// The number of item to display before splitting to new page
        /// </summary>
        public DisplayNumber DisplayNumber { get; set; }

        /// <summary>
        /// The page number
        /// </summary>
        public int? PageNumber { get; set; }
    }

    public enum DisplayNumber
    {
        Display10 = 0,
        Display50,
        Display100
    }

}