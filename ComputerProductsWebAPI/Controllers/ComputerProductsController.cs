using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ComputerProductsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputerProductsController : ControllerBase
    {
        public static List<Product> ProductsList = new List<Product>()
        {
        new Product(){ ProductCode=1,ProductName="Speakers",ProductPrice=30000.00m},
        new Product(){ ProductCode=2,ProductName="Desktops",ProductPrice=30000.00m},
        new Product(){ ProductCode=3,ProductName="Laptops",ProductPrice=25000.00m},
        new Product(){ ProductCode=4,ProductName="Gaming PC's",ProductPrice=60000.00m},
        new Product(){ ProductCode=5,ProductName="Servers",ProductPrice=100000.00m},
        new Product(){ ProductCode=6,ProductName="Tablet",ProductPrice=5000.00m},
        new Product(){ ProductCode=7,ProductName="PC's Monitors",ProductPrice=5000.00m},
        new Product(){ ProductCode=8,ProductName="Memory",ProductPrice=2500.00m},
        new Product(){ ProductCode=9,ProductName="Printers",ProductPrice=4000.00m},
        new Product(){ ProductCode=10,ProductName="Projectors",ProductPrice=30000.00m}
        };



        // GET: api/<ComputerProductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductsList.ToList();
        }

        // GET api/<ComputerProductsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Product product = ProductsList.FirstOrDefault(p => p.ProductCode == id);
            if (product != null)
            {
                return StatusCode(StatusCodes.Status200OK, product);

            }
            else
            {
                return BadRequest();
            }


        }


        // POST api/<ComputerProductsController>
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            Product prod = new Product();
            if (product != null)
            {
                prod = ProductsList.FirstOrDefault();
                if (prod != null)
                {
                    int id = ProductsList.Max(p => p.ProductCode);
                    product.ProductCode = id + 1;
                }

                else
                {
                    product.ProductCode = 1;
                }


                ProductsList.Add(product);
                return StatusCode(StatusCodes.Status201Created, product);

            }
            else
            {

                //return BadRequest();
                return StatusCode(StatusCodes.Status400BadRequest);
            }

        }

        // PUT api/<ComputerProductsController>/5
        [HttpPut("{id}")]

        public IActionResult Put(int id, [FromBody] Product product)
        {
            Product prod = ProductsList.FirstOrDefault(p => p.ProductCode == id);
            if (prod != null)
            {
                prod.ProductName = product.ProductName;
                prod.ProductPrice = product.ProductPrice;
                //return Ok();
                return StatusCode(StatusCodes.Status201Created, product);
            }
            else
            {
                return BadRequest();

            }
        }

        // DELETE api/<ComputerProductsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Product prod = ProductsList.FirstOrDefault(p => p.ProductCode == id);
            if (prod != null)
            {
                ProductsList.Remove(prod);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
