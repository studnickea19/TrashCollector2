using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrashCollector2.Models
{
    public class CustomerAddress
    {
        [Key]
        public int CustomerAddressID { get; set; }
        public Address Address { get; set; }

        public Customer Customer { get; set; }
    }
}