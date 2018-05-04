using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace factorySystem.Models
{
    public class PaymentForService
    {
        [Required]
        int PS_Id { get; set; }

        [Required]
        int Company_Id { get; set; }

        [Required]
        int Request_Id { get; set; }

        [DataType(DataType.Currency)]
        double TotalAmount { get; set; }

        string Status { get; set; }

        DateTime date { get; set; }
    }
}