namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/component/reusemchidfastnormalizebetaweapp 接口的响应。</para>
    /// </summary>
    public class WxaComponentReuseMerchantIdFastMormalizeBetaWeappResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("taskid")]
        public string? TaskId { get; set; }

        /// <summary>
        /// 获取或设置商户号管理员授权的 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorize_merchant_administrator_url")]
        [System.Text.Json.Serialization.JsonPropertyName("authorize_merchant_administrator_url")]
        public string? AuthorizeMerchantAdministratorUrl { get; set; }

        /// <summary>
        /// 获取或设置商户管理员授权的任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorize_merchant_administrator_status")]
        [System.Text.Json.Serialization.JsonPropertyName("authorize_merchant_administrator_status")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? AuthorizeMerchantAdministratorStatus { get; set; }

        /// <summary>
        /// 获取或设置待转正小程序管理员授权的 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorize_appid_administrator_url")]
        [System.Text.Json.Serialization.JsonPropertyName("authorize_appid_administrator_url")]
        public string? AuthorizeAppIdAdministratorUrl { get; set; }

        /// <summary>
        /// 获取或设置待转正小程序管理员授权的任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorize_appid_administrator_status")]
        [System.Text.Json.Serialization.JsonPropertyName("authorize_appid_administrator_status")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int? AuthorizeAppIdAdministratorStatus { get; set; }
    }
}
