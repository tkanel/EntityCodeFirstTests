using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EntityCodeFirstTests.Models;

namespace EntityCodeFirstTests.Models
{
    public class MyDbContext:DbContext
    {

        public DbSet<customers> Customer { get; set; }
        public DbSet<Movie> Movie { get; set; }

        public DbSet<Genre> Genre { get; set; }

        public DbSet<MembershipType> MembershipType { get; set; }
        public MyDbContext()
        {



        }



    }
}