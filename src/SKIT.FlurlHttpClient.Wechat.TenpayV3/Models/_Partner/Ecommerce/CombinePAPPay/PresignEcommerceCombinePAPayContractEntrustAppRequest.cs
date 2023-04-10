namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/combine-papay/contracts/pre-entrust-sign 接口的请求。</para>
    /// </summary>
    public class PresignEcommerceCombinePAPayContractEntrustAppRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public int PlanId { get; set; }

        /// <summary>
        /// 获取或设置商户签约协议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_contract_code")]
        [System.Text.Json.Serialization.JsonPropertyName("out_contract_code")]
        public string OutContractCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户账户展示名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_display_account")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_display_account")]
        public string UserDisplayName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否签约后返回 App。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_app")]
        [System.Text.Json.Serialization.JsonPropertyName("return_app")]
        public bool? RequireReturnApp { get; set; }
    }
}
