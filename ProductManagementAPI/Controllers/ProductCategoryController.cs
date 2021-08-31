using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductManagement.Models;


namespace ProductManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        IProductCategoryRepository prodCatRepo;

        public ProductCategoryController(IProductCategoryRepository prodcatrepo)
        {
            this.prodCatRepo = prodcatrepo;
        }

        [HttpGet]

        public IActionResult ViewAll()
        {
            return Ok(prodCatRepo.ViewAll());
        }

        [HttpPost]
        public IActionResult AddProductCategory(ProductCategory productCategory)
        {
            bool result = prodCatRepo.AddProductCategory(productCategory);

            if (result)
            {
                return Ok();
            }


            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult UpdateProductCategory(ProductCategory productCategory)
        {
            bool result = prodCatRepo.UpdateProductCategory(productCategory);

            if (result)
            {
                return Ok();
            }


            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{CID}")]
        public IActionResult DeleteProductCategory(int CID)
        {
            bool result = prodCatRepo.DeleteProductCategory(CID);

            if (result)
            {
                return Ok();
            }


            else
            {
                return BadRequest();
            }
        }


    }
}
