using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Warden_MVC.Models;

namespace Warden_MVC.Controllers
{
    public class All_beacons_Controller : Controller
    {
        // GET: All_beacons_
        public ActionResult Index()
        {
            List<all_beacons> all_beacons_list = new List<all_beacons>();
            using (wardenEntities wardenEntity = new wardenEntities())
            {
                all_beacons_list = wardenEntity.all_beacons.ToList<all_beacons>();
            }
            return View(all_beacons_list);
        }

        // GET: All_beacons_/Details/5
        public ActionResult Details(int id)
        {
            all_beacons all_beacons_model = new all_beacons();
            using (wardenEntities wardenEntity = new wardenEntities())
            {
                all_beacons_model = wardenEntity.all_beacons.Where(x => x.idb == id).FirstOrDefault();
            }
            return View(all_beacons_model);
        }

        // GET: All_beacons_/Create
        public ActionResult Create()
        {
            return View(new all_beacons());
        }

        // POST: All_beacons_/Create
        [HttpPost]
        public ActionResult Create(all_beacons all_beacons_model)
        {
            using (wardenEntities wardenEntity = new wardenEntities())
            {
                wardenEntity.all_beacons.Add(all_beacons_model);
                wardenEntity.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: All_beacons_/Edit/5
        public ActionResult Edit(int id)
        {
            all_beacons all_beacons_model = new all_beacons();
            using (wardenEntities wardenEntity = new wardenEntities())
            {
                all_beacons_model = wardenEntity.all_beacons.Where(x => x.idb == id).FirstOrDefault();
            }
            return View(all_beacons_model);
        }

        // POST: All_beacons_/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: All_beacons_/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: All_beacons_/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
