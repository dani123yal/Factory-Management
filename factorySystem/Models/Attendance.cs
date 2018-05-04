using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace factorySystem.Models
{
    public class Attendance
    {
        [Required]
        int Employee_Id { get; set; }

        DateTime Date { get; set; } 

        string Status { get; set; }

        string Shift { get; set; }
        
    }
}