namespace ApiSeguridad.DDD.Transversal._5._2_Common._5._2._1_Constantes
{
    public static class Constante
    {
        public struct ResponseMessage
        {
            public const string SuccessMessage = "Se ejecuto correctamente.";
            public const string WarningMessage = "No se pudo ejecutar la consulta.";
            public const string ErrorMessage = "Error al ejecutar la consulta.";
        }

        public struct ResponseCode
        {
            public const string SuccessCode = "0";
            public const string WarningCode = "1";
            public const string ErrorCode = "2";
        }

        public struct StatusCode
        {
            public const bool Success = true;
            public const bool Warning = false;
            public const bool Error = false;
        }
    }
}
