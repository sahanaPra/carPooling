using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Repository.Entities
{
    public class UserVehicle
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
