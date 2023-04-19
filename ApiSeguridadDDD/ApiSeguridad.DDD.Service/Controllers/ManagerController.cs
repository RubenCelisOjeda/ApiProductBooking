using ApiProductBooking.DDD.Application._2._1_ApplicationService.Manager;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IManagerService _managerService;
        #endregion

        #region [Constructor]
        public ManagerController(IManagerService managerService)
        {
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
            var responseData = await _managerService.ExistsEmail(email);
            return Ok(responseData);
        }
        #endregion

    }
}
