﻿using MyMvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMvcApplication.Controllers
{
    public class DepartmentController : Controller
    {
        //
        // GET: /Department/
        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Department> departments =  employeeContext.Departments.ToList();
            return View(departments);
        }
	}
}