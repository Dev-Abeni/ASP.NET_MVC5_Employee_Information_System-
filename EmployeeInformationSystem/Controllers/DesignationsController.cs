using EmployeeInformationSystem.Models;
using EmployeeInformationSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeInformationSystem.Controllers
{
    public class DesignationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DesignationsController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Create()
        {
            var viewModel = new DesignationFormViewModel
            {
                Departments = _context.Departments.ToList(), 
                Salaries = _context.Salaries.ToList()
            };
            return View(viewModel);
        }
    }
}