using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebUI.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
    }
}
