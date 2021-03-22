using Contract.Domain;
using Contract.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CarPooling.Controllers
{
    [Route("Ride")]
    public class RideController : Controller
    {
        private readonly IRideService _rideService;

        public RideController(IRideService rideService)
        {
            _rideService = rideService;
        }

        [HttpGet]
        public IActionResult GetRides(string startLocation, string endLocation)
        {
            return Ok(_rideService.GetRidesBasedOnLocation(startLocation, endLocation));
        }

        [HttpPost]
        public IActionResult RegisterRide(List<UserVehicleRide> userVehicleRide)
        {
            return Ok(_rideService.RegisterRides(userVehicleRide));
        }
    }
}
