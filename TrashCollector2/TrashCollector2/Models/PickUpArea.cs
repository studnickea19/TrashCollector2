using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashCollector2.Models
{
    public class PickUpArea
    {
        [Key]
        public int AreaID { get; set; }

        //public List<Zipcodes> {get; set;}
        //If pickuparea.codelist.Contains(address.zipcode)
        //  do stuff
    }
}