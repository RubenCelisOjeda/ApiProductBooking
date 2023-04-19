using ApiProductBooking.DDD.Infraestructure.Dapper._4._1_Repository.Manager;
using ApiSeguridad.DDD.Transversal._5._2_Common._5._2._2_Methods;
using ApiSeguridad.DDD.Transversal._5._3_Response;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ApiProductBooking.DDD.Application._2._1_ApplicationService.Manager
{
    public class ManagerService : IManagerService
    {
        #region [Properties]
        private readonly ILogger<ManagerService> _logger;
        private readonly MetGlo _metGlo;
        private readonly IManagerRepository _managerRepository;
        #endregion

        #region [Constructor]
        public ManagerService(ILogger<ManagerService> logger ,IManagerRepository managerRepository)
        {
            _logger = logger;
            _managerRepository = managerRepository;
            _metGlo = new MetGlo();
        }
        #endregion


        #region [Methods]
        public async Task<BaseResponse<object>> ExistsEmail(string email)
        {
            BaseResponse<object> baseResponse = null;
            int responseService = 0;

            try
            {
                responseService = await _managerRepository.ExistsEmail(email);
                if (responseService == 1)
                    baseResponse = _metGlo.BaseResponseSuccess(responseService);
                else
                    baseResponse = _metGlo.BaseResponseWarning(responseService,"El correo ingresado es inválido y/o es correcto.");

                _logger.LogInformation(baseResponse.Message, baseResponse);

            }
            catch (Exception ex)
            {
                baseResponse = _metGlo.BaseResponseError(ex.Message);
                _logger.LogError(ex.Message, baseResponse);
            }
            return baseResponse;
        } 
        #endregion
    }
}
