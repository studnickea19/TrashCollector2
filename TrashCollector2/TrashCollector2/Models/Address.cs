using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashCollector2.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Zipcode")]
        public int ZipCode { get; set; }
        
        [Display(Name ="Address")]
        public string FullAddress
        {
            get
            {
                return StreetAddress + " " + City + ", " + State + " " + ZipCode;
            }
        }
    }
}