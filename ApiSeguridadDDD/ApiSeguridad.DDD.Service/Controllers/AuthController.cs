using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ApiSeguridad.DDD.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;

        /// <summary>
        /// Constructor del controlador AuthController.
        /// </summary>
        /// <param name="logger">Log</param>
        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Metodo de autenticacion.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("AuthLoginWeb")]
        public async Task<IActionResult> AuthLoginWeb()
        {
            try
            {
                //var response = await _usuarioApplication.Login(pUthRequest);
                _logger.LogInformation("Test");
                return BadRequest();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest();
            }
        }
    }
}
