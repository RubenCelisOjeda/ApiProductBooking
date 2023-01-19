using ApiSeguridad.DDD.Domain._3._3_ContractRepository.Auth;

namespace ApiSeguridad.DDD.Domain._3._2_DomainService
{
    public class AuthDomain : IAuthDomain
    {
        private readonly IAuthRepository _authRepository;

        public AuthDomain(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public void AuthLoginWeb()
        {
            _authRepository.AuthLoginWeb();
        }
    }
}
