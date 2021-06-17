using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class ProffileDetailViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Street { get; set; }
        public int Housenumber { get; set; }
        public string Housenumberintial { get; set; }
        public int Zipcode { get; set; }
        public string ZipcodeCharacter { get; set; }
        public string City { get; set; }

        public ProffileDetailViewModel(User user)
        {
            Username = user.Username;
            Password = user.Password;
            Email = user.Email;
            Firstname = user.Firstname;
            Lastname = user.Lastname;
        }

        public ProffileDetailViewModel(User user, Customer customer)
        {
            Username = user.Username;
            Password = user.Password;
            Email = user.Email;
            Firstname = user.Firstname;
            Lastname = user.Lastname;
            Street = customer.Street;
            Housenumber = customer.Housenumber;
            Housenumberintial = customer.Housenumberintial;
            Zipcode = customer.Zipcode;
            ZipcodeCharacter = customer.ZipcodeCharacter;
            City = customer.City;
        }
    }
}
