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
            foreach(ServiceType se in ViewBag.ServicesTypes){
                se.Vehicle = dbc.Vehicles.Find(se.VehicleFK);
            }
            return View();
        }

        public IActionResult Create(){
            ViewBag.Vehicles = dbc.Vehicles.ToList();
            return View();
        }

        public IActionResult Edit(int id){
            ViewBag.Vehicles = dbc.Vehicles.ToList();
            ViewBag.Service = dbc.ServiceTypes.Find(id);
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

        [HttpPost]
        public IActionResult Update(ServiceType ser){
            dbc.ServiceTypes.Update(ser);
            dbc.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}