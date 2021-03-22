using Contract.Domain.Models;
using Contract.Repository;
using Microsoft.Extensions.Logging;
using Repository.Data;
using System;
using UserEntity = Contract.Repository.Entities.User;

namespace Repository
{
    public class UserReposiotory : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        //TODO: resolve DI
        private readonly ILogger _logger;
        public UserReposiotory(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool RegisterUser(User user)
        {
            try
            {
                var userEntity = new UserEntity()
                {
                    AuthorizedDocumentNumber = user.AuthorizedDocumentNumber,
                    UserName = user.UserName,
                    EmailId = user.EmailId,
                    AuthorizedDocumentType = (int)user.AuthorizedDocumentType
                };
                _dbContext.User.AddAsync(userEntity);
                _dbContext.SaveChangesAsync();

            }
            catch(Exception ex)
            {
                //TODO: Log exception

                throw;
            }
            return true;
        }
    }
}
