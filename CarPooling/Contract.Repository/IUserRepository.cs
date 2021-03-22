using Contract.Domain.Models;

namespace Contract.Repository
{
    public interface IUserRepository
    {
        public bool RegisterUser(User user);
    }
}
