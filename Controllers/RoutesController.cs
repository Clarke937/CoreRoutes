using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreRoutes.Models;

namespace CoreRoutes.Controllers{

    public class RoutesController : Controller{
        
        public RoutesDBContext dbc {get;set;}
        public RoutesController(RoutesDBContext app){
            this.dbc = app;
        }

        public IActionResult Index(){
            
            ViewBag.Routes = dbc.Routes.ToList();
            foreach(Route r in ViewBag.Routes){
                r.ServiceType = dbc.ServiceTypes.Find(r.ServiceTypeFK);
            }

            return View();
        }

        public IActionResult Create(){
            ViewBag.ServiceTypes = dbc.ServiceTypes.ToList();
            return View();
        }

    }
}