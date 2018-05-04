using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace factorySystem.Models
{
    public class Materials
    {
        [Required]
        int Material_Id { get; set; }

        [Required]
        string Material_Name { get; set; }

       string Description { get; set; }

    }
}