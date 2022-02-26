using CRM_Dashboard.Helpers;
using CRM_Dashboard.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRM_Dashboard.LeadsData
{
    public class Leads : ILeadsData
    {
        private LeadContext _leadContext;
        public Leads(LeadContext leadContext)
        {
            _leadContext = leadContext;
        }
        public Lead AddLead(Lead lead)
        {
            lead.CustomerId = Guid.NewGuid();
            lead.CreatedAt = DateTime.Now;
            lead.UpdatedAt = DateTime.Now;
            _leadContext.Leads.Add(lead);
            _leadContext.SaveChanges();
            return lead;
        }

        public void DeleteLead(Lead lead)
        {
            _leadContext.Leads.Remove(lead);
            _leadContext.SaveChanges();
        }

        public Lead EditLead(Lead lead)
        {
            var existingLead = _leadContext.Leads.Find(lead.CustomerId);
            if(existingLead != null)
            {
                existingLead.Name = lead.Name;
                existingLead.PhoneNumber = lead.PhoneNumber;
                existingLead.MeetingType = lead.MeetingType;
                existingLead.Reference = lead.Reference;
                existingLead.Summary = lead.Summary;
                existingLead.LeadStatus = lead.LeadStatus;
                existingLead.UpdatedAt = DateTime.Now;
                existingLead.Email = lead.Email;
            }
            _leadContext.Leads.Update(existingLead);
            _leadContext.SaveChanges();
            return lead;
        }

        public Lead GetLead(int Id)
        {
            return _leadContext.Leads
                .FromSqlRaw<Lead>("spGetLeadById {0}", Id)
                .ToList()
                .FirstOrDefault();
        }

        public List<Lead> GetLeadByStatus(string leadStatus)
        {
            return _leadContext.Leads
                .FromSqlRaw<Lead>("spGetLeadByStatus {0}", leadStatus)
                .ToList();
        }

        public PagedList<Lead> GetLeads(LeadsParameters leadsParameters) 
        {
            return PagedList<Lead>.ToPagedList(_leadContext.Leads, leadsParameters.PageNumber, leadsParameters.PageSize);
        }
    }
}
