﻿using Dapper;
using ServicioAPISeguridad.Infraestructure.Interfaces;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProductBooking.DDD.Infraestructure.Dapper._4._1_Repository.Manager
{
    public class ManagerRepository : IManagerRepository
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
        public async Task<bool> ExistsEmail(string email)
        {
            using (var connection = _configuration.GetConnectionPideloPues)
            {
                #region [Query]
                const string query = @"SELECT COUNT(1)
                                       FROM dbo.[User] u
                                       WHERE u.Email = @pEmail";
                #endregion

                #region [Parameters]
                var parameters = new DynamicParameters(new
                {
                    pEmail = email
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
