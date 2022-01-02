using CRM_Dashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_Dashboard.LeadsData
{
    public interface ICustomersData
    {
        List<CustomerPersonalData> GetCustomers(LeadsParameters leadsParamerters);

        CustomerPersonalData GetCustomer(int Id);

        CustomerPersonalData AddCustomer(CustomerPersonalData customerPersonalData);

        void DeleteCustomer(CustomerPersonalData customerPersonalData);

        CustomerPersonalData EditCustomer(CustomerPersonalData customerPersonalData);
    }
}
