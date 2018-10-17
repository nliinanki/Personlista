using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personlista.Models
{
    /// <summary>
    /// Search request to filter list
    /// </summary>
    public class CreateRequest
    {
        /// <summary>
        /// SearchRequest
        /// </summary>
        public SearchRequest SearchRequest { get; set; }

        /// <summary>
        /// Persons to be created
        /// </summary>
        public CreatedPerson CreatedPerson { get; set; }

        /// <summary>
        /// List of persons to be created
        /// </summary>
        public List<CreatedPerson> ListOfPersons { get; set; }
    }

    /// <summary>
    /// Person to be created listdata
    /// </summary>
    public class CreatedPerson
    {
        /// <summary>
        /// FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// PersonNumber
        /// </summary>
        public string PersonNumber { get; set; }

        /// <summary>
        /// PersonType
        /// </summary>
        public string PersonType { get; set; }
    }
}
