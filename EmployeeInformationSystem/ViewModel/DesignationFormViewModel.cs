using EmployeeInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeInformationSystem.ViewModel
{
    public class DesignationFormViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int Department { get; set; }
        public IEnumerable<Department> Departments { get; set; }

        public int Salary { get; set; }
        public IEnumerable<Salary> Salaries { get; set; }

    }
}