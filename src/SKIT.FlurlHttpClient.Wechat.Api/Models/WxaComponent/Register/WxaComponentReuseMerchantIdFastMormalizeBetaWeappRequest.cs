namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/component/reusemchidfastnormalizebetaweapp 接口的请求。</para>
    /// </summary>
    public class WxaComponentReuseMerchantIdFastMormalizeBetaWeappRequest : WechatApiRequest, IInferable<WxaComponentReuseMerchantIdFastMormalizeBetaWeappRequest, WxaComponentReuseMerchantIdFastMormalizeBetaWeappResponse>
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Action { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("primary_merchant_code")]
        [System.Text.Json.Serialization.JsonPropertyName("primary_merchant_code")]
        public string? PrimaryMerchantId { get; set; }

        /// <summary>
        /// 获取或设置商家商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_merchant_code")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_merchant_code")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置第三方联系电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("component_phone")]
        public string? ComponentPhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("taskid")]
        public string? TaskId { get; set; }
    }
}
