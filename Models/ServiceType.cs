using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreRoutes.Models;

namespace CoreRoutes.Models
{   
    public class ServiceType{

        [Key]
        public int Id {get;set;}
        public string ServiceName {get;set;}
        public double Price {get;set;}

        public DateTime CreateAt {get;set;}
        public DateTime UpdateAt {get;set;}
        
        [ForeignKey("Vehicle")]
        public int VehicleFK {get;set;}
        [ForeignKey("VehicleFK")]
        public virtual Vehicle Vehicle {get;set;}


    }
}