namespace ApiProductBooking.DDD.Transversal._5._4_Entities.Manager.Request
{
    /// <summary>
    /// Entidad ExistsEmailRequest
    /// </summary>
    public class ExistsEmailRequest
    {
        #region [Constructor]
        public ExistsEmailRequest()
        {

        }
        #endregion

        #region [Atributet]
        /// <summary>
        /// Email que proviene del manager
        /// </summary>
        public string Email { get;set; }
        #endregion
    }
}
