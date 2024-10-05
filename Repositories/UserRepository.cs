using Daily_Project.Data;
using Daily_Project.IRepositories;
using Daily_Project.Models;
using Daily_Project.Services;
using Microsoft.EntityFrameworkCore;

namespace Daily_Project.Repositories
{
    public class UserRepository : DefaultRepository<User>, IUserRepository
    {
        public readonly DbDailiesProjectContext _context;

        public UserRepository(DbDailiesProjectContext context) : base(context)
        {

            _context = context;

        }

        public User GetByEmail(string email)
        {
            return _context.Set<User>().Where(u => u.Email == email).FirstOrDefault();
        }

        override public async Task Create(User entity)
        {
            entity.Password = PasswordService.HashSenha(entity.Password);

            await _entity.AddAsync(entity);

            await _context.SaveChangesAsync();

        }


        override public async Task Update(User entity, int id)
        {

            if(entity.Password != null){
                
                entity.Password = PasswordService.HashSenha(entity.Password);

            }

            var entityData = await _entity.FindAsync(id);

            if (entityData != null)
            {


                foreach (var property in typeof(User).GetProperties())
                {
                    var newValue = property.GetValue(entity);

                    if (newValue != null)
                    {
                        property.SetValue(entityData, newValue);
                    }
                }

                await _context.SaveChangesAsync();


            }


        }

    }
}
