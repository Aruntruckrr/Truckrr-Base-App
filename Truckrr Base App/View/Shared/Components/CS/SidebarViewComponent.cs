using Microsoft.AspNetCore.Mvc;

namespace Truckrr_Base_App.View.Shared.Components.CS
{
    public class SidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
