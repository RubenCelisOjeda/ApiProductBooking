using ApiSeguridad.DDD.Domain._3._3_ContractRepository.Auth;
using ApiSeguridad.DDD.Transversal._5._4_Entities.Auth;
using Dapper;
using ServicioAPISeguridad.Infraestructure.Interfaces;
using System.Data;
using System.Linq;
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
                const string procedure = @"SELECT usu.Id,
                                                 usu.UserName,
                                                 usu.Email

                                           FROM Usuario usu
                                           WHERE usu.Email = @pEmail AND
                                                 usu.Password = @pPassword AND 
                                                 usu.Status = 1";

                var parameters = new DynamicParameters();
                parameters.Add("@pEmail", pEntidad.Usuario, DbType.String);
                parameters.Add("@pPassword", pEntidad.Password, DbType.String);

                var response = await connection.QueryAsync<AuthResponse>(procedure, parameters, commandType: CommandType.Text);
                return response.FirstOrDefault();
            }
        } 
        #endregion
    }
}
