using ApiProductBooking.DDD.Application._2._1_ApplicationService.Manager;
using ApiSeguridad.DDD.Service.Controllers;
using ApiSeguridad.DDD.Transversal._5._3_Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ApiProductBooking.DDD.Service.Controllers
{
    /// <summary>
    /// Api ManagerController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        #region [Properties]
        private readonly ILogger<AuthController> _logger;
        private readonly IManagerService _managerService;
        #endregion

        #region [Constructor]
        public ManagerController(ILogger<AuthController> logger, IManagerService managerService)
        {
            _logger = logger;
            _managerService = managerService;
        }
        #endregion

        #region [Apis]
        /// <summary>
        /// Metodo que valida si extiste el email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ExistsEmail")]
        public async Task<IActionResult> ExistsEmail(string email)
        {
            BaseResponse<object> responseData = null;

            try
            {
                responseData = await _managerService.ExistsEmail(email);
                _logger.LogInformation(responseData.Message);
                return Ok(responseData);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(responseData);
            }
        }
        #endregion

    }
}
