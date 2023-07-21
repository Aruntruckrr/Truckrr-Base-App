using Microsoft.AspNetCore.Mvc;

namespace Truckrr_Base_App.Areas.Controller
{
    public class VehicleController : ControllerBase
    {
        [HttpPost]
        
        public Task<ActionResult> AddVehicle(String vehicleId,string VehicleName)
        {
            try
            {
                if (vehicleId != null && VehicleName!=null)
                {

                }
            }
            catch{

            }
            return (Task<ActionResult>)View();
        }
        public async Task<ActionResult> EditVehicle(String vehicleId)
        {
            try
            {

            }
            catch
            {

            }
            return (ActionResult)View();
        }
        public async Task<ActionResult> DeleteVehicle(String vehicleId)
        {
            try
            {

            }
            catch
            {

            }
            return (ActionResult)View();
        }
        public async Task<ActionResult> UploadDocument(String vehicleId)
        {
            try
            {

            }
            catch
            {

            }
            return (ActionResult)View();
        }
        public async Task<ActionResult> LoadVehicle(String vehicleId)
        {
            try
            {

            }
            catch
            {

            }
            return (ActionResult)View();
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
