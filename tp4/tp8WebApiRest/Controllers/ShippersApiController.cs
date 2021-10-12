using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Data;
using Entities;
using Logic;
using tp8WebApiRest.Models;
using System.Web.Http.Cors;

namespace tp8WebApiRest.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class ShippersApiController : ApiController
    {
        public ShippersLogic logic = new ShippersLogic();

        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                List<ShippersResponse> shippersResponse;
                var shippers = logic.GetAll<Shippers>();

                shippersResponse = shippers.Select(s => new ShippersResponse
                {
                    ShipperID = s.ShipperID,
                    Phone = s.Phone,
                    CompanyName = s.CompanyName

                }).ToList();

                return Ok(shippersResponse);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {
                var shippers = logic.GetAll<Shippers>();
                Shippers shipperToMap = shippers.Find(s => s.ShipperID == id);

                if (shipperToMap == null)
                {
                    return NotFound();
                }
                else
                {
                    ShippersResponse shippersResponse = new ShippersResponse
                    {
                        ShipperID = shipperToMap.ShipperID,
                        Phone = shipperToMap.Phone,
                        CompanyName = shipperToMap.CompanyName
                    };

                    return Ok(shippersResponse);
                }

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        public IHttpActionResult Add([FromBody] ShippersRequest shippersRequest)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Shippers shipperToInsert = new Shippers
                    {
                        ShipperID = shippersRequest.ShipperID,
                        Phone = shippersRequest.Phone,
                        CompanyName = shippersRequest.CompanyName
                    };

                    logic.Add<Shippers>(shipperToInsert);
                    return Ok(shipperToInsert);
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
        public IHttpActionResult Update(int id, [FromBody] ShippersRequest shippersRequest)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool shipperExists = logic.GetAll<Shippers>().Exists(s => s.ShipperID == id);

                    if (shipperExists)
                    {
                        Shippers updatedShipper = new Shippers
                        {
                            ShipperID = shippersRequest.ShipperID,
                            Phone = shippersRequest.Phone,
                            CompanyName = shippersRequest.CompanyName
                        };

                        logic.Update<Shippers>(updatedShipper);

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
                var shipperToDelete = logic.GetAll<Shippers>().Find(s => s.ShipperID == id);
                if (shipperToDelete != null)
                {
                    logic.Delete(id);

                    return Ok(shipperToDelete);
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
