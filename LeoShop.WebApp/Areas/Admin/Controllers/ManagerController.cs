using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeoShop.Data.Models;

namespace LeoShop.WebApp.Areas.Admin.Controllers
{
    public class ManagerController : Controller
    {
        private LeoShopContext db = new LeoShopContext();
        // GET: Admin/Manager
        public ActionResult Index()
        {
            if (Session["ManagerId"] == null)
                return RedirectToAction("Login","Login");
            return View(db.HoaDons);
        }

    }
}