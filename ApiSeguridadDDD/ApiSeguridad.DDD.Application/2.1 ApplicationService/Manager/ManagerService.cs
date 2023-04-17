using ApiProductBooking.DDD.Transversal._5._4_Entities.Manager.Request;
using ApiSeguridad.DDD.Transversal._5._2_Common._5._2._2_Methods;
using ApiSeguridad.DDD.Transversal._5._3_Response;
using ApiSeguridad.DDD.Transversal._5._4_Entities.Auth;
using System.Threading.Tasks;

namespace ApiProductBooking.DDD.Application._2._1_ApplicationService.Manager
{
    public class ManagerService : IManagerService
    {
        #region [Properties]
        private readonly MetGlo<AuthResponse> _metGlo;
        #endregion

        #region [Constructor]
        public ManagerService()
        {
            _metGlo = new MetGlo<AuthResponse>();
        }
        #endregion


        #region [Methods]
        public Task<BaseResponse<bool>> ExistsEmail(ExistsEmailRequest pEntidad)
        {
            throw new System.NotImplementedException();
        } 
        #endregion
    }
}
