﻿using System;
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
            public List<Database.Person> Persons { get; set; }

            /// <summary>
            /// Count of the list
            /// </summary>
            public int ListCount { get; set; }
        }
    }
}