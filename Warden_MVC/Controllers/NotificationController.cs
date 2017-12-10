using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Warden_MVC.Models;
using PagedList;

namespace Warden_MVC.Controllers
{
    public class NotificationController : Controller
    {
        // GET: Notification
        public ViewResult Index()
        {
            return View();
          
        }
        public ActionResult ListNotif(int? page)
        {
            List<notifications> notification_list = new List<notifications>();
            using (wardenEntities wardenEntity = new wardenEntities())
            {
                notification_list = wardenEntity.notifications.ToList<notifications>();
            }

            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(notification_list.ToPagedList(pageNumber, pageSize));
        }
        public ViewResult Gethistory()
        {
            return View();
        }
        public ActionResult ListHistory(int? page)
        {
            List<history> history_list = new List<history>();
            using (wardenEntities wardenEntity = new wardenEntities())
            {
                history_list = wardenEntity.history.ToList<history>();
            }

            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(history_list.ToPagedList(pageNumber, pageSize));
        }
        public void Seen(int id)
        {
            notifications notification = new notifications();
            history h = new history();
            using (wardenEntities wardenEntity = new wardenEntities())
            {
                notification = wardenEntity.notifications.Where(x => x.idn == id).FirstOrDefault();
                wardenEntity.notifications.Remove(notification);
                h.idn = id;
                h.idb = notification.idb;
                h.ninfo = notification.ninfo;
                h.ntype = notification.ntype;
                h.status = this.HttpContext.User.Identity.Name;
                h.time = notification.time;
                wardenEntity.history.Add(h);
                wardenEntity.SaveChanges();
            }
            
        }
        public ActionResult SelectStatus()
        {
            return View();
        }
    }
}