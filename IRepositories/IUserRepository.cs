using Daily_Project.Models;

namespace Daily_Project.IRepositories
{
    public interface IUserRepository:IDefaultRepository<User>
    {

        public User GetByEmail(string email);


    }
}
