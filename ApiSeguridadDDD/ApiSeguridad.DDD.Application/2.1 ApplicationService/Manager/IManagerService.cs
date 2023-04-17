using ApiProductBooking.DDD.Transversal._5._4_Entities.Manager.Request;
using ApiSeguridad.DDD.Transversal._5._3_Response;
using System.Threading.Tasks;

namespace ApiProductBooking.DDD.Application._2._1_ApplicationService.Manager
{
    public interface IManagerService
    {
        /// <summary>
        /// Metodo que valida si extiste el email.
        /// </summary>
        /// <param name="pEntidad"></param>
        /// <returns></returns>
        public Task<BaseResponse<bool>> ExistsEmail(ExistsEmailRequest pEntidad);
    }
}
