using ApiSeguridad.DDD.Transversal._5._2_Common._5._2._1_Constantes;
using ApiSeguridad.DDD.Transversal._5._3_Response;

namespace ApiSeguridad.DDD.Transversal._5._2_Common._5._2._2_Methods
{
    public class MetGlo
    {
        #region [BaseResponse]
        public BaseResponse<object> BaseResponseSuccess(object pData)
        {
            var baseResponse = new BaseResponse<object>()
            {
                CodigoError = Constante.ResponseCode.SuccessCode,
                Message = Constante.ResponseMessage.SuccessMessage,
                IsSuccess = Constante.StatusCode.Success,
                Data = pData
            };
            return baseResponse;
        }

        public BaseResponse<object> BaseResponseError(string pError = "")
        {
            var baseResponse = new BaseResponse<object>()
            {
                CodigoError = Constante.ResponseCode.ErrorCode,
                Message = Constante.ResponseMessage.ErrorMessage,
                IsSuccess = Constante.StatusCode.Error,
                Data = null
            };
            return baseResponse;
        }

        public BaseResponse<object> BaseResponseWarning(object pData,string message = "")
        {
            var baseResponse = new BaseResponse<object>()
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
