using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myWebApp7475.Models;

namespace myWebApp7475.Pages
{
    public class SQLPageModel : PageModel
    {
        // Create a DataAccessController object
        DataAccessController dac = new DataAccessController();

        // Create a collection for holding CoursesAndModules object
        public List<CoursesAndModules> CoursesAndModules;
        public void OnGet()
        {
            // Retrieve the data using the DataAccessController object and populate the CoursesAndModules object
            CoursesAndModules = dac.GetAllCoursesAndModules().ToList();
        }

        // Create a DataAccessController object - Employee
        DataAccessController dacEmployee = new DataAccessController();

        // Create a collection for holding CoursesAndModules object
        public List<EmployeeDetails> EmployeeDetails;
        public void OnGetEmployeeDetails()
        {
            // Retrieve the data using the DataAccessController object and populate the CoursesAndModules object
            EmployeeDetails = dacEmployee.GetAllCoursesAndModulesEmployees().ToList();
        }

    }
}