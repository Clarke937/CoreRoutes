using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRoutes.Models{

    public class UserInfo{

        [Key]
        public int Id {get;set; }
        public string Name {get;set;}
        public string Lastname {get;set;}
        public string Fullname {get;set;}
        public string City {get;set;}
        public string Country {get;set;}
        public string Cellphone {get;set;}
        public string Address {get;set;}
        public DateTime Birthday {get;set;}
        public DateTime CreateAt {get;set;}
        public DateTime UpdateAt {get;set;}

        public int UserId {get;set;}
        [ForeignKey("UserId")]
        public virtual User User {get;set;}

    }

}