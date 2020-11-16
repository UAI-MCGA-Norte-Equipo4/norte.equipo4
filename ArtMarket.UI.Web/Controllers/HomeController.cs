using System.Web.Mvc;

namespace ArtMarket.UI.Web.Controllers
{
	public class HomeController : Controller
	{
        //public IProductManagement ProductManagement { get; set; }

        public HomeController()
        {
            //ProductManagement = new ProductManagement();
        }

        public ActionResult Index()
        {
            //var products = ProductManagement.GetAllProducts().OrderByDescending(x => x.CreatedBy).Take(4);
            //return View(products.ToList());

            return View();
        }

        public ActionResult Example()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}