using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ViewsController : Controller
    {
        // GET: Views
        public ActionResult CreateInvoice()
        {
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