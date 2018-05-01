using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrashCollector2.Models;

namespace TrashCollector2.Controllers
{
    public class PickUpAreasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PickUpAreas
        public ActionResult Index()
        {
            return View(db.PickUpArea.ToList());
        }

        // GET: PickUpAreas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PickUpArea pickUpArea = db.PickUpArea.Find(id);
            if (pickUpArea == null)
            {
                return HttpNotFound();
            }
            return View(pickUpArea);
        }

        // GET: PickUpAreas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PickUpAreas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AreaID")] PickUpArea pickUpArea)
        {
            if (ModelState.IsValid)
            {
                db.PickUpArea.Add(pickUpArea);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pickUpArea);
        }

        // GET: PickUpAreas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PickUpArea pickUpArea = db.PickUpArea.Find(id);
            if (pickUpArea == null)
            {
                return HttpNotFound();
            }
            return View(pickUpArea);
        }

        // POST: PickUpAreas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AreaID")] PickUpArea pickUpArea)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pickUpArea).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pickUpArea);
        }

        // GET: PickUpAreas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PickUpArea pickUpArea = db.PickUpArea.Find(id);
            if (pickUpArea == null)
            {
                return HttpNotFound();
            }
            return View(pickUpArea);
        }

        // POST: PickUpAreas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PickUpArea pickUpArea = db.PickUpArea.Find(id);
            db.PickUpArea.Remove(pickUpArea);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
