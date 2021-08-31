using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductManagement.ModelView;
namespace ProductManagement.Models
{
   public interface IProductRepository
    {
        public List<Product> viewAll();
        public bool AddProduct(Product product);
        public bool UpdateProduct(Product product);

        public bool DeleteProduct(int ID);

        public List<Product> SearchByCategory(string category);
        public List<CategoryCountVM> CountByCategory();


    }
}
