using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myWebApp7475.Models;

namespace myWebApp7475.Controllers
{
    public class AlbumsController : Controller
    {
        public IActionResult Index()
        {
            EmployeesDbContext context = HttpContext.RequestServices.GetService(typeof(myWebApp7475.Models.EmployeesDbContext)) as EmployeesDbContext;

            return View(context.GetAllAlbums());
        }
    }
}