using System;
using System.ComponentModel.DataAnnotations;

namespace CRM_Dashboard.Models
{
    public class Lead
    {
        [Key]
        public Guid CustomerId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name can only be 50 Characters")]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "Phone Number can only be 10 Numbers")]
        public String PhoneNumber { get; set; }

        [Required]
        public string LeadStatus { get; set; }

        [Required]
        public string MeetingType { get; set; }

        public String Reference { get; set; }

        [MaxLength(250, ErrorMessage = "Summary can only be 250 Characters")]
        public string Summary { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
