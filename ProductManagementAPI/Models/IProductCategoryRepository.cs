using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductManagement.Models;

    public interface IProductCategoryRepository
    {
    public List<ProductCategory> ViewAll();

    public bool AddProductCategory(ProductCategory productCategory);
    public bool UpdateProductCategory(ProductCategory productCategory);

    public bool DeleteProductCategory(int ID);

}

