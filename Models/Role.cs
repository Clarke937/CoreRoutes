using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRoutes.Models{

    public class Role{

        [Key]
        public int Id {get;set;}
        public string UserRole {get;set;}
        public DateTime CreateAt {get;set;}
        public DateTime UpdateAt {get;set;}

    }

}