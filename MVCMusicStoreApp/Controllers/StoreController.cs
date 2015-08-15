using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMusicStoreApp.Models;

namespace MVCMusicStoreApp.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities db=new MusicStoreEntities();
        //
        // GET: /Store/
        public ActionResult Index()
        {
            return View(db.Genres.ToList());
        }

        public ActionResult Browse(string genre)
        {
            var genreModel = db.Genres.Include("Albums").Single(g => g.Name == genre);
            return View(genreModel);
        }

        public ActionResult Details(int id)
        {
            var album = db.Albums.Find(id);

            return View(album);
        }
	}
}