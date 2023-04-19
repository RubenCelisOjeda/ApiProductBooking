namespace ApiSeguridad.DDD.Transversal._5._3_Response
{
    /// <summary>
    /// Clase de tipo Response
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseResponse<T> where T : class
    {
        /// <summary>
        /// Codigo de error
        /// </summary>
        public string CodigoError { get; set; }

        /// <summary>
        /// Data de la respuesta
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Respuesta
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Mensaje de la respuesta
        /// </summary>
        public string Message { get; set; }
    }
}
