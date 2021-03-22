using Contract.Domain.Models;

namespace Contract.Repository
{
    public interface IVehicleRepository
    {
        public bool RegisterVehicles(UserVehicle userVehicle);
    }
}
