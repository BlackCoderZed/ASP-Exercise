using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace ASP_Exercise.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public bool isSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}