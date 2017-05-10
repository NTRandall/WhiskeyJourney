using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhiskeyJourney.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
    }
}