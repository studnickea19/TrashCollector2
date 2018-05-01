using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashCollector2.Models

{
    public class Charge
    {
        [Key]
        public int ChargeID { get; set; }

        [Display(Name = "Charge Amount")]
        public double ChargeAmount { get; set; }


        [Display(Name = "Associated Pickup")]
        public int PickupID { get; set; }
        [ForeignKey("PickupID")]
        public virtual Pickup Pickup { get; set; }


        [Display(Name = "Customer ID")]
        public int CustomerID { get; set; }

        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }
    }
}