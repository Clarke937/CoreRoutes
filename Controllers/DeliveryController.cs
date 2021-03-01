using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreRoutes.Models;
using CoreRoutes.Models.ViewModels;
using CryptSharp.Core;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CoreRoutes.Controllers
{
    public class DeliveryController : Controller
    {

        public RoutesDBContext dbc {get;set;}

        public DeliveryController(RoutesDBContext app){
            this.dbc = app;
        }

        public IActionResult Index()
        {
            ViewBag.Deliveries = dbc.DeliveryCheckings.ToList();
            foreach(DeliveryChecking del in ViewBag.Deliveries){
                del.User = dbc.Users.Find(del.UserFK);
                del.ServiceType = dbc.ServiceTypes.Find(del.ServiceTypeFK);
                del.DeliveryState = dbc.DeliveryStates.Find(del.DeliveryStateFK);
            }
            return View();
        }

        

    }
}