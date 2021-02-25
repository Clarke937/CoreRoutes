using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CoreRoutes.Models{

    public class Company{

        [Key]
        public int Id {get;set;}
        public string CompanyName {get;set;}
        public string Country {get;set;}
        public string CentralAddress {get;set;}
        public string Email {get;set;}
        public string Phone {get;set;}
        public DateTime CreateAt {get;set;}
        public DateTime UpdateAt {get;set;}

    }

}