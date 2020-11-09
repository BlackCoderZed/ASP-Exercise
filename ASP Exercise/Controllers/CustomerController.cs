using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using ASP_Exercise.Models;
using PagedList;
using PagedList.Mvc;

namespace ASP_Exercise.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        public ActionResult Index(int? page)
        {
            if(!page.HasValue)
            {
                page = 1;
            }
            var customers = _context.Customer.Include(c => c.MembershipType).ToList().ToPagedList(page ?? 1, 6);
            return View(customers);
        }

        public ActionResult Details(int? id)
        {
            var customer = _context.Customer.Include(c => c.MembershipType).SingleOrDefault(x=>x.Id == id);
            return View(customer);
        }

    }
}