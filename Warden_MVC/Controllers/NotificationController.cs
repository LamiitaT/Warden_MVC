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
        public ViewResult Index(int? page)
        {
            
            List<notifications> notification_list = new List<notifications>();
            using (wardenEntities wardenEntity = new wardenEntities())
            {
                notification_list = wardenEntity.notifications.ToList<notifications>();
            }
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(notification_list.ToPagedList(pageNumber,pageSize));
          
        }
        public ActionResult Gethistory()
        {
            List<history> history_list = new List<history>();
            using (wardenEntities wardenEntity = new wardenEntities())
            {
                history_list = wardenEntity.history.ToList<history>();
            }
            return View(history_list);


        }
        public ActionResult getall()
        {
            return PartialView();
        }
        public IList<notifications> getnotifications()
        {
           
            List<notifications> history_list = new List<notifications>();
            using (wardenEntities wardenEntity = new wardenEntities())
            {
                history_list = wardenEntity.notifications.ToList<notifications>();
            }
            return history_list;
        }
        public ActionResult SelectStatus()
        {
            return View();
        }
    }
}