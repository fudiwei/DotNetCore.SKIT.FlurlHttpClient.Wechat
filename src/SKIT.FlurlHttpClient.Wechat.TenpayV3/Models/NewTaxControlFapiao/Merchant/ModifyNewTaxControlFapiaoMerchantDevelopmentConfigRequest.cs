namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /new-tax-control-fapiao/merchant/development-config 接口的请求。</para>
    /// </summary>
    public class ModifyNewTaxControlFapiaoMerchantDevelopmentConfigRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_code")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_code")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置回调地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callback_url")]
        [System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string CallbackUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否展示开发票入口开关。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("show_fapiao_cell")]
        [System.Text.Json.Serialization.JsonPropertyName("show_fapiao_cell")]
        public bool? RequireShowFapiaoCell { get; set; }
    }
}
