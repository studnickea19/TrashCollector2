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
    public class PickupsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Pickups
        public ActionResult Index()
        {
            var pickup = db.Pickup.Include(p => p.CustomerAddress).Include(p => p.PickUpArea);
            return View(pickup.ToList());
        }

        // GET: Pickups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pickup pickup = db.Pickup.Find(id);
            if (pickup == null)
            {
                return HttpNotFound();
            }
            return View(pickup);
        }

        // GET: Pickups/Create
        public ActionResult Create()
        {
            ViewBag.CustomerAddressID = new SelectList(db.CustomerAddress, "CustomerAddressID", "CustomerAddressID");
            ViewBag.AreaID = new SelectList(db.PickUpArea, "AreaID", "AreaID");
            return View();
        }

        // POST: Pickups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PickupID,CustomerAddressID,PickUpDate,AreaID,PickupCompleted,PickupSuspended")] Pickup pickup)
        {
            if (ModelState.IsValid)
            {
                db.Pickup.Add(pickup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CustomerAddressID = new SelectList(db.CustomerAddress, "CustomerAddressID", "CustomerAddressID", pickup.CustomerAddressID);
            ViewBag.AreaID = new SelectList(db.PickUpArea, "AreaID", "AreaID", pickup.AreaID);
            return View(pickup);
        }

        // GET: Pickups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pickup pickup = db.Pickup.Find(id);
            if (pickup == null)
            {
                return HttpNotFound();
            }
            ViewBag.CustomerAddressID = new SelectList(db.CustomerAddress, "CustomerAddressID", "CustomerAddressID", pickup.CustomerAddressID);
            ViewBag.AreaID = new SelectList(db.PickUpArea, "AreaID", "AreaID", pickup.AreaID);
            return View(pickup);
        }

        // POST: Pickups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PickupID,CustomerAddressID,PickUpDate,AreaID,PickupCompleted,PickupSuspended")] Pickup pickup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pickup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CustomerAddressID = new SelectList(db.CustomerAddress, "CustomerAddressID", "CustomerAddressID", pickup.CustomerAddressID);
            ViewBag.AreaID = new SelectList(db.PickUpArea, "AreaID", "AreaID", pickup.AreaID);
            return View(pickup);
        }

        // GET: Pickups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pickup pickup = db.Pickup.Find(id);
            if (pickup == null)
            {
                return HttpNotFound();
            }
            return View(pickup);
        }

        // POST: Pickups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pickup pickup = db.Pickup.Find(id);
            db.Pickup.Remove(pickup);
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
