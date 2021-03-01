using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreRoutes.Models;
using CryptSharp.Core;
using Microsoft.AspNetCore.Http;
using System.Text.Json.Serialization;


namespace CoreRoutes.Controllers
{
    public class HomeController : Controller
    {

        public RoutesDBContext dbc {get;set;}
        public User currentUser {get;set;}

        public HomeController(RoutesDBContext app){
            this.dbc = app;
        }

        public IActionResult Index()
        {
            if(!HttpContext.Session.GetInt32("currentUser").HasValue){
                return RedirectToAction("Index","Auth");
            }

            return View();
        }
    }
}
