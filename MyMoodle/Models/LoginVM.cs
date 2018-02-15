using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMoodle.Models
{
    public class LoginVM
    {

        [Required]
        public string Studentnumber { get; set; }
        [Required]
        public string Password { get; set; }

    }
}