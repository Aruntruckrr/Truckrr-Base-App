using Microsoft.AspNetCore.Mvc;

namespace Truckrr_Base_App.Areas.Controller
{
    public class DashBoardController : ControllerBase
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
