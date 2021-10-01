using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using Logic;
using Entities;
using UI_MVC.Models;
using System.ComponentModel.DataAnnotations;

namespace UI_MVC.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic logic = new ShippersLogic();

        // GET: Shippers
        public ActionResult Index()
        {
            var logic = new ShippersLogic();
            List<Shippers> shippers = logic.GetAll<Shippers>();
            List<ShippersViewModel> shippersViewModel = shippers.Select(s => new ShippersViewModel()
            {
                ShipperId = s.ShipperID,
                CompanyName = s.CompanyName,
                PhoneNumber = s.Phone
            }).ToList();

            return View(shippersViewModel);
        }

        public ActionResult InsertUpdate()
        {
            return View();
        }


        [HttpPost]
        public ActionResult InsertUpdate(ShippersViewModel shippersViewModel)
        {
            ModelState["ShipperId"].Errors.Clear();
            if (!ModelState.IsValid)
            {
                return View(shippersViewModel);
            }
            else
            {

                if (shippersViewModel.ShipperId == 0)
                {
                    try
                    {
                        Shippers shipperEntity = new Shippers
                        {
                            CompanyName = shippersViewModel.CompanyName,
                            Phone = shippersViewModel.PhoneNumber
                        };
                        logic.DataCheck<Shippers>(shipperEntity);
                        logic.Add<Shippers>(shipperEntity);
                        return RedirectToAction("Index");
                    }
                    catch (CharacterLimitExceededException ex)
                    {
                        return RedirectToAction("Error", "Shippers", new
                        {
                            exceptionMessage = ex.Message,
                            customMessage = "ERROR"
                        });
                    }
                }
                else
                {
                    try
                    {
                        Shippers updatedShipper = new Shippers(shippersViewModel.ShipperId, shippersViewModel.CompanyName, shippersViewModel.PhoneNumber);
                        logic.DataCheck<Shippers>(updatedShipper);
                        logic.Update<Shippers>(updatedShipper);
                        return RedirectToAction("Index");
                    }
                    catch (CharacterLimitExceededException ex)
                    {
                        return RedirectToAction("Error", "Shippers", new
                        {
                            exceptionMessage = ex.Message,
                            customMessage = "ERROR"
                        });
                    }
                    catch (InvalidOperationException ex)
                    {
                        return RedirectToAction("Error", "Shippers", new
                        {
                            exceptionMessage = ex.Message,
                            customMessage = "this id doesn't exist"
                        });
                    }
                }
            }
        }

        public ActionResult Delete(int idToDelete)
        {
            try
            {
                logic.Delete(idToDelete);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", "Shippers", new
                {
                    exceptionMessage = ex.Message,
                    customMessage = "ERROR"
                });
            }
        }

        [HttpGet]
        public ActionResult Error(string exceptionMessage, string customMessage)
        {
            ViewBag.Error = exceptionMessage;
            ViewBag.Message = customMessage;
            return View();
        }
    }
}