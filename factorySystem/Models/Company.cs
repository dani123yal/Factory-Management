using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace factorySystem.Models
{
    public class Company
    {
        [Required]
        public int Company_Id { get; set; }

        public string Company_Name { get; set; }

        public string Name { get; set; }

        public string Contact_No { get; set; }

        [Required]
        public string Email { get; set; }

        public string Address { get; set; }
    }
}