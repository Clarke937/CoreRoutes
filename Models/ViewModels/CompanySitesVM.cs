using System;
using System.Collections.Generic;

namespace CoreRoutes.Models.ViewModels{

    public class CompanySitesVM {

        public int IdCompany {get;set;}
        public CompanySite CompanySite {get;set;}
        public List<CheckboxItem> Weekdays {get;set;}

        public CompanySitesVM(){
            Weekdays = new List<CheckboxItem>();
        }

    }

}