using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KellysClassProject
{
    /// <summary>
    /// Definition of a sport
    /// </summary>
        
        public class Sport
    {
        #region Properties
       
        [Key]
       
        public string sport { get; set; }

        #endregion
    }
}
