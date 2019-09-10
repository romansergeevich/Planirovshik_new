using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
   
        public class PlanController : Controller
        {
            private PlanContext db = new PlanContext();

            //
            // GET: /Products/

            public ActionResult Index()
            {
                return View(db.Plans.ToList());
            }

            //
            // GET: /Products/Details/5

            public ActionResult Details(int id = 0)
            {
                Plan product = db.Plans.Find(id);
                if (product == null)
                {
                    return HttpNotFound();
                }
                return View(product);
            }

            //
            // GET: /Products/Create

            public ActionResult Create()
            {
                return View();
            }

            //
            // POST: /Products/Create

            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Create(Plan plan)
            {
                if (ModelState.IsValid)
                {
                    db.Plans.Add(plan);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(plan);
            }

            //
            // GET: /Products/Edit/5

            public ActionResult Edit(int id = 0)
            {
                Plan plan = db.Plans.Find(id);
                if (plan == null)
                {
                    return HttpNotFound();
                }
                return View(plan);
            }

            //
            // POST: /Products/Edit/5

            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Edit(Plan plan)
            {
                if (ModelState.IsValid)
                {
                    db.Entry(plan).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(plan);
            }

            //
            // GET: /Products/Delete/5

            public ActionResult Delete(int id = 0)
            {
                Plan plan = db.Plans.Find(id);
                if (plan == null)
                {
                    return HttpNotFound();
                }
                return View(plan);
            }

            //
            // POST: /Products/Delete/5

            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public ActionResult DeleteConfirmed(int id)
            {
                Plan plan = db.Plans.Find(id);
                db.Plans.Remove(plan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            protected override void Dispose(bool disposing)
            {
                db.Dispose();
                base.Dispose(disposing);
            }
        }
    }