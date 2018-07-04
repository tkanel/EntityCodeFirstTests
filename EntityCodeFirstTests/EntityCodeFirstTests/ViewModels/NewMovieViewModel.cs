using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityCodeFirstTests.Models;

namespace EntityCodeFirstTests.ViewModels
{
    public class NewMovieViewModel
    {


        public IEnumerable<Genre> Genres { get; set; }

        public Movie Movies { get; set; }


    }
}