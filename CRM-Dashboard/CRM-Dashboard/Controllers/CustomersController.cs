using CRM_Dashboard.LeadsData;
using CRM_Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRM_Dashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ICustomersData _customerData;
        public CustomersController(ICustomersData customersData)
        {
            _customerData = customersData;
        }

        
        // GET: api/<CustomersController>
        [HttpGet]
        public IActionResult Get([FromQuery] LeadsParameters leadParameters)
        {
            var customers = _customerData.GetCustomers(leadParameters);
            return Ok(customers);

        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var customer = _customerData.GetCustomer(id);
            if(customer != null)
            {
                return Ok(customer);
            }

            return NotFound($"Lead with Id: {id} was not found");

        }

        // POST api/<CustomersController>
        [HttpPost]
        public CreatedResult Post([FromBody] CustomerPersonalData value)
        {
            if(value.CustomerId != null)
            {
                _customerData.AddCustomer(value);
            }
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host +
               HttpContext.Request.Path + "/" + value.CustomerId, value);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CustomerPersonalData value)
        {
            var existingCustomer = _customerData.GetCustomer(id);

            if (existingCustomer != null)
            {
                value.Id = id;
                _customerData.EditCustomer(value);
            }
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           
        
           
        }
    }
}
