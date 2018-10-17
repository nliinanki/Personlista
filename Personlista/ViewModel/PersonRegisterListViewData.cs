using Personlista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personlista.ViewModel
{
    public class PersonRegisterListViewData
    {
        /// <summary>
        /// SearchRequest
        /// </summary>
        public SearchRequest SearchRequest { get; set; }

        /// <summary>
        /// CreateRequest
        /// </summary>
        public CreateRequest CreateRequest { get; set; }
    }
}