using ApiSeguridad.DDD.Transversal._5._2_Common._5._2._1_Constantes;
using ApiSeguridad.DDD.Transversal._5._3_Response;

namespace ApiSeguridad.DDD.Transversal._5._2_Common._5._2._2_Methods
{
    public class MetGlo<T>
    {
        #region [BaseResponse]
        public BaseResponse<T> BaseResponseSuccess(T pData)
        {
            BaseResponse<T> baseResponse = new BaseResponse<T>()
            {
                CodigoError = Constante.ResponseCode.SuccessCode,
                Message = Constante.ResponseMessage.SuccessMessage,
                IsSuccess = Constante.StatusCode.Warning,
                Data = pData
            };
            return baseResponse;
        }

        public BaseResponse<T> BaseResponseError(T pData, string pError = "")
        {
            BaseResponse<T> baseResponse = new BaseResponse<T>()
            {
                CodigoError = Constante.ResponseCode.ErrorCode,
                Message = Constante.ResponseMessage.ErrorMessage + " - " + pError,
                IsSuccess = Constante.StatusCode.Warning,
                Data = pData
            };
            return baseResponse;
        }

        public BaseResponse<T> BaseResponseWarning(T pData)
        {
            BaseResponse<T> baseResponse = new BaseResponse<T>()
            {
                CodigoError = Constante.ResponseCode.WarningCode,
                Message = Constante.ResponseMessage.WarningMessage,
                IsSuccess = Constante.StatusCode.Warning,
                Data = pData
            };
            return baseResponse;
        } 
        #endregion
    }
}
