using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace factorySystem.Models
{
    public class Account
    {
        [Required]
        int PS_Id { get; set; } 

        [DataType(DataType.Currency)]
        double Discount { get; set; }

        [DataType(DataType.Currency)]
        double Balance { get; set; }

        string Status { get; set; }
    }
}