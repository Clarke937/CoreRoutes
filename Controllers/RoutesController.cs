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
            
            ViewBag.Weekdays = dbc.Weekdays.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Route route){
            dbc.Add(route);
            dbc.SaveChanges();
            return RedirectToAction("Sites",new {id = route.WeekdayFK});
        }

        public IActionResult Sites(int id){
            ViewBag.Weekday = dbc.Weekdays.Find(id);
            ViewBag.Companies = dbc.Companies.ToList();
            ViewBag.ServiceTypes = dbc.ServiceTypes.ToList();
            ViewBag.Routes = dbc.Routes.Where(x => x.WeekdayFK == id).OrderBy(x => x.ServiceTypeFK).ToList();

            if(ViewBag.Routes.Count > 0){
                foreach(Route r in ViewBag.Routes){
                    r.CompanySite = dbc.CompanySites.Find(r.CompanySiteFK);
                    r.ServiceType = dbc.ServiceTypes.Find(r.ServiceTypeFK);
                }
            }

            if(ViewBag.Companies.Count > 0){
                int FKCompany = ((List<Company>)ViewBag.Companies)[0].Id;
                ViewBag.Sites = dbc.CompanySites.Where(x => x.CompanyFK == FKCompany).ToList();
            }
            
            return View();
        }

        public JsonResult CompanySitesResult(int idcompany){
            List<CompanySite> Sites = dbc.CompanySites.Where(x => x.CompanyFK == idcompany).ToList();
            return Json(Sites);
        }


    }
}