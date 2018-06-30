using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityCodeFirstTests.Models
{
    public class Movie
    {

        public int Id { get; set; }
        
        [Required]
        public string MovieName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateAdded { get; set; }

        [Required]
        public int NumberInStock { get; set; }

        [Required]
        public Genre Genre { get; set; }
        //public byte GenreId { get; set; }
    }
}