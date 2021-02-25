using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRoutes.Models{

    public class Route{

        public int Id {get;set;}
        public string RouteName {get;set;}
        public DateTime DeliveryDate {get;set;}
        public int State {get;set;}

        //
        [ForeignKey("User")]
        public int? UserFK {get;set;}
        [ForeignKey("UserFK")]
        public virtual User User {get;set;}

        //
        [ForeignKey("ServiceType")]
        public int ServiceTypeFK {get;set;}
        [ForeignKey("ServiceTypeFK")]
        public virtual ServiceType ServiceType {get;set;}
    }

}