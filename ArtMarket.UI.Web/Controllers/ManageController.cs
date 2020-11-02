using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ArtMarket.UI.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace ArtMarket.UI.Web.Controllers
{
    [Authorize]
    public class ManageController : Controller
    {
    }
}