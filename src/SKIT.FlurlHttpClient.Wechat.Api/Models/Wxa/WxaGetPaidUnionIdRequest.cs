namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/getpaidunionid 接口的请求。</para>
    /// </summary>
    public class WxaGetPaidUnionIdRequest : WechatApiRequest, IMapResponse<WxaGetPaidUnionIdRequest, WxaGetPaidUnionIdResponse>
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。与字段 <see cref="TransactionId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? OutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置微信支付订单号。与字段 <see cref="OutTradeNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? TransactionId { get; set; }
    }
}
