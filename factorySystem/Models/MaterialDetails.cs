using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace factorySystem.Models
{
    public class MaterialDetails
    {
        [Required]
        int MaterialDetails_Id { get; set; }

        [Required]
        int Material_Id { get; set; }

       int Quantity { get; set; }

        [DataType(DataType.Currency)]
        double Price { get; set; }

    }
    
}