using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
   public class Customer
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int Housenumber { get; set; }
        public string Housenumberintial { get; set; }
        public int Zipcode { get; set; }
        public string ZipcodeCharacter { get; set; }
        public string City { get; set; }
        public virtual User User { get; set; }
    }
}
