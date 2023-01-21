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
        public int Id { get; set; }

        /// <summary>
        /// Nombre del usuario
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Email del usuario
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Token generado para el usario
        /// </summary>
        public string Token { get; set; }
    }
}
