using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace factorySystem.Models
{
    public class User
    {
        [Required]
        int User_Id { get; set; }

        [Required]
        string User_Name { get; set; }

        [Required]
        string Password { get; set; }

        int Employee_Id { get; set; }

        string Email { get; set; } 
    }
}