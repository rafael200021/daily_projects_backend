using Daily_Project.IRepositories;
using Daily_Project.IServices;
using Daily_Project.Models;
using Daily_Project.Repositories;
using Daily_Project.Services;

namespace Daily_Project.Data
{
    public class DependencyInjection
    {
        public DependencyInjection() { }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DbDailiesProjectContext>();

            // Services

           services.AddScoped<IUserService, UserService>();
            
           services.AddScoped(typeof(IDefaultService<Board>), typeof(DefaultService<Board>));

           services.AddScoped(typeof(IDefaultService<BoardMember>), typeof(DefaultService<BoardMember>));

            services.AddScoped(typeof(IDefaultService<Card>), typeof(DefaultService<Card>));

            services.AddScoped(typeof(IDefaultService<CardAttachment>), typeof(DefaultService<CardAttachment>));

            services.AddScoped(typeof(IDefaultService<CardComment>), typeof(DefaultService<CardComment>));

            services.AddScoped(typeof(IDefaultService<Label>), typeof(DefaultService<Label>));

            services.AddScoped(typeof(IDefaultService<CardAssignee>), typeof(DefaultService<CardAssignee>));

            services.AddScoped(typeof(IDefaultService<BoardType>), typeof(DefaultService<BoardType>));

            services.AddScoped(typeof(IDefaultService<CardLabel>), typeof(DefaultService<CardLabel>));

            services.AddScoped(typeof(IDefaultService<Workspace>), typeof(DefaultService<Workspace>));

            services.AddScoped(typeof(IDefaultService<WorkspaceMember>), typeof(DefaultService<WorkspaceMember>));

            services.AddScoped(typeof(IDefaultService<List>), typeof(DefaultService<List>));

            services.AddScoped<IAuthService, AuthService>();


            // Repositories

            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped(typeof(IDefaultRepository<Board>), typeof(DefaultRepository<Board>));

            services.AddScoped(typeof(IDefaultRepository<Workspace>), typeof(DefaultRepository<Workspace>));

            services.AddScoped(typeof(IDefaultRepository<WorkspaceMember>), typeof(DefaultRepository<WorkspaceMember>));

            services.AddScoped(typeof(IDefaultRepository<CardAttachment>), typeof(DefaultRepository<CardAttachment>));

            services.AddScoped(typeof(IDefaultRepository<CardAssignee>), typeof(DefaultRepository<CardAssignee>));

            services.AddScoped(typeof(IDefaultRepository<BoardType>), typeof(DefaultRepository<BoardType>));

            services.AddScoped(typeof(IDefaultRepository<Label>), typeof(DefaultRepository<Label>));

            services.AddScoped(typeof(IDefaultRepository<CardLabel>), typeof(DefaultRepository<CardLabel>));

            services.AddScoped(typeof(IDefaultRepository<CardComment>), typeof(DefaultRepository<CardComment>));

            services.AddScoped(typeof(IDefaultRepository<BoardMember>), typeof(DefaultRepository<BoardMember>));

            services.AddScoped(typeof(IDefaultRepository<Card>), typeof(DefaultRepository<Card>));

            services.AddScoped(typeof(IDefaultRepository<List>), typeof(DefaultRepository<List>));

            services.AddScoped(typeof(IDefaultRepository<>), typeof(DefaultRepository<>));

        }

    }
}
