using ApiProductBooking.DDD.Transversal._5._4_Entities.Manager.Request;
using ApiSeguridad.DDD.Service.Controllers;
using ApiSeguridad.DDD.Transversal._5._3_Response;
using ApiSeguridad.DDD.Transversal._5._4_Entities.Auth;
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
        #endregion

        #region [Constructor]
        public ManagerController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }
        #endregion

        #region [Apis]
        /// <summary>
        /// Metodo que valida si extiste el email.
        /// </summary>
        /// <param name="pEntidad"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("ExistsEmail")]
        public async Task<IActionResult> ExistsEmail([FromBody] ExistsEmailRequest pEntidad)
        {
            BaseResponse<AuthResponse> responseData = null;

            try
            {
                //responseData = await _authService.AuthLoginWeb(pEntidad);
                _logger.LogInformation(responseData.Message);
                return Ok("");
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
