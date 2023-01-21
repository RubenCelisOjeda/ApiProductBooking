using ApiSeguridad.DDD.Transversal._5._4_Entities.Auth;
using System.Threading.Tasks;

namespace ApiSeguridad.DDD.Domain._3._2_DomainService
{
    public interface IAuthDomain
    {
        /// <summary>
        /// Metodo que valida el usuario y contraseña.
        /// </summary>
        /// <param name="pEntidad">Parametros de tipo dentodad</param>
        /// <returns>Datos del usuario</returns>
        public Task<AuthResponse> AuthLoginWeb(AuthRequest pEntidad);
    }
}
