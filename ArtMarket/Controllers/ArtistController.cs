using ArtMarket.Controllers;
using BusinessLogic;
using BusinessLogic.Contracts;
using Common.Entities;
using System;
using System.Web.Mvc;

namespace ComprasOnline.Controllers
{
	public class ArtistController : BaseController
	{
		public IArtistManagement ArtistManagement { get; set; }

		public ArtistController()
		{
			ArtistManagement = new ArtistManagement();
		}

		// GET: Artist
		public ActionResult Index()
		{
			return View(ArtistManagement.GetAll());
		}

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Create(FormCollection form)
		{
			var artist = new Artist();

			artist.FirstName = form["firstName"];
			artist.LastName = form["lastName"];
			artist.LifeSpan = form["lifeSpan"];
			artist.Country = form["country"];
			artist.Description = form["description"];
			artist.TotalProducts = Convert.ToInt32(form["totalProducts"]);

			CheckAuditPattern(artist, true);
			ArtistManagement.Add(artist);

			return RedirectToAction("Index", "Home");
		}

		public ActionResult Modify(int id)
		{
			Artist artist = ArtistManagement.Get(id);
			return View(artist);
		}


		[HttpPost]
		public ActionResult DoUpdate(Artist artist)
		{
			CheckAuditPattern(artist);
			ArtistManagement.Update(artist);
			return RedirectToAction("Index");
		}

		public ActionResult Delete(int id)
		{
			ArtistManagement.Delete(id);
			return RedirectToAction("Index");
		}
	}
}