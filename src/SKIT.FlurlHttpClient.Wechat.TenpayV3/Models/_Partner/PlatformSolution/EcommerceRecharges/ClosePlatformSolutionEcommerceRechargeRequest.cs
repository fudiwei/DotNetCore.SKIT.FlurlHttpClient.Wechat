namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /platsolution/ecommerce/recharges/out-recharge-no/{out_recharge_no}/close 接口的请求。</para>
    /// </summary>
    public class ClosePlatformSolutionEcommerceRechargeRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户充值单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutRechargeNumber { get; set; } = string.Empty;
    }
}
