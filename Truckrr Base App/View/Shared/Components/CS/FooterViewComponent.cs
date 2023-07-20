using Microsoft.AspNetCore.Mvc;

namespace Truckrr_Base_App.View.Shared.Components.CS
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}