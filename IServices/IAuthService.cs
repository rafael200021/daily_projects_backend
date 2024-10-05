using Daily_Project.Services;

namespace Daily_Project.IServices
{
    public interface IAuthService
    {
        public TokenModel? Auth(string email, string senha);

    }
}
