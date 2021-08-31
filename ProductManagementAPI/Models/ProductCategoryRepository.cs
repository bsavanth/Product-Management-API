using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProductManagement.Models
{
    public class ProductCategoryRepository:IProductCategoryRepository
    {

        ProductCategoryContext _context;

        public ProductCategoryRepository(ProductCategoryContext context)
        {
            this._context = context;
        }

        public List<ProductCategory> ViewAll()
        {

            List<ProductCategory> temp = _context.ProductCategory.ToList();

            foreach (ProductCategory pc in temp)
            {
                Console.WriteLine(pc.CID+" "+pc.CatName);
            }

            return _context.ProductCategory.ToList();
        }

        public bool AddProductCategory(ProductCategory productCategory)
        {
            try
            {
                _context.ProductCategory.Add(productCategory);
                _context.SaveChanges();
                return true;
            }

            catch
            {
                return false;
            }
        }

        public bool UpdateProductCategory(ProductCategory productCategory)
        {
            try
            {
                _context.Entry(productCategory).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteProductCategory(int CID)
        {
            try
            {
                ProductCategory productCategory = _context.ProductCategory.Where(item => item.CID == CID).FirstOrDefault();
                _context.ProductCategory.Remove(productCategory);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }



    }
}
