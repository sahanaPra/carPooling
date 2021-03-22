using Contract.Domain;
using Contract.Domain.Models;
using Contract.Repository;

namespace Domain
{
    public class UserDomain : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserDomain(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool RegisterUser(User user)
        {
          return _userRepository.RegisterUser(user);
        }
    }
}
