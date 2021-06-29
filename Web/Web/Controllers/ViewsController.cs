using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class ViewsController : Controller
    {
        // GET: Views
        public ActionResult CreateInvoice()
        {
            IEnumerable<Customer> customers = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44348/api/Customers/GetCustomers");
            var readpi = hc.GetAsync("empdd");
            return View();
        }
        public ActionResult ListInvoice()
        {
            return View();
        }

        public ActionResult DetailInvoice()
        {
            return View();
        }
    }
}