using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRoutes.Models{

    public class CompanySiteDate{

        public int Id {get;set;}

        //
        [ForeignKey("CompanySite")]
        public int CompanySiteFK {get;set;}
        [ForeignKey("CompanySiteFK")]
        public virtual CompanySite CompanySite {get;set;}
        
        //
        [ForeignKey("Weekday")]
        public int WeekdayFK {get;set;}
        [ForeignKey("WeekdayFK")]
        public virtual Weekday Weekday {get;set;}

    }

}