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
        private static ILogger<ManagerService> _logger;
        private readonly IManagerRepository _managerRepository;
        #endregion

        #region [Constructor]
        public ManagerService(ILogger<ManagerService> logger ,IManagerRepository managerRepository)
        {
            _logger = logger;
            _managerRepository = managerRepository;
        }
        #endregion

        #region [Methods]
        public async Task<BaseResponse<bool>> ExistsEmail(string email)
        {
            BaseResponse<bool> baseResponse = null;
            bool responseService = false;
            

            try
            {
                responseService = await _managerRepository.ExistsEmail(email);
                if (responseService)
                    baseResponse = MetGlo<bool>.BaseResponseSuccess(responseService);
                else
                    baseResponse = MetGlo<bool>.BaseResponseWarning(responseService, "El correo ingresado es inválido y/o es correcto.");

                _logger.LogInformation(baseResponse.Message, baseResponse);
                
            }
            catch (Exception ex)
            {
                baseResponse = MetGlo<bool>.BaseResponseError(ex.Message);
                _logger.LogError(ex.Message, baseResponse);
            }
            return baseResponse;
        } 
        #endregion
    }
}
