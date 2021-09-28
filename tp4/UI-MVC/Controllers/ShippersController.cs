using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data;
using Logic;
using Entities;
using UI_MVC.Models;

namespace UI_MVC.Controllers
{
    public class ShippersController : Controller
    {
        // GET: Shippers
        public ActionResult Index()
        {
            var logic = new ShippersLogic();
            List<Shippers> shippers = logic.GetAll<Shippers>();
            List<ShippersViewModel> shippersViewModel = shippers.Select(s => new ShippersViewModel()
            {
                CompanyName = s.CompanyName,
                PhoneNumber = s.Phone
            }).ToList();

            return View(shippersViewModel);
        }

        public ActionResult InsertUpdate()
        {
            return View();
        }
    }
}