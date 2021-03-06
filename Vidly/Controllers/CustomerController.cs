﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Customer()
        {
            var cust = new Customer() { Name = "Cust1" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };
            var viewModel = new CustomerViewModel
            {
                //customer = cust,
                Customers = customers
            };

            return View(viewModel); //return View(customers);
        }
        public ActionResult Random()
        {
            var cust = new Customer() { Name = "Cust2" };
            return View(cust);
        }
        public ActionResult Index()
        {
            var cust = new Customer() { Name = "Cust3" };
            return View(cust);
        }
        public ActionResult Lijst()
        {
            var customers2 = new List<Customer>
            {
                new Customer {ID=21, Name = "Customer 21"},
                new Customer {ID=22,Name = "Customer 22"}
            };
            var viewModel2 = new CustomerViewModel { Customers=customers2};
            return View(viewModel2);
        }
        public ActionResult Details(int id)
        {
            var detail = new Customer() { ID = id };
            return View(detail);
        }
    }
}