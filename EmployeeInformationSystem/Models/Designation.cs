using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeInformationSystem.Models
{
    public class Designation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Department Department { get; set; }
        public Salary Salary { get; set; }
    }
}