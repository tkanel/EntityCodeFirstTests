using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityCodeFirstTests.Models
{
    public class customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public bool IsSubscribedToNewletter { get; set; }

        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

    }
}