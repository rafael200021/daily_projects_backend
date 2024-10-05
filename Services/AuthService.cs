using Daily_Project.IRepositories;
using Daily_Project.IServices;
using Daily_Project.Models;
using Daily_Project.Repositories;

namespace Daily_Project.Services
{
    public class TokenModel
    {
        public string Token { get; set; }
    }

    public class AuthService:IAuthService
    {

        public readonly IUserRepository _repository;

        public AuthService(IUserRepository repository)
        {
            _repository = repository;

        }

        public TokenModel? Auth(string email,string senha)
        {
            User? user = _repository.GetByEmail(email);

            if(user == null) { return null;  }

            if(PasswordService.VerificarSenha(senha,user.Password) == false) { return null; }

            string token = JWTService.GerarToken(user); 

            return new TokenModel { Token = token };

        }

    }
}
