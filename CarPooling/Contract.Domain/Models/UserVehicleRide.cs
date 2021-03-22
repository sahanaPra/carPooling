using System;

namespace Contract.Domain.Models
{
    public class UserVehicleRide
    {
        public int Id { get; set; }
        public UserVehicle UserVehicle { get; set; }
        public string RideFrom { get; set; }
        public string RideTo { get; set; }
        public DateTime RideStartDateTime { get; set; }
        public DateTime RideEstimatedEndDateTime { get; set; }
    }
}
