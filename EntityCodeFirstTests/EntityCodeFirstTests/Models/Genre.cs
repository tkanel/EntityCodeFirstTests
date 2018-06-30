﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityCodeFirstTests.Models
{
    public class Genre
    {
        
        public int Id { get; set; }


        [Required]
        [StringLength(255)]
        public string GenreName { get; set; }

    }
}