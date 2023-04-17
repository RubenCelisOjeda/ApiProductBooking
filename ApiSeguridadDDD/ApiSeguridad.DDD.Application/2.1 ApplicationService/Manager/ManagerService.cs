using ApiProductBooking.DDD.Infraestructure.Dapper._4._1_Repository.Manager;
using ApiProductBooking.DDD.Transversal._5._4_Entities.Manager.Request;
using ApiSeguridad.DDD.Transversal._5._2_Common._5._2._2_Methods;
using ApiSeguridad.DDD.Transversal._5._3_Response;
using System;
using System.Threading.Tasks;

namespace ApiProductBooking.DDD.Application._2._1_ApplicationService.Manager
{
    public class ManagerService : IManagerService
    {
        #region [Properties]
        private readonly MetGlo<bool> _metGlo;
        private readonly IManagerRepository _managerRepository;
        #endregion

        #region [Constructor]
        public ManagerService(IManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
            _metGlo = new MetGlo<bool>();
        }
        #endregion


        #region [Methods]
        public async Task<BaseResponse<bool>> ExistsEmail(string email)
        {
            BaseResponse<bool> baseResponse = null;
            bool responseDataAuth = false;

            try
            {
                responseDataAuth = await _managerRepository.ExistsEmail(email);
                if (responseDataAuth)
                    baseResponse = _metGlo.BaseResponseSuccess(responseDataAuth);
                else
                    baseResponse = _metGlo.BaseResponseWarning(responseDataAuth);
            }
            catch (Exception ex)
            {
                baseResponse = _metGlo.BaseResponseError(responseDataAuth, ex.Message);
            }
            return baseResponse;
        } 
        #endregion
    }
}
