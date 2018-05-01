using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashCollector2.Models
{
    public class Pickup
    {
        [Key]
        public int PickupID { get; set; }

        public int CustomerAddressID { get; set; }

        [ForeignKey("CustomerAddressID")]
        public virtual CustomerAddress CustomerAddress { get; set; }
        

        [Display(Name = "Pick Up Date")]
        public DateTime PickUpDate { get; set; }

        
        [Display(Name = "Pick Up Area")]
        public int AreaID { get; set; }

        [ForeignKey("AreaID")]
        public virtual PickUpArea PickUpArea { get; set; }
        

        [Display(Name = "Pick Up Status")]
        public bool PickupCompleted { get; set; }

        public bool PickupSuspended { get; set; }

        //Move To Controller
        //public string DisplayCompletion()
        //{
        //    string pickupStatus;
        //    if (PickupCompleted == true)
        //    {
        //        pickupStatus = "Completed";
        //    }
        //    else
        //    {
        //        pickupStatus = "Pending";
        //    }
        //    return pickupStatus;
        //}

        //public void DisplayPickup()
        //{            
        //    if (PickupSuspended == true)
        //    {
        //        visibility = hidden;
        //    }
        //}
    }
}