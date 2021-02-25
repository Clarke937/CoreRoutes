using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreRoutes.Models;
using CoreRoutes.Models.ViewModels;

namespace CoreRoutes.Controllers
{
    public class CompanyController : Controller
    {

        public RoutesDBContext dbc {get;set;}
        public CompanyController(RoutesDBContext app){
            this.dbc = app;
        }

        public IActionResult Index()
        {
            ViewBag.Companies = dbc.Companies.ToList();
            return View();
        }

        public IActionResult Create(){
            return View();
        }

        public IActionResult Sites(int id){
            ViewBag.Company = dbc.Companies.Find(id);
            ViewBag.Sites = dbc.CompanySites.Where(x => x.CompanyFK == id).ToList();

            //ViewModel
            CompanySitesVM csvm = new CompanySitesVM();
            csvm.IdCompany = id;
            foreach(Weekday w in dbc.Weekdays.ToList()){
                csvm.Weekdays.Add(new CheckboxItem{
                    Id = w.Id,
                    Display = w.DayName,
                    IsChecked = false
                });
            }

            return View(csvm);
        }

        [HttpPost]
        public IActionResult Update(Company com){
            com.UpdateAt = DateTime.Now;
            dbc.Update(com);
            dbc.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Insert(Company com){
            com.CreateAt = DateTime.Now;
            com.UpdateAt = DateTime.Now;
            dbc.Companies.Add(com);
            dbc.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult InsertSite(CompanySitesVM Cs){
            Cs.CompanySite.CreateAt = DateTime.Now;
            Cs.CompanySite.UpdateAt = DateTime.Now;
            dbc.CompanySites.Add(Cs.CompanySite);
            dbc.SaveChanges();
            
            var days = Cs.Weekdays.Where(x => x.IsChecked).Select(x => x.Id).ToList();
            foreach(int id in days){
                dbc.CompanySiteDates.Add(new CompanySiteDate{
                    CompanySiteFK = Cs.CompanySite.CompanyFK,
                    WeekdayFK = id
                });
            }
            dbc.SaveChanges();

            return RedirectToAction("Sites",new{id = Cs.CompanySite.CompanyFK});
        }

    }
}