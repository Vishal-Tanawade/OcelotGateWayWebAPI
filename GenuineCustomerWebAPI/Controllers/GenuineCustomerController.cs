using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenuineCustomerWebAPI.Controllers
{
   
        [Route("api/[controller]")]
        [ApiController]
        public class GenuineCustomerController : ControllerBase
        {
            private static List<Customer> CustomerList = new List<Customer>()
            {
              new Customer(){CutomerId=1,FirstName="Aaron",LastName="Hawkins",CellNumber="(660) 663-4518",Email="aron.hawkins@aol.com" },
              new Customer(){CutomerId=2,FirstName="Hedy",LastName="Greene",CellNumber="(608) 265-2215",Email="hedy.greene@aol.com" },
              new Customer(){CutomerId=3,FirstName="Melvin",LastName="Porter",CellNumber="(959) 119-8364",Email="melvin.porter@aol.com"}
            };

            // GET: api/<GenuineCustomerController>
            [HttpGet]
            public IEnumerable<Customer> Get()
            {

                return CustomerList.ToList();
            }
            // GET api/<ComputerProductsController>/5
            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                Customer customer = CustomerList.FirstOrDefault(c => c.CutomerId == id);
                if (customer != null)
                {
                    return StatusCode(StatusCodes.Status200OK, customer);
                }
                else
                {
                    return BadRequest();
                }


            }


            // POST api/<GenuineCustomerApiController>
            [HttpPost]
            public IActionResult Post([FromBody] Customer customer)
            {

                Customer cust = new Customer();
                if (customer != null)
                {
                    cust = CustomerList.FirstOrDefault();
                    if (cust != null)
                    {
                        int id = CustomerList.Max(c => c.CutomerId);
                        customer.CutomerId = id + 1;
                    }

                    else
                    {
                        customer.CutomerId = 1;
                    }


                    CustomerList.Add(customer);
                    return StatusCode(StatusCodes.Status201Created, customer);

                }
                else
                {

                    //return BadRequest();
                    return StatusCode(StatusCodes.Status400BadRequest);
                }
            }

            // PUT api/<GenuineCustomerApiController>/5

            [HttpPut("{id}")]

            public IActionResult Put(int id, [FromBody] Customer customer)
            {
                Customer cust = CustomerList.FirstOrDefault(c => c.CutomerId == id);
                if (cust != null)
                {
                    cust.FirstName = customer.FirstName;

                    cust.LastName = customer.LastName;
                    cust.CellNumber = customer.CellNumber;
                    cust.Email = customer.Email;

                    //return Ok();
                    return StatusCode(StatusCodes.Status201Created, customer);
                }
                else
                {
                    return BadRequest();

                }
            }

            // DELETE api/<GenuineCustomerApiController>/5

            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                Customer cust = CustomerList.FirstOrDefault(c => c.CutomerId == id);
                if (cust != null)
                {
                    CustomerList.Remove(cust);
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
        }
    }

