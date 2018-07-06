using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityCodeFirstTests.Models;

namespace EntityCodeFirstTests.ViewModels
{
    public class NewMovieViewModel
    {


        public IEnumerable<Genre> GenresList { get; set; }

        public Movie MoviesList { get; set; }


    }
}