using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProductManagement.Models
{
    public class ProductCategoryContext:DbContext
    {

        public ProductCategoryContext(DbContextOptions<ProductCategoryContext> DB):base(DB)
        {

        }

        public DbSet<ProductCategory> ProductCategory { get; set; }
    }
}
