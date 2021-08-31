using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductManagement.ModelView;

namespace ProductManagement.Models
{
    public class ProductRepository : IProductRepository
    {
        ProductContext _context;
        ProductCategoryContext _catcontext;
        IProductCategoryRepository prodrep;

        public ProductRepository(ProductContext context, ProductCategoryContext catcontext, IProductCategoryRepository rep)
        {
            this._context = context;
            this._catcontext = catcontext;
            this.prodrep = rep;
        }

        public List<Product> viewAll()
        {
            return _context.Product.ToList();
        }

       
        public bool AddProduct(Product product)
        {
            try
            {
                _context.Product.Add(product);
                _context.SaveChanges();
                return true;
            }

            catch
            {
                return false;
            }
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                _context.Entry(product).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteProduct(int ID)
        {
            try
            {
                Product product = _context.Product.Where(item => item.ID == ID).FirstOrDefault();
                _context.Product.Remove(product);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Product> SearchByCategory(string category)
        {
            ProductCategory pc = _catcontext.ProductCategory.Where(cat => cat.CatName == category).FirstOrDefault();

            if(pc == null)
            {
                return null;
            }

            return _context.Product.Where(prod => prod.CID == pc.CID).ToList();
        }

        public List<CategoryCountVM> CountByCategory()
        {
            
            List<ProductCategory> tempCatList = prodrep.ViewAll();
            List<CategoryCountVM> tempCountList = new List<CategoryCountVM>();
            foreach(ProductCategory prod in tempCatList)
            {
                CategoryCountVM temp = new CategoryCountVM();
                temp.CatCount = _context.Product.Where(product => product.CID == prod.CID).Count();
                temp.CatName = prod.CatName;

                tempCountList.Add(temp);
            }



            return tempCountList;
        }

    }
}
