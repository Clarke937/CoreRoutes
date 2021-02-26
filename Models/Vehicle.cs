using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRoutes.Models{

    public class Vehicle{

        [Key]
        public int Id {get;set;}
        public string VehicleName {get;set;}

    }


}