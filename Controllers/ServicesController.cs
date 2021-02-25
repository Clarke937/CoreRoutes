using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreRoutes.Models;

namespace CoreRoutes.Controllers
{
    public class ServicesController : Controller
    {
        
        public RoutesDBContext dbc {get;set;}

        public ServicesController(RoutesDBContext app){
            this.dbc = app;
        }

        public IActionResult Index()
        {
            ViewBag.ServicesTypes = dbc.ServiceTypes.ToList();
            return View();
        }

        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Insert(ServiceType ser){
            ser.CreateAt = DateTime.Now;
            ser.UpdateAt = DateTime.Now;
            dbc.ServiceTypes.Add(ser);
            dbc.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}