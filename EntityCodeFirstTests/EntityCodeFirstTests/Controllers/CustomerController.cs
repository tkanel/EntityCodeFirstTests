using EntityCodeFirstTests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace EntityCodeFirstTests.Controllers
{
    public class CustomerController : Controller
    {
        public MyDbContext _context=new MyDbContext();

        //public CustomerController()
                       
        //    {

        //    _context = new MyDbContext();    

        //    }

        //protected override void Dispose(bool disposing)
        //{
        //    _context.Dispose();
        //}
        // GET: Customer

       

        public ActionResult Index()
        {

            var customers = _context.Customer.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

      
        public ActionResult Details(int id)
        {

            var customer = _context.Customer.Include(c => c.MembershipType).SingleOrDefault(c => c.Id==id);

            if (customer == null)
            {

                return HttpNotFound();
            }

            return View(customer);
        }
    }
}