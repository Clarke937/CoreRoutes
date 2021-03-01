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
    public class AuthController : Controller
    {

        public RoutesDBContext dbc {get;set;}

        public AuthController(RoutesDBContext app){
            this.dbc = app;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Login");
        }

        public IActionResult Login(){
            return View();
        }

        [HttpPost]
        public IActionResult TestLogin(User user){
            
            if(user.Username != null){
                User realuser = dbc.Users.Where(x => x.Username.ToLower().Equals(user.Username.ToLower())).FirstOrDefault();
                if(realuser != null){
                    if(Crypter.CheckPassword(user.Password,realuser.Password)){
                        HttpContext.Session.SetInt32("currentUser",realuser.Id);
                        return RedirectToAction("Index","Home");
                    }
                }
            }
            
            return RedirectToAction("Login");
        }

    }
}