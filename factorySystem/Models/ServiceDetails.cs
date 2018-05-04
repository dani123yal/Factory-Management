using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace factorySystem.Models
{
    public class ServiceDetails
    {
        [Required]
        int ServiceDetails_Id { get; set; }

        [Required]
        int Service_Id { get; set; }

        [Required]
        int Request_Id { get; set; }

        int Quantity { get; set; }
        
        string Description { get; set; }
        
        string Status { get; set; }

    }
}