using Contract.Domain;
using Contract.Domain.Models;
using Contract.Repository;

namespace Domain
{
    public class VehicleDomain : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        public VehicleDomain(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public bool RegisterVehicles(UserVehicle userVehicle)
        {
            return _vehicleRepository.RegisterVehicles(userVehicle);
        }
    }
}
