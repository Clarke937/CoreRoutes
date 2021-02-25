using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRoutes.Models{

    public class CompanySite{

        [Key]
        public int Id {get;set;}
        public string SiteName {get;set;}
        public string State {get;set;}
        public string City {get;set;}
        public string Address {get;set;}
        public string PostalCode {get;set;}
        public string Contact {get;set;}
        public string Phone {get;set;}
        public DateTime CreateAt {get;set;}
        public DateTime UpdateAt {get;set;}


        //FK1
        [ForeignKey("Company")]
        public int CompanyFK {get;set;}
        [ForeignKey("CompanyFK")]
        public virtual Company Company {get;set;}


    }

}