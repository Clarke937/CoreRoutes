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

            return View();
        }

        public IActionResult Delete(int id){
            ViewBag.Company = dbc.Companies.Find(id);
            return View();
        }

        public IActionResult Edit(int id){
            ViewBag.Company = dbc.Companies.Find(id);
            return View();
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
        public IActionResult Drop(Company com){
            dbc.Companies.Remove(com);
            dbc.SaveChanges();
            return RedirectToAction("Index");
        }    


        [HttpPost]
        public IActionResult InsertSite(CompanySite Cs){
            Cs.CreateAt = DateTime.Now;
            Cs.UpdateAt = DateTime.Now;
            dbc.CompanySites.Add(Cs);
            dbc.SaveChanges();

            return RedirectToAction("Sites",new {id = Cs.CompanyFK});
        }

    }
}