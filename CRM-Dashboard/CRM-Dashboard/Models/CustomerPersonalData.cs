using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_Dashboard.Models
{
    public class CustomerPersonalData
    {
        [Key]
        public int Id { get; set; }

        public string Agency { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string CustomerType { get; set; }

        public int EstateNumber { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime SignUpDate { get; set; }

        public int Phone { get; set; }

        public string StreatAddress { get; set; }

        public string Suffix { get; set; }

        public Guid CustomerId { get; set; }

        public string email { get; set; }

        public string Gender { get; set; }

        public string MarritalStatus { get; set; }

        public string City { get; set; }

        public string PresentOccupation { get; set; }

        public string Province { get; set; }

        public string NamePresentAddress { get; set; }

        public string PostalCode { get; set; }

        public string Education { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string SpouseOccupation { get; set; }

        public string SpouseEmployer { get; set; }

        public string Notes { get; set; }

        public int NoOfDependents { get; set; }

        public DateTime UpdatedAt { get; set; }

    }
}
