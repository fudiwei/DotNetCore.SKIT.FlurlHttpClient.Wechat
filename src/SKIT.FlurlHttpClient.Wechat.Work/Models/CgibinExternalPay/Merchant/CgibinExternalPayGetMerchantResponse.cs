namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalpay/getmerchant 接口的响应。</para>
    /// </summary>
    public class CgibinExternalPayGetMerchantResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class UseScope : CgibinExternalPaySetMerchantUseScopeRequest.Types.UseScope
            {
            }
        }

        /// <summary>
        /// 获取或设置绑定状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind_status")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_status")]
        public int BindStatus { get; set; }

        /// <summary>
        /// 获取或设置微信支付商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信支付商户号全称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_name")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
        public string? MerchantName { get; set; }

        /// <summary>
        /// 获取或设置使用范围信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_use_scope")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_use_scope")]
        public Types.UseScope? UseScope { get; set; }
    }
}
