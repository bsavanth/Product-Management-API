
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductManagement.Models;
using ProductManagement.ModelView;
namespace ProductManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        IProductRepository prodRepo;

        public ProductController(IProductRepository prodrepo)
        {
            this.prodRepo = prodrepo;
        }

        [HttpGet]
        public IActionResult ViewAll()
        {
            List<Product> tempList = prodRepo.viewAll();

            if (tempList == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(tempList);
            }
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            bool result = prodRepo.AddProduct(product);

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
        public IActionResult UpdateProduct(Product product)
        {
            bool result = prodRepo.UpdateProduct(product);

            if (result)
            {
                return Ok();
            }


            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{ID}")]
        public IActionResult DeleteProduct(int ID)
        {
            bool result = prodRepo.DeleteProduct(ID);

            if (result)
            {
                return Ok();
            }


            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{CatName}")]

        public IActionResult SearchByCategory(string CatName )
        {

            List<Product> tempList = prodRepo.SearchByCategory(CatName);
            if (tempList == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(tempList);
            }
        }

        [HttpGet]
        public IActionResult CountByCategory()
        {

            List<CategoryCountVM> tempList = prodRepo.CountByCategory();
            if (tempList == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(tempList);
            }
        }



    }
}
