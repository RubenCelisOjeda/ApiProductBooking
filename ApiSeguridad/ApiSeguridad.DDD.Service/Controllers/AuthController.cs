using ApiSeguridad.DDD.Application._2._1_ApplicationService.Auth;
using ApiSeguridad.DDD.Transversal._5._3_Response;
using ApiSeguridad.DDD.Transversal._5._4_Entities.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ApiSeguridad.DDD.Service.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        #region [Properties]
        private readonly ILogger<AuthController> _logger;
        private readonly IAuthService _authService;
        #endregion

        #region [Constructor]
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="authService"></param>
        public AuthController(ILogger<AuthController> logger, IAuthService authService)
        {
            _logger = logger;
            _authService = authService;
        }
        #endregion

        #region [Apis]
        /// <summary>
        /// Metodo de autenticacion.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("AuthLoginWeb")]
        public async Task<IActionResult> AuthLoginWeb([FromBody] AuthRequest pEntidad)
        {
            BaseResponse<object> responseData = null;

            try
            {
                responseData = await _authService.AuthLoginWeb(pEntidad);
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
