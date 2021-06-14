using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class RegisterViewModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordRepeat { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
