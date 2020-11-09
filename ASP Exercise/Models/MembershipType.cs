using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Exercise.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [StringLength(255)]
        public string Type { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonth { get; set; }
        public byte DiscountRate { get; set; }
    }
}