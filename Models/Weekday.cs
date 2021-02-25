using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRoutes.Models{

    public class Weekday{

        [Key]
        public int Id {get;set;}
        public string DayName {get;set;}

    }


}