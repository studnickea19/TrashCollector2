using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashCollector2.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Display(Name = "First Name")]
        public string EmployeeFirstName { get; set; }

        [Display(Name = "Last Name")]
        public string EmployeeLastName { get; set; }

        
        [Display(Name = "Pick Up Area")]
        public int AreaID { get; set; }
        [ForeignKey("AreaID")]
        public virtual PickUpArea PickUpArea { get; set; }
        

        [ForeignKey("PickupID")]        
        public virtual List<Pickup> Pickup { get; set; }
        [Display(Name = "Scheduled Pick Ups")]
        public int PickupID { get; set; }
    }
}