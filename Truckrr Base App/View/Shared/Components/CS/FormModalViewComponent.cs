using Microsoft.AspNetCore.Mvc;

namespace Truckrr_Base_App.View.Shared.Components.CS
{
    public class FormModalViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}