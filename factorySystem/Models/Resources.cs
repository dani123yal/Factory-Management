using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace factorySystem.Models
{
    public class Resources
    {
        [Required]
        int Resource_Id { get; set; }

        [Required]
        int Request_Id { get; set; } 

         [Required]
        int Vendor_Id { get; set; }

         [Required]
        int MaterialDetails_Id { get; set; }

        int Description { get; set; }

        [DataType(DataType.Currency)]
        double TotalPrice { get; set; }

        DateTime Date { get; set; }

    }
}