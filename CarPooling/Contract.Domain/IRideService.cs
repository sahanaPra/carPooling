using Contract.Domain.Models;
using System.Collections.Generic;

namespace Contract.Domain
{
    public interface IRideService
    {
        public IList<UserVehicleRide> GetRidesBasedOnLocation(string startLocation, string endLocation);

        public bool RegisterRides(List<UserVehicleRide> userVehicleRides);
    }
}
