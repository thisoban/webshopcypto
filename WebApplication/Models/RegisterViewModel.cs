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
        public string Street { get; set; }
        public int Housenumber { get; set; }
        public string Housenumberintial { get; set; }
        public int Zipcode { get; set; }
        public string ZipcodeCharacter { get; set; }
        public string City { get; set; }
        public string ErrorMsg { get; set; }

        public RegisterViewModel( string error)
        {
            ErrorMsg = error;
        }
        public RegisterViewModel() { }

    }
}
