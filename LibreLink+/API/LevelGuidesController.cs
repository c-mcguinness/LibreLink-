using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using LibreLink_.Models;

namespace LibreLink_.API
{
    public class LevelGuidesController : ApiController
    {
        private LibreModelContext db = new LibreModelContext();

        // GET: api/LevelGuides
        public IQueryable<LevelGuide> GetLevelGuides()
        {
            return db.LevelGuides;
        }

        // GET: api/LevelGuides/5
        [ResponseType(typeof(LevelGuide))]
        public IHttpActionResult GetLevelGuide(int id)
        {
            LevelGuide levelGuide = db.LevelGuides.Find(id);
            if (levelGuide == null)
            {
                return NotFound();
            }

            return Ok(levelGuide);
        }

        // PUT: api/LevelGuides/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLevelGuide(int id, LevelGuide levelGuide)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != levelGuide.LevelGuideId)
            {
                return BadRequest();
            }

            db.Entry(levelGuide).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LevelGuideExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/LevelGuides
        [ResponseType(typeof(LevelGuide))]
        public IHttpActionResult PostLevelGuide(LevelGuide levelGuide)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LevelGuides.Add(levelGuide);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = levelGuide.LevelGuideId }, levelGuide);
        }

        // DELETE: api/LevelGuides/5
        [ResponseType(typeof(LevelGuide))]
        public IHttpActionResult DeleteLevelGuide(int id)
        {
            LevelGuide levelGuide = db.LevelGuides.Find(id);
            if (levelGuide == null)
            {
                return NotFound();
            }

            db.LevelGuides.Remove(levelGuide);
            db.SaveChanges();

            return Ok(levelGuide);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LevelGuideExists(int id)
        {
            return db.LevelGuides.Count(e => e.LevelGuideId == id) > 0;
        }
    }
}