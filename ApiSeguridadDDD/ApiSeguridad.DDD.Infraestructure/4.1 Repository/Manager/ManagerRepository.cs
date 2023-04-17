using ApiProductBooking.DDD.Transversal._5._4_Entities.Manager.Request;
using Dapper;
using ServicioAPISeguridad.Infraestructure.Interfaces;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProductBooking.DDD.Infraestructure.Dapper._4._1_Repository.Manager
{
    public class ManagerRepository
    {
        #region [Propertys]
        private readonly IConnectionFactory _configuration;
        #endregion

        #region [Constructor]
        public ManagerRepository(IConnectionFactory configuration)
        {
            _configuration = configuration;
        }
        #endregion

        #region [Methods]
        /// <summary>
        /// Metodo que valida el usuario y contraseña.
        /// </summary>
        /// <param name="pEntidad">Parametros de tipo dentodad</param>
        /// <returns>Datos del usuario</returns>
        public async Task<bool> ExistsEmail(ExistsEmailRequest pEntidad)
        {
            using (var connection = _configuration.GetConnectionPideloPues)
            {
                #region [Query]
                const string query = @"SELECT usu.Id AS ID,
                                                  usu.UserName AS USERNAME,
                                                  usu.Email AS EMAIL

                                        FROM Usuario usu
                                        WHERE usu.Email = @pEmail";
                #endregion

                #region [Parameters]
                var parameters = new DynamicParameters(new
                {
                    pEmail = pEntidad.Email
                });
                #endregion

                #region [Execute]
                var response = await connection.QueryAsync<bool>(query, parameters, commandType: CommandType.Text);
                return response.FirstOrDefault();
                #endregion
            }
        }
        #endregion
    }
}
