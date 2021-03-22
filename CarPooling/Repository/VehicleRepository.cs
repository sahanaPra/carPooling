using Contract.Domain.Models;
using Contract.Repository;
using Microsoft.Extensions.Logging;
using Repository.Data;
using System;
using UserVehicleEntity = Contract.Repository.Entities.UserVehicle;
using UserEntity = Contract.Repository.Entities.User;
using System.Linq;

namespace Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly ApplicationDbContext _dbContext;
        //TODO: resolve DI
        private readonly ILogger _logger;
        public VehicleRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool RegisterVehicles(UserVehicle userVehicle)
        {
           try
            {
                var userVehicleEntity = new UserVehicleEntity()
                {
                    User = new UserEntity()
                    {
                        Id = userVehicle.User.Id,
                    },
                    Vehicles = userVehicle.Vehicles.Select(c => new Contract.Repository.Entities.Vehicle()
                    {
                        Seater = c.Seater,
                        VehicleName = c.VehicleName,
                    }).ToList(),
                };
                _dbContext.UserVehicle.AddAsync(userVehicleEntity);
                _dbContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw;
            }
            return true;
        }
    }
}
