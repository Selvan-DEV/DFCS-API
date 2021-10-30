using CRM_Dashboard.LeadsData;
using CRM_Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace CRM_Dashboard.Controllers
{
    [ApiController]
    public class LeadsController : ControllerBase
    {
        private ILeadsData _leadData;

        public LeadsController(ILeadsData leadData)
        {
            _leadData = leadData;
        }

        //Get Lead List
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetLeads([FromQuery] LeadsParameters leadParameters) 
        {
            var leads = _leadData.GetLeads(leadParameters);

            var metaData = new
            {
                leads.TotalCount,
                leads.PageSize,
                leads.CurrentPage,
                leads.HasNext,
                leads.HasPrevious
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metaData));
            return Ok(leads);
        }
        
        //Get Lead By Id
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetLead(Guid id)
        {
            var lead = _leadData.GetLead(id);

            if(lead != null)
            {
                return Ok(lead);
            }

            return NotFound($"Lead with Id: {id} was not found");
        }

        //Get Lead By Status
        [HttpGet]
        [Route("api/[controller]/status")]
        public IActionResult GetLeadByStatus([FromQuery] string leadsStatus)
        {
            var lead = _leadData.GetLeadByStatus(leadsStatus);

            if (lead != null)
            {
                return Ok(lead);
            }

            return NotFound($"Lead with Status: {leadsStatus} was not found");
        }

        //Add Lead
        [HttpPost]
        [Route("api/[controller]/create")]
        public IActionResult AddLead(Lead lead)
        {
           _leadData.AddLead(lead);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host +
                HttpContext.Request.Path + "/" + lead.CustomerId, lead);
        }
        
        //Delete Lead
        [HttpDelete]
        [Route("api/[controller]/{id}/delete")]
        public IActionResult DeleteLead(Guid id)
        {
            var lead = _leadData.GetLead(id);
            if(lead != null)
            {
                _leadData.DeleteLead(lead);
                return Ok();
            }

            return NotFound($"Lead with Id: {id} was not found");
        }
        
        //Edit Lead
        [HttpPatch]
        [Route("api/[controller]/{id}/edit")]
        public IActionResult EditLead(Guid id, Lead lead)
        {
           var existingLead = _leadData.GetLead(id);

            if (existingLead != null)
            {
                lead.CustomerId = existingLead.CustomerId;
                _leadData.EditLead(lead);
            }
            return Ok(lead);
        }
    }
}
