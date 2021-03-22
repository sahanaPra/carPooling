using Contract.Domain;
using Contract.Domain.Models;
using Microsoft.AspNetCore.Mvc;
namespace CarPooling.Controllers
{
    [Route("Vehicle")]
    public class VehicleController : Controller
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpPost]
        public IActionResult RegisterVehicles(UserVehicle userVehicle)
        {
            return Ok(_vehicleService.RegisterVehicles(userVehicle));
        }
    }
}
