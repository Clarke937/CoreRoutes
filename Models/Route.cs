using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRoutes.Models{

    public class Route{

        public int Id {get;set;}
        
        //
        [ForeignKey("CompanySite")]
        public int CompanySiteFK {get;set;}
        [ForeignKey("CompanySiteFK")]
        public CompanySite CompanySite {get;set;} 


        //
        [ForeignKey("Weekday")]
        public int WeekdayFK {get;set;}
        [ForeignKey("WeekdayFK")]
        public Weekday Weekday {get;set;}


        //
        [ForeignKey("ServiceType")]
        public int ServiceTypeFK {get;set;}
        [ForeignKey("ServiceTypeFK")]
        public ServiceType ServiceType {get;set;}

    }

}