using Microsoft.AspNetCore.Mvc;
using LeaveManagementSystem.Web.Models;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {

            var data = new TestViewModel
            {
                Name = "Student",
                DateOfBirth = new DateTime(2001,07,25)
            };
            return View(data);
        }
    }
}
