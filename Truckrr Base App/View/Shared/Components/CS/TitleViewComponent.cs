using Microsoft.AspNetCore.Mvc;

namespace Truckrr_Base_App.View.Shared.Components.CS
{
    public class TitleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
