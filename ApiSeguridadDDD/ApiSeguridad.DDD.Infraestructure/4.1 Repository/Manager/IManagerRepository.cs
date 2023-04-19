using System.Threading.Tasks;

namespace ApiProductBooking.DDD.Infraestructure.Dapper._4._1_Repository.Manager
{
    public interface IManagerRepository
    {
        // <summary>
        /// Metodo que valida el usuario y contraseña.
        /// </summary>
        /// <param name="pEntidad">Parametros de tipo dentodad</param>
        /// <returns>Datos del usuario</returns>
        public Task<int> ExistsEmail(string email);
    }
}
