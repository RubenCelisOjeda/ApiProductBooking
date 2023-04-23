using ApiSeguridad.DDD.Transversal._5._3_Response;
using ApiSeguridad.DDD.Transversal._5._4_Entities.Auth;
using System.Threading.Tasks;

namespace ApiSeguridad.DDD.Application._2._1_ApplicationService.Auth
{
    public interface IAuthService
    {
        /// <summary>
        /// Metodo que valida el usuario y contraseña.
        /// </summary>
        /// <param name="pEntidad">Parametros de tipo dentodad</param>
        /// <returns>Datos del usuario</returns>
        public Task<BaseResponse<object>> AuthLoginWeb(AuthRequest pEntidad);
    }
}
