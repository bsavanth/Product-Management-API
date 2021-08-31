using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProductManagement.Models
{
    public class ProductCategory
    {

        [Key] 
        public int CID { get; set; }

        public string CatName { get; set; }

    }
}
