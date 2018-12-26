using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required]
        [StringLength(125)]
        public string Name { get; set; }
        //public List<Customer> Customers { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MemberschipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}