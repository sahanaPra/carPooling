using Contract.Domain.Models;

namespace Contract.Domain
{
    public interface IVehicleService
    {
        public bool RegisterVehicles(UserVehicle userVehicle);
    }
}
