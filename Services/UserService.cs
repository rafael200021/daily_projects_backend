using Daily_Project.IRepositories;
using Daily_Project.IServices;
using Daily_Project.Models;

namespace Daily_Project.Services
{
    public class UserService : DefaultService<User>, IUserService
    {


        public UserService(IUserRepository repository) : base(repository)
        {
        }

    }
}
