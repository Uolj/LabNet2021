using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Data;
using Entities;

namespace tp8WebApiRest.Controllers
{
    public class ShippersApiController : ApiController
    {
        private NorthwindContext context = new NorthwindContext();

        [HttpGet]
        public IEnumerable<Shippers> Get()
        {

            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Shippers.ToList();
            }
        }

        [HttpGet]
        public Shippers Get(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Shippers.FirstOrDefault(s => s.ShipperID == id);
            }
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] Shippers shipper)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.Shippers.Add(shipper);
                    context.SaveChanges();
                    return Ok(shipper);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public IHttpActionResult Update(int id, [FromBody] Shippers shipper)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var shipperExists = context.Shippers.Count(s => s.ShipperID == id) > 0;

                    if (shipperExists)
                    {
                        context.Entry(shipper).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();

                        return Ok();
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var shipper = context.Shippers.Find(id);
                if (shipper != null)
                {
                    context.Shippers.Remove(shipper);
                    context.SaveChanges();

                    return Ok(shipper);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }
        }
    }


}
