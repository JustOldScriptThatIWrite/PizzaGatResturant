using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzaGatResturant.Models;

namespace PizzaGatResturant.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
        public MembershipType MembershipTypes { get; set; }
    }
}