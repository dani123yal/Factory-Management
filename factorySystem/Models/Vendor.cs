using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace factorySystem.Models
{
    public class Vendor
    {
        [Required]
        int Vendor_Id { get; set; }

       
        string Vendor_Name { get; set; }

     
        string Contact_No { get; set; }

        string Status { get; set; } 

 
    }
}