﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ArtMarket.Business;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            try
            {
                //TODO Coneccion a a BD
                /*
                  if (db.SEC_User.Where(x => x.UserName == user.UserName && x.IsActive).Any())
                  {
                      StringCypher sc = new StringCypher();
                      var realUser = db.SEC_User.Where(x => x.UserName == user.UserName && x.IsActive).First();


                      var psw = sc.DesEncriptar(realUser.Password);
                      if (psw == user.Password)
                      {
                          FormsAuthentication.SetAuthCookie(user.UserName, false);
                          return RedirectToAction("Index", "Home");
                      }
                      sc = null;
                  }
                  */
                var psw = "Metodo Que va a la bd a buscar el password de usuario";
                if (psw == user.Password)
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    return RedirectToAction("Index", "Home");
                }

                ViewBag.ErrorMessage = "Los datos ingresados no son correctos";
                return View(user);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Los datos ingresados no son correctos, Error.";
                return View(user);
            }
        }

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}