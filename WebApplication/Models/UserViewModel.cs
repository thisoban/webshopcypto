using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
       

        public UserViewModel(int id , string username, string password, string email, string firstname, string lastname)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            Firstname = firstname;
            Lastname = lastname;
        }
        public UserViewModel() { }
    }
}
