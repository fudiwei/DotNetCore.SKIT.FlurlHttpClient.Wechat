namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /new-tax-control-fapiao/merchant/development-config 接口的请求。</para>
    /// </summary>
    public class ModifyNewTaxControlFapiaoMerchantDevelopmentConfigRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置回调地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callback_url")]
        [System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string CallbackUrl { get; set; } = string.Empty;
    }
}
