using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace factorySystem.Models
{
    public class Quotation
    {
        [Required]
        int Quot_Id { get; set; }

        [Required]
        int Company_Id { get; set; }

        [Required]
        int Request_Id { get; set; }
        
        DateTime Date{ get; set; }
        
        string Message{ get; set; }
        
        string Status { get; set; }

        [DataType(DataType.Currency)]
        double Price { get; set; }
    }
}