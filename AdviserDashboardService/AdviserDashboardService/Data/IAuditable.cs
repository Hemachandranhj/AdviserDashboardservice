using System;
using System.ComponentModel.DataAnnotations;

namespace AdviserDashboardService.Data
{
    public interface IAuditable
    {
        [Key]
        Guid Id { get; set; }

        [Required]
        string LastUpdatedBy { get; set; }

        [Required]
        DateTime LastUpdateAt { get; set; }
    }
}
