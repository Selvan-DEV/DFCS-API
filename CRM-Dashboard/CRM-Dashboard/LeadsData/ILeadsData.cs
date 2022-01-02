using CRM_Dashboard.Helpers;
using CRM_Dashboard.Models;
using System;
using System.Collections.Generic;

namespace CRM_Dashboard.LeadsData   
{

   public interface ILeadsData
    {
        PagedList<Lead> GetLeads(LeadsParameters leadsParamerters);

        Lead GetLead(int Id);

        Lead AddLead(Lead lead);

        void DeleteLead(Lead lead);

        Lead EditLead(Lead lead);

        List<Lead> GetLeadByStatus(string leadsStatus);
    }
}
