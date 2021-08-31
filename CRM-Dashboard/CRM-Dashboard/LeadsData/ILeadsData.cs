using CRM_Dashboard.Models;
using System;
using System.Collections.Generic;

namespace CRM_Dashboard.LeadsData   
{

   public interface ILeadsData
    {
        List<Lead> GetLeads();

        Lead GetLead(Guid Id);

        Lead AddLead(Lead lead);

        void DeleteLead(Lead lead);

        Lead EditLead(Lead lead);

    }
}
