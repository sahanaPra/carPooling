using Contract.Domain.Models;
using System.Collections.Generic;

namespace Contract.Repository
{
    public interface IRideRepository
    {
        public IList<UserVehicleRide> GetRidesBasedOnLocation(string startLocation, string endLocation);

        public bool RegisterRides(List<UserVehicleRide> userVehicleRides);
    }
}
