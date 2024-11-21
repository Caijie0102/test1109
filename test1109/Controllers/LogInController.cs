using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test1109.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Verify(FormCollection obj)
        {
            ViewBag.Account = obj["account"];
            ViewBag.Password = obj["password"];

            return View();
        }
    }
}