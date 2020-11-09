using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP_Exercise.Models;

namespace ASP_Exercise.ViewModel
{
    public class RandomMoviceViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}