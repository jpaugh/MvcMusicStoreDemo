using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hello from Store.Index()";
        }

        // GET: /Store/Browse?genre=<string>
        public string Browse(string genre)
        {
            // Sanitize the user input
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);

            return message;
        }

        // GET: /Store/Details/<ID>
        public string Details(int id)
        {
            // Thanks to type-checking, the user input is already sanitizied
            string message = "Store.Details, ID = " + id;
            return message;
        }
    }
}