using Contract.Domain.Models;
using Contract.Repository;
using Microsoft.Extensions.Logging;
using Repository.Data;
using System.Linq;
using System.Collections.Generic;
using UserVehicleRideEntity = Contract.Repository.Entities.UserVehicleRide;
using System;

namespace Repository
{
    public class RideRepository : IRideRepository
    {
        private readonly ApplicationDbContext _dbContext;
        //TODO: resolve DI
        private readonly ILogger _logger;
        public RideRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<UserVehicleRide> GetRidesBasedOnLocation(string startLocation, string endLocation)
        {
            var rideDetailsEntity = _dbContext.UserVehicleRide
                 .Where(c => c.RideFrom == startLocation && c.RideTo == endLocation)
                 .Select(x => new UserVehicleRide()
                 {
                      RideTo = x.RideTo,
                      RideStartDateTime = x.RideStartDateTime,
                      RideEstimatedEndDateTime = x.RideEstimatedEndDateTime,
                      RideFrom = x.RideFrom,
                 })
                 .ToList();
            return rideDetailsEntity.ToList();
        }

        public bool RegisterRides(List<UserVehicleRide> userVehicleRides)
        {
            try
            {
                var userVehicleRidesEntity = userVehicleRides.Select(c => new UserVehicleRideEntity()
                {
                    RideEstimatedEndDateTime = c.RideEstimatedEndDateTime,
                    RideStartDateTime = c.RideStartDateTime,
                    RideTo = c.RideTo,
                    RideFrom = c.RideFrom,
                    UserVehicle = new Contract.Repository.Entities.UserVehicle()
                    {
                        User = new Contract.Repository.Entities.User()
                        {
                            Id = c.UserVehicle.User.Id,
                            UserName = c.UserVehicle.User.UserName,
                        }
                    }
                });
                _dbContext.UserVehicleRide.AddRangeAsync(userVehicleRidesEntity);
                _dbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                throw;
            }
            return true;
        }
    }
}
