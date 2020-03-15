using AdviserDashboardService.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdviserDashboardService.Model
{
    public class Customer : IAuditable
    {
        public Guid Id { get; set; }

        [ForeignKey("Adviser")]
        public Guid AdviserId { get; set; }

        public string LastUpdatedBy { get; set; }

        public DateTime LastUpdateAt { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public int AccountNumber { get; set; }

        public string SortCode { get; set; }
    }
}
