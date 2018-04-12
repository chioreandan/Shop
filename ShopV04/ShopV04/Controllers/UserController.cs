using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopV04;

namespace ShopV04.Controllers
{
    public class UserController : Controller
    {
        shopEntities db = new shopEntities();
        // GET: User
        public ActionResult Users()
        {
            ViewBag.Message = db.users.ToList();
            return View();
        }
    }
}