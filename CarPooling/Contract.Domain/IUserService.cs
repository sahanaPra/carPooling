using Contract.Domain.Models;

namespace Contract.Domain
{
    public interface IUserService
    {
        public bool RegisterUser(User user);
    }
}
