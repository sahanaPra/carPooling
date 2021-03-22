using Contract.Domain;
using Contract.Domain.Models;
using Contract.Repository;
using System.Collections.Generic;

namespace Domain
{
    public class RideDomain : IRideService
    {
        private readonly IRideRepository _rideRepository;
        public RideDomain(IRideRepository rideRepository)
        {
            _rideRepository = rideRepository;
        }

        public IList<UserVehicleRide> GetRidesBasedOnLocation(string startLocation, string endLocation)
        {
            return _rideRepository.GetRidesBasedOnLocation(startLocation, endLocation);
        }

        public bool RegisterRides(List<UserVehicleRide> userVehicleRides)
        {
            return _rideRepository.RegisterRides(userVehicleRides);
        }
    }
}
