using ApiSeguridad.DDD.Transversal._5._2_Common._5._2._1_Constantes;
using ApiSeguridad.DDD.Transversal._5._3_Response;

namespace ApiSeguridad.DDD.Transversal._5._2_Common._5._2._2_Methods
{
    public static class MetGlo<T>
    {
        #region [BaseResponse]
        public static BaseResponse<T> BaseResponseSuccess(T pData)
        {
            BaseResponse<T> baseResponse = new BaseResponse<T>();
            baseResponse.CodigoError = Constante.ResponseCode.SuccessCode;
            baseResponse.Message = Constante.ResponseMessage.SuccessMessage;
            baseResponse.IsSuccess = Constante.StatusCode.Warning;
            baseResponse.Data = pData;

            return baseResponse;
        }

        public static BaseResponse<T> BaseResponseError(T pData, string pError = "")
        {
            BaseResponse<T> baseResponse = new BaseResponse<T>();
            baseResponse.CodigoError = Constante.ResponseCode.SuccessCode;
            baseResponse.Message = Constante.ResponseMessage.SuccessMessage + " - " + pError;
            baseResponse.IsSuccess = Constante.StatusCode.Warning;
            baseResponse.Data = pData;

            return baseResponse;
        }

        public static BaseResponse<T> BaseResponseWarning(T pData)
        {
            BaseResponse<T> baseResponse = new BaseResponse<T>();
            baseResponse.CodigoError = Constante.ResponseCode.SuccessCode;
            baseResponse.Message = Constante.ResponseMessage.SuccessMessage;
            baseResponse.IsSuccess = Constante.StatusCode.Warning;
            baseResponse.Data = pData;

            return baseResponse;
        } 
        #endregion
    }
}
