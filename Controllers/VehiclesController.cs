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
    public class VehiclesController : Controller
    {
        
        public RoutesDBContext dbc {get;set;}

        public VehiclesController(RoutesDBContext app){
            this.dbc = app;
        }

        public IActionResult Index()
        {
            ViewBag.Vehicles = dbc.Vehicles.ToList();
            return View();
        }

        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Vehicle veh){
            dbc.Add(veh);
            dbc.SaveChanges();
            return RedirectToAction("Index");
        }
        

    }
}