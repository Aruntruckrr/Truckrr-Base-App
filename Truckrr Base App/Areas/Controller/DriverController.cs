using Microsoft.AspNetCore.Mvc;

namespace Truckrr_Base_App.Areas.Controller
{
    public class DriverController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
