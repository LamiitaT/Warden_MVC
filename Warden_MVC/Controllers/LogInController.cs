using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Warden_MVC.Models;

namespace Warden_MVC.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Authorize(login userModel)
        {
            using (wardenEntities db = new wardenEntities())
            {
                var details = db.login.Where(x => x.username == userModel.username && x.password == userModel.password).FirstOrDefault();
                if(details == null)
                {
                    return View("Index",userModel);
                }
                else
                {
                    Session["username"] = details.username;
                    return RedirectToAction("Index", "All_beacons_");
                }
            }
             
        }
    }
}