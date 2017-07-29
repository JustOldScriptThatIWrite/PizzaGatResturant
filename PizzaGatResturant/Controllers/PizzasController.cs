using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaGatResturant.Models;


namespace PizzaGatResturant.Controllers
{
    public class PizzasController : Controller
    {
        [Route("pizzas/released/{year}/{month}")]
        public ActionResult Hello()
        {
            return Content("Hello All");
        }


        [Route("pizzas/promosion")]
        // GET: Pizzas
        public ActionResult Random()
        {
            var pizza = new Pizzas() {Name = "Joei Like Pizza!"};
            return View(pizza);
        }

        

        /*public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";
            return Content(string.Format("pageIndex={0}&sortby={1}", pageIndex, sortBy));
        }
        public ActionResult ByReleaseDate(int year, string month)
        {
            return Content(year + "/" + month);
        }*/
    }
}