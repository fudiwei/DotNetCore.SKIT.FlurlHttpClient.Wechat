namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalpay/addmerchant 接口的请求。</para>
    /// </summary>
    public class CgibinExternalPayAddMerchantRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置微信支付商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public string MerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信支付商户号全称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_name")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; } = string.Empty;
    }
}
