﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KellysClassProject
{
    /// <summary>
    /// Definition of a coach
    /// </summary>
    public class Coach
    {
        #region Properties
        /// <summary>
        /// Name of the coach
        /// </summary>
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        /// <summary>
        /// Sport
        /// </summary>
        public string Sport { get; set; }

        #endregion

        #region Methods
        ///public void Match Coach to Team/
        ///
        #endregion
    }



}

