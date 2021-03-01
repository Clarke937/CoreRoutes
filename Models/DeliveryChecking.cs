using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRoutes.Models{

    public class DeliveryChecking{

        public int Id {get;set;}
        public DateTime DeliveryDate {get;set;}

        //
        [ForeignKey("User")]
        public int UserFK {get;set;}
        [ForeignKey("UserFK")]
        public virtual User User {get;set;}

        //
        [ForeignKey("DeliveryState")]
        public int DeliveryStateFK {get;set;}
        [ForeignKey("DeliveryStateFK")]
        public virtual DeliveryState DeliveryState {get;set;}

        //
        [ForeignKey("ServiceType")]
        public int ServiceTypeFK {get;set;}
        
        [ForeignKey("ServiceTypeFK")]
        public virtual ServiceType ServiceType {get;set;}


        

    }

}