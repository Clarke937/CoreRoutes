using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreRoutes.Models{

    public class Websetting{

        public int Id;
        public string Webname {get;set;}
        public double Iva {get;set;}

        

    }

}