using System.Collections.Generic;

namespace Contract.Domain.Models
{
    public class UserVehicle
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
