using System;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;
using ArtMarket.Entities.Model;
using ArtMarket.UI.Web.Models;

namespace ArtMarket.UI.Web.Controllers
{
	[Authorize]
	public class AccountController : Controller
	{
		//
		// GET: /Account/Login
		[AllowAnonymous]
		public ActionResult Login(string returnUrl)
		{
			ViewBag.ReturnUrl = returnUrl;

			return View(new LoginViewModel());
		}

		//
		// POST: /Account/Login
		[HttpPost]
		[AllowAnonymous]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}

			// TODO: pegarle a la API para intentar loguearse
            if (model.Password == "Hola1!")
            {
                FormsAuthentication.SetAuthCookie(model.Email, false);

                return RedirectToAction("Index", "Home");
			}
            else
            {
                ModelState.AddModelError("", "Inicio de sesión fallido: credenciales inválidas.");

                return View(model);
			}
        }

		//
		// GET: /Account/Register
		[AllowAnonymous]
		public ActionResult Register()
		{
			return View(new RegisterViewModel());
		}

		//
		// POST: /Account/Register
		[HttpPost]
		[AllowAnonymous]
		[ValidateAntiForgeryToken]
		public async Task<ActionResult> Register(RegisterViewModel model)
		{
			if (ModelState.IsValid)
			{
				if (model.Password != model.ConfirmPassword)
                {
                    ModelState.AddModelError("", "Las contraseñas no coinciden.");
                    return View(model);
                }

				var user = new User();
                user.Email = model.Email;
                user.Password = model.Password;
                user.Country = "Argentina";
                user.OrderCount = 0;
				user.SignUpDate = DateTime.Now;

				//
				// TODO: Intentar registrar pegándole a la API. Manejar errores.
				//

                return RedirectToAction("Index", "Home");
			}

			// Algo falló, redibujamos formulario
			return View(model);
		}

		//
		// POST: /Account/LogOff
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult LogOff()
		{
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
		}

		public ActionResult LoginLogout()
		{
			if (User.Identity.IsAuthenticated)
			{
                FormsAuthentication.SignOut();

                return RedirectToAction("Index", "Home");
			}

			return RedirectToAction("Login");
		}
    }
}