using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreRoutes.Models;

namespace CoreRoutes.Controllers{

    public class UsersController : Controller{

        public RoutesDBContext dbc {get;set;}

        public UsersController(RoutesDBContext app){
            this.dbc = app;
        }

        public IActionResult Index(string search = null){
            if(search == null){
                ViewBag.Users = dbc.Users.ToList();
            }else{
                ViewBag.Users = dbc.Users.Where(x => x.Username.ToLower().Contains(search.ToLower()) || x.Email.ToLower().Contains(search.ToLower())).ToList();
            }
            
            
            foreach(User u in ViewBag.Users){
                u.Role = dbc.Roles.Find(u.RoleFK);
            }


            return View();
        }

        public IActionResult Edit(int id){
            ViewBag.Roles = dbc.Roles.ToList();
            ViewBag.User = dbc.Users.Find(id);
            
            return View();
        }

    }

}