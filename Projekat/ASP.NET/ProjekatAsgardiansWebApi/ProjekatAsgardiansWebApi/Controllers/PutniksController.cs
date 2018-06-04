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
    public class PutniksController : ApiController
    {
        private AsgardiansModel db = new AsgardiansModel();

        // GET: api/Putniks
        public IQueryable<Putnik> GetPutniks()
        {
            return db.Putniks;
        }

        // GET: api/Putniks/5
        [ResponseType(typeof(Putnik))]
        public async Task<IHttpActionResult> GetPutnik(int id)
        {
            Putnik putnik = await db.Putniks.FindAsync(id);
            if (putnik == null)
            {
                return NotFound();
            }

            return Ok(putnik);
        }

        // PUT: api/Putniks/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPutnik(int id, Putnik putnik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != putnik.PutnikId)
            {
                return BadRequest();
            }

            db.Entry(putnik).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PutnikExists(id))
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

        // POST: api/Putniks
        [ResponseType(typeof(Putnik))]
        public async Task<IHttpActionResult> PostPutnik(Putnik putnik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Putniks.Add(putnik);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = putnik.PutnikId }, putnik);
        }

        // DELETE: api/Putniks/5
        [ResponseType(typeof(Putnik))]
        public async Task<IHttpActionResult> DeletePutnik(int id)
        {
            Putnik putnik = await db.Putniks.FindAsync(id);
            if (putnik == null)
            {
                return NotFound();
            }

            db.Putniks.Remove(putnik);
            await db.SaveChangesAsync();

            return Ok(putnik);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PutnikExists(int id)
        {
            return db.Putniks.Count(e => e.PutnikId == id) > 0;
        }
    }
}