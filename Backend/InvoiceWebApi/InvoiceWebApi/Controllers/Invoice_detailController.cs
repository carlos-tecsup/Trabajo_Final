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
using InvoiceWebApi.Models;

namespace InvoiceWebApi.Controllers
{
    public class Invoice_detailController : ApiController
    {
        private Modelo db = new Modelo();

        // GET: api/Invoice_detail
        public IQueryable<Invoice_detail> GetInvoice_detail()
        {
            return db.Invoice_detail;
        }

        // GET: api/Invoice_detail/5
        [ResponseType(typeof(Invoice_detail))]
        public IHttpActionResult GetInvoice_detail(int id)
        {
            Invoice_detail invoice_detail = db.Invoice_detail.Find(id);
            if (invoice_detail == null)
            {
                return NotFound();
            }

            return Ok(invoice_detail);
        }

        // PUT: api/Invoice_detail/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutInvoice_detail(int id, Invoice_detail invoice_detail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != invoice_detail.ID)
            {
                return BadRequest();
            }

            db.Entry(invoice_detail).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Invoice_detailExists(id))
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

        // POST: api/Invoice_detail
        [ResponseType(typeof(Invoice_detail))]
        public IHttpActionResult PostInvoice_detail(Invoice_detail invoice_detail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Invoice_detail.Add(invoice_detail);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = invoice_detail.ID }, invoice_detail);
        }

        // DELETE: api/Invoice_detail/5
        [ResponseType(typeof(Invoice_detail))]
        public IHttpActionResult DeleteInvoice_detail(int id)
        {
            Invoice_detail invoice_detail = db.Invoice_detail.Find(id);
            if (invoice_detail == null)
            {
                return NotFound();
            }

            db.Invoice_detail.Remove(invoice_detail);
            db.SaveChanges();

            return Ok(invoice_detail);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Invoice_detailExists(int id)
        {
            return db.Invoice_detail.Count(e => e.ID == id) > 0;
        }
    }
}