using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRoutes.Models{

    public class User{

        [Key]
        public int Id {get;set;}
        public string Email {get;set;}
        public string Username {get;set;}
        public string Password {get;set;}
        public DateTime CreateAt {get;set;}
        public DateTime UpdateAt {get;set;}
        
        [ForeignKey("Role")]
        public int RoleFK {get;set;}
        [ForeignKey("RoleFK")]
        public virtual Role Role {get;set;}

    }

}