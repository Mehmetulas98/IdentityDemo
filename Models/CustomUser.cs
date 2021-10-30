using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDemo.Models
{
    public class CustomUser : IdentityUser
    {
        [Display(Name = "Din")]
        public  string Religion { get; set; }
    }
}
