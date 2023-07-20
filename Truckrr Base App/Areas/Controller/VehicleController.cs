using Microsoft.AspNetCore.Mvc;
using Truckrr_Base_App.Web.Areas.Models;

namespace Truckrr_Base_App.Areas.Controller
{
    public class VehicleController : ControllerBase
    {
        private object _mediator;
        private object _mapper;

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> LoadAll()
        {
            var response = await _mediator.Send(new GetAllVehicleCachedQuery());
            if (response.Succeeded)
            {
                var viewModel = _mapper.Map<List<VehicleModel>>(response.Data);
                return PartialView("_ViewAll", viewModel);
            }
            return null;
        }

        private IActionResult PartialView(string v, object viewModel)
        {
            throw new NotImplementedException();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }

    internal class GetAllVehicleCachedQuery
    {
        public GetAllVehicleCachedQuery()
        {
        }
    }
}
