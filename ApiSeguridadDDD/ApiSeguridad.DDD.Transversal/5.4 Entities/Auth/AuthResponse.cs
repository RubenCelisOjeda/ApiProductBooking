namespace ApiSeguridad.DDD.Transversal._5._4_Entities.Auth
{
    /// <summary>
    /// Clase AuthResponse
    /// </summary>
    public class AuthResponse
    {
        /// <summary>
        /// Constructor vacio
        /// </summary>
        public AuthResponse()
        {

        }

        /// <summary>
        /// Id del usuario
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Nombre del usuario
        /// </summary>
        public string UserName { get; }

        /// <summary>
        /// Email del usuario
        /// </summary>
        public string Email { get; }

        /// <summary>
        /// Token generado para el usario
        /// </summary>
        public string Token { get;}
    }
}
