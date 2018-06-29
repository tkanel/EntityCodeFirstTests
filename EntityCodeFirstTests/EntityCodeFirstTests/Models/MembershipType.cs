using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityCodeFirstTests.Models
{
    public class MembershipType
    {

        public byte Id { get; set; }

        [Required]
        [StringLength(50)]
        public string MembershipTypeName { get; set; }
        public short SignUpfee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        



    }
}