using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Store/Browse?genre=<string>
        public string Browse(string genre)
        {
            // Sanitize the user input
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);

            return message;
        }

        // GET: /Store/Details/<ID>
        public ActionResult Details(int id)
        {
            // Thanks to type-checking, the user input is already sanitizied
            var album = new Album { Title = "Album " + id };

            return View(album);
        }
    }
}