using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductManagement.Models;

namespace ProductManagement.ModelView
{
    public class CategoryCountVM
    {
        public string CatName { get; set; }
        public int CatCount { get; set; }

        public CategoryCountVM()
        {
            this.CatName = "";
            this.CatCount = 0;
        }
    }
}
