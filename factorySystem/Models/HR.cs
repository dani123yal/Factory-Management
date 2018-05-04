using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace factorySystem.Models
{
    public class HR
    {
        [Required]
        int Employee_Id { get; set; }

        [Required]
        string Employee_Name { get; set; }

        [Required]
        string CNIC { get; set; }

        
        string Contact_No { get; set; }

        string Address { get; set; }

        string Role { get; set; }

        [DataType(DataType.Currency)]
        double Salary { get; set; }

        DateTime Joining_Date { get; set; } 

    }
}