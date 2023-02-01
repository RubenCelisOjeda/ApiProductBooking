using ApiSeguridad.DDD.Domain._3._2_DomainService;
using ApiSeguridad.DDD.Transversal._5._2_Common._5._2._2_Methods;
using ApiSeguridad.DDD.Transversal._5._3_Response;
using ApiSeguridad.DDD.Transversal._5._4_Entities.Auth;
using System;
using System.Threading.Tasks;

namespace ApiSeguridad.DDD.Application._2._1_ApplicationService.Auth
{
    public class AuthService : IAuthService
    {
        #region [Properties]
        private readonly IAuthDomain _authDomain;
        #endregion

        #region [Constructor]
        public AuthService(IAuthDomain authDomain)
        {
            _authDomain = authDomain;
        }
        #endregion

        #region [Methods]
        /// <summary>
        /// Metodo que valida el usuario y contraseña.
        /// </summary>
        /// <param name="pEntidad">Parametros de tipo dentodad</param>
        /// <returns>Datos del usuario</returns>
        public async Task<BaseResponse<AuthResponse>> AuthLoginWeb(AuthRequest pEntidad)
        {
            BaseResponse<AuthResponse> baseResponse = null;
            AuthResponse responseDataAuth = null;

            try
            {
                responseDataAuth =  await _authDomain.AuthLoginWeb(pEntidad);
                if (responseDataAuth != null)
                    baseResponse = MetGlo<AuthResponse>.BaseResponseSuccess(responseDataAuth);
                else
                    baseResponse = MetGlo<AuthResponse>.BaseResponseWarning(responseDataAuth);
            }
            catch (Exception ex)
            {
                baseResponse = MetGlo<AuthResponse>.BaseResponseError(responseDataAuth, ex.Message);
            }
            return baseResponse;
        } 
        #endregion
    }
}
