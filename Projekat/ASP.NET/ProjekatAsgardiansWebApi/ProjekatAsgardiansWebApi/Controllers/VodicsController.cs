using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ProjekatAsgardiansWebApi.Models;

namespace ProjekatAsgardiansWebApi.Controllers
{
    public class VodicsController : ApiController
    {
        private AsgardiansModel db = new AsgardiansModel();

        // GET: api/Vodics
        public IQueryable<Vodic> GetVodics()
        {
            return db.Vodics;
        }

        // GET: api/Vodics/5
        [ResponseType(typeof(Vodic))]
        public async Task<IHttpActionResult> GetVodic(int id)
        {
            Vodic vodic = await db.Vodics.FindAsync(id);
            if (vodic == null)
            {
                return NotFound();
            }

            return Ok(vodic);
        }

        // PUT: api/Vodics/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVodic(int id, Vodic vodic)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vodic.VodicId)
            {
                return BadRequest();
            }

            db.Entry(vodic).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VodicExists(id))
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

        // POST: api/Vodics
        [ResponseType(typeof(Vodic))]
        public async Task<IHttpActionResult> PostVodic(Vodic vodic)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Vodics.Add(vodic);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = vodic.VodicId }, vodic);
        }

        // DELETE: api/Vodics/5
        [ResponseType(typeof(Vodic))]
        public async Task<IHttpActionResult> DeleteVodic(int id)
        {
            Vodic vodic = await db.Vodics.FindAsync(id);
            if (vodic == null)
            {
                return NotFound();
            }

            db.Vodics.Remove(vodic);
            await db.SaveChangesAsync();

            return Ok(vodic);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VodicExists(int id)
        {
            return db.Vodics.Count(e => e.VodicId == id) > 0;
        }
    }
}