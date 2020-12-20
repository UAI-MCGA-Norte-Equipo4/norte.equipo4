using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ArtMarket.Entities.Model;
using ArtMarket.UI.Process;

namespace ArtMarket.UI.Web.Controllers
{
    public class DashboardController : Controller
    {
        private ProductProcess _pp;
        private OrderProcess _op;

        public DashboardController()
        {
            _pp = new ProductProcess();
            _op = new OrderProcess();
        }

        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Charts()
        {
            return View();
        }

        public ActionResult Tables()
        {
            var orders = _op.GetAll();

            return View(orders.OrderByDescending(o => o.OrderDate).ToList());
        }
    }
}