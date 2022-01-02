﻿using CRM_Dashboard.Helpers;
using CRM_Dashboard.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_Dashboard.LeadsData
{
    public class Customers : ICustomersData
    {
        private readonly LeadContext _customerContext;

        public Customers(LeadContext customerContext)
        {
            _customerContext = customerContext;
        }

        public CustomerPersonalData AddCustomer(CustomerPersonalData customerPersonalData)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(CustomerPersonalData customerPersonalData)
        {
            throw new NotImplementedException();
        }

        public CustomerPersonalData EditCustomer(CustomerPersonalData customerPersonalData)
        {
            throw new NotImplementedException();
        }

        public CustomerPersonalData GetCustomer(int Id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerPersonalData> GetCustomers(LeadsParameters leadsParameters)
        {
            return PagedList<CustomerPersonalData>.ToPagedList(_customerContext.Leads_Customer_PersonalData, leadsParameters.PageNumber, leadsParameters.PageSize);
        }
    }
}
