using ApiSeguridad.DDD.Domain._3._2_DomainService;

namespace ApiSeguridad.DDD.Application._2._1_ApplicationService.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IAuthDomain _authDomain;

        public AuthService(IAuthDomain authDomain)
        {
            _authDomain = authDomain;
        }

        public void AuthLoginWeb()
        {
            _authDomain.AuthLoginWeb();
        }
    }
}
