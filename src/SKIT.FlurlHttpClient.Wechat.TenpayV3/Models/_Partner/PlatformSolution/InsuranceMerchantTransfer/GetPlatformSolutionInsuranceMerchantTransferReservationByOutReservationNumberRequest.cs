namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /platsolution/insurance/mch-transfer/reservation/out-reservation-no/{out_reservation_no} 接口的请求。</para>
    /// </summary>
    public class GetPlatformSolutionInsuranceMerchantTransferReservationByOutReservationNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户预约单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutReservationNumber { get; set; } = string.Empty;
    }
}
