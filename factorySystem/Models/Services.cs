using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace factorySystem.Models
{
    public class Services
    {
        [Required]
        int Service_Id { get; set; }
        
        string Service_name{ get; set; }
        
        string Description { get; set; }
  
    }
}