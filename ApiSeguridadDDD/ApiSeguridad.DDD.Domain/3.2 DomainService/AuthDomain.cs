using ApiSeguridad.DDD.Domain._3._3_ContractRepository.Auth;
using ApiSeguridad.DDD.Transversal._5._4_Entities.Auth;
using System.Threading.Tasks;

namespace ApiSeguridad.DDD.Domain._3._2_DomainService
{
    public class AuthDomain : IAuthDomain
    {
        #region [Properties]
        private readonly IAuthRepository _authRepository; 
        #endregion

        #region [Constructor]
        public AuthDomain(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }
        #endregion

        #region [Methods]
        /// <summary>
        /// Metodo que valida el usuario y contraseña.
        /// </summary>
        /// <param name="pEntidad">Parametros de tipo dentodad</param>
        /// <returns>Datos del usuario</returns>
        public Task<AuthResponse> AuthLoginWeb(AuthRequest pEntidad)
        {
            return _authRepository.AuthLoginWeb(pEntidad);
        } 
        #endregion
    }
}
