using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class insureeController : Controller
    {
        private insuranceEntities1 db = new insuranceEntities1();

        // GET: insuree
        public ActionResult Index()
        {
            return View(db.insurees.ToList());
        }

        // GET: insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            insuree insuree = db.insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedTickets,CoverageType,Quote")] insuree insuree)
        {

            if (ModelState.IsValid)
            {

                decimal Quotes = 50m;
                int carYear = insuree.CarYear;
                string carMake = insuree.CarMake;
                string carModel = insuree.CarModel;
                int speedingTickets = insuree.SpeedTickets;
                bool DUI = insuree.DUI;
                bool coverageType = insuree.CoverageType;
                var today = DateTime.Today;
                var age = today.Year - insuree.DateOfBirth.Year;
                if (speedingTickets >= 0)
                {
                    Quotes = Quotes + (10 * speedingTickets) ;
                    
                }
                if (age <= 18)
                {
                    Quotes += 100;
                }
                if (age > 19 && age <= 25)
                {
                    Quotes += 50;
                }
                if (age >= 26)
                {
                    Quotes += 25;
                }
                if (carYear < 2000)
                {
                    Quotes += 25;

                }
                if (carYear > 2015)
                {
                    Quotes += 25;
                }
                if (carMake == "porsche")
                {
                    Quotes += 25;
                }
                if (carMake == "porsche" && carModel == "911 carrera")
                {
                    Quotes += 25;
                }
                if (DUI == true)
                {
                    Quotes += Quotes * 1.25m;
                }
                if (coverageType == true)
                {
                    Quotes += Quotes * 0.5m;
                };


                insuree.Quote = Quotes;
                insuree.CarYear = carYear;
                insuree.CarMake = carMake;
                insuree.CarModel = carModel;
                insuree.SpeedTickets = speedingTickets;
                insuree.DUI = DUI;
                insuree.CoverageType = coverageType;

                db.insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            insuree insuree = db.insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedTickets,CoverageType,Quote")] insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            insuree insuree = db.insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            insuree insuree = db.insurees.Find(id);
            db.insurees.Remove(insuree);
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
