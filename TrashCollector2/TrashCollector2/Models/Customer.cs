using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashCollector2.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string CustomerEmail { get; set; }

        [Display(Name = "Password")]
        public string CustomerPassword { get; set; }

        [Display(Name = "Addresses")]
        public ICollection<Address> UserAddresses { get; set; } //List of Addresses

        [Display(Name = "Pick Ups")]
        public List<Pickup> PickUps { get; set; } //List of Pickups

        [Display(Name = "My Charges")]
        public List<Charge> Charges { get; set; }   //List of Charges

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}