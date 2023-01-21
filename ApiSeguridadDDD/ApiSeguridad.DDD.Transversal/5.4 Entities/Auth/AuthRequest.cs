namespace ApiSeguridad.DDD.Transversal._5._4_Entities.Auth
{
    /// <summary>
    /// Clase AuthRequest
    /// </summary>
    public class AuthRequest
    {
        /// <summary>
        /// Constructor vacio
        /// </summary>
        public AuthRequest()
        {

        }

        /// <summary>
        /// Nombre del usuario.
        /// </summary>
        public string Usuario { get; set; }

        /// <summary>
        /// Contraseña del usuario.
        /// </summary>
        public string Password { get; set; }
    }
}
