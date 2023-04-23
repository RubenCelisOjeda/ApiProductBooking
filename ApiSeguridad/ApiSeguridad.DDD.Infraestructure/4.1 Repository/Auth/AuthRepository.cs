using ApiSeguridad.DDD.Domain._3._3_ContractRepository.Auth;
using ApiSeguridad.DDD.Transversal._5._4_Entities.Auth;
using Dapper;
using Dapper.Oracle;
using Oracle.ManagedDataAccess.Client;
using ServicioAPISeguridad.Infraestructure.Interfaces;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace ApiSeguridad.DDD.Infraestructure._4._1_Repository
{
    public class AuthRepository : IAuthRepository
    {
        #region [Propertys]
        private readonly IConnectionFactory _configuration; 
        #endregion

        #region [Constructor]
        public AuthRepository(IConnectionFactory configuration)
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
        public async Task<AuthResponse> AuthLoginWeb(AuthRequest pEntidad)
        {
            using (var connection = _configuration.GetConnectionSeguridad)
            {
                #region [Query]
                const string procedure = @"SELECT usu.Id AS ID,
                                                  usu.UserName AS USERNAME,
                                                  usu.Email AS EMAIL

                                           FROM Usuario usu
                                           WHERE usu.Email = @pEmail";
                #endregion

                #region [Parameters]
                var parameters = new DynamicParameters( new
                {
                    pEmail = pEntidad.Usuario,
                    pPassword = pEntidad.Password,
                });
                #endregion

                #region [Execute]
                var response = await connection.QueryAsync<AuthResponse>(procedure, parameters,commandType: CommandType.Text);
                return response.FirstOrDefault(); 
                #endregion
            }
        } 
        #endregion
    }
}
