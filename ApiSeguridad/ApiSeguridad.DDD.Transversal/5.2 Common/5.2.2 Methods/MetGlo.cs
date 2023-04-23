using ApiSeguridad.DDD.Transversal._5._2_Common._5._2._1_Constantes;
using ApiSeguridad.DDD.Transversal._5._3_Response;

namespace ApiSeguridad.DDD.Transversal._5._2_Common._5._2._2_Methods
{
    public class MetGlo<T>
    {
        #region [BaseResponse]
        public static BaseResponse<T> BaseResponseSuccess(T pData)
        {
            var baseResponse = new BaseResponse<T>()
            {
                CodigoError = Constante.ResponseCode.SuccessCode,
                Message = Constante.ResponseMessage.SuccessMessage,
                IsSuccess = Constante.StatusCode.Success,
                Data = pData
            };
            return baseResponse;
        }

        public static BaseResponse<T> BaseResponseError(string pError = "")
        {
            var baseResponse = new BaseResponse<T>()
            {
                CodigoError = Constante.ResponseCode.ErrorCode,
                Message = Constante.ResponseMessage.ErrorMessage,
                IsSuccess = Constante.StatusCode.Error,
            };
            return baseResponse;
        }

        public static BaseResponse<T> BaseResponseWarning(T pData,string message = "")
        {
            var baseResponse = new BaseResponse<T>()
            {
                CodigoError = Constante.ResponseCode.WarningCode,
                Message = (message == "" ? Constante.ResponseMessage.WarningMessage : message),
                IsSuccess = Constante.StatusCode.Warning,
                Data = pData
            };
            return baseResponse;
        } 
        #endregion
    }
}
