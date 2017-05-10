using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;

namespace WhiskeyJourney.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public int Count { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}