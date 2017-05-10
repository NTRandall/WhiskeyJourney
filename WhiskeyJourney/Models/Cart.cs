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
    }
}