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

        
        [HttpGet]
        public IActionResult Edit(int id){
            ViewBag.Vehicle = dbc.Vehicles.Find(id);
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id){
            ViewBag.Vehicle = dbc.Vehicles.Find(id);
            return View();
        }


        [HttpPost]
        public IActionResult Insert(Vehicle veh){
            dbc.Add(veh);
            dbc.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Vehicle ve){
            dbc.Vehicles.Update(ve);
            dbc.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Drop(Vehicle ve){
            dbc.Vehicles.Remove(ve);
            dbc.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}