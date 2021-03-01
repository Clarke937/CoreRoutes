using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreRoutes.Models;
using CoreRoutes.Models.ViewModels;
using Microsoft.AspNetCore.Http;

namespace CoreRoutes.Controllers
{
    public class ChooseController : Controller
    {
        public RoutesDBContext dbc {get;set;}
        public User currentUser {get;set;}

        public ChooseController(RoutesDBContext app){
            this.dbc = app;
        }

        [HttpGet]
        public IActionResult Index(string date = null, int service = 0){
            ViewBag.Services = dbc.ServiceTypes.ToList();
            ViewBag.SearchRoutes = new List<Route>();

            if(HttpContext.Session.GetInt32("currentUser").HasValue){
                currentUser = dbc.Users.Find(HttpContext.Session.GetInt32("currentUser"));
            }
            
            if(currentUser != null && currentUser.RoleFK == 3){
                currentUser.Role = dbc.Roles.Find(currentUser.RoleFK);
                ViewBag.Driver = currentUser;
            }else{
                return RedirectToAction("Notfound");
            }
            
            
            if(date != null && service != 0){
                DateTime searchdate = DateTime.Parse(date);
                int weekdayfk = searchdate.DayOfWeek == 0 ? 7 : (int) searchdate.DayOfWeek;
                ViewBag.SearchRoutes = dbc.Routes.Where(x => x.WeekdayFK == weekdayfk && x.ServiceTypeFK == service).ToList();
                ViewBag.SearchDate = searchdate;

                for(int i = 0; i < ViewBag.SearchRoutes.Count; i++){
                    Route route = ViewBag.SearchRoutes[i];
                    CompanySite site = dbc.CompanySites.Find(route.CompanySiteFK);
                    ServiceType ser = dbc.ServiceTypes.Find(route.ServiceTypeFK);
                    ViewBag.SearchRoutes[i].CompanySite = site;
                    ViewBag.SearchRoutes[i].ServiceType = ser;
                }

                DeliveryChecking dcheck = dbc.DeliveryCheckings.Where(x => x.DeliveryDate.Date == searchdate.Date && x.ServiceTypeFK == service).FirstOrDefault();
                if(dcheck == null){
                    ViewBag.RouteState = dbc.DeliveryStates.Find(1);
                }else{
                    ViewBag.RouteState = dbc.DeliveryStates.Find(dcheck.DeliveryStateFK);
                    ViewBag.RouteUser = dbc.Users.Find(dcheck.UserFK);
                }
            }

            return View();
        }


        public IActionResult Notfound(){
            return View();
        }


        [HttpPost]
        public IActionResult ChooseDelivery(DeliveryChecking del){
            del.DeliveryState = dbc.DeliveryStates.Find(2);
            dbc.DeliveryCheckings.Add(del);
            dbc.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}