using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRoutes.Models{

    public class PickedRoute{

        public int Id {get;set;}

        public int RouteFK {get;set;}
        public virtual Route Route {get;set;}

        public int UserFK {get;set;}
        public virtual User User {get;set;}
    

    }

}