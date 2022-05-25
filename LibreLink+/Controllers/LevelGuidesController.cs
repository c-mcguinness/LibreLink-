using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LibreLink_.Models;

namespace LibreLink_.Controllers
{
    public class LevelGuidesController : Controller
    {
        private LibreModelContext db = new LibreModelContext();

        // GET: LevelGuides
        public ActionResult Index()
        {
            return View(db.LevelGuides.ToList());
        }

        // GET: LevelGuides/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LevelGuide levelGuide = db.LevelGuides.Find(id);
            if (levelGuide == null)
            {
                return HttpNotFound();
            }
            return View(levelGuide);
        }

        // GET: LevelGuides/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LevelGuides/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LevelGuideId,LevelGuideColour,LevelGuideBounder")] LevelGuide levelGuide)
        {
            if (ModelState.IsValid)
            {
                db.LevelGuides.Add(levelGuide);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(levelGuide);
        }

        // GET: LevelGuides/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LevelGuide levelGuide = db.LevelGuides.Find(id);
            if (levelGuide == null)
            {
                return HttpNotFound();
            }
            return View(levelGuide);
        }

        // POST: LevelGuides/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LevelGuideId,LevelGuideColour,LevelGuideBounder")] LevelGuide levelGuide)
        {
            if (ModelState.IsValid)
            {
                db.Entry(levelGuide).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(levelGuide);
        }

        // GET: LevelGuides/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LevelGuide levelGuide = db.LevelGuides.Find(id);
            if (levelGuide == null)
            {
                return HttpNotFound();
            }
            return View(levelGuide);
        }

        // POST: LevelGuides/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LevelGuide levelGuide = db.LevelGuides.Find(id);
            db.LevelGuides.Remove(levelGuide);
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
