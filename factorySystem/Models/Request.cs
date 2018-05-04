using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace factorySystem.Models
{
    public class Request
    {
        [Required]
        int Request_Id { get; set; }
        
        [Required]
        int Company_Id { get; set; }
        
        DateTime Date { get; set; }
        
        string Description { get; set; }
        
        string Status { get; set; }
    }
}