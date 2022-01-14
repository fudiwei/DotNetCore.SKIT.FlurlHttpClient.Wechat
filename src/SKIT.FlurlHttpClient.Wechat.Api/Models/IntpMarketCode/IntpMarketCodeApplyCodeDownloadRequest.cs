namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/marketcode/applycodedownload 接口的请求。</para>
    /// </summary>
    public class IntpMarketCodeApplyCodeDownloadRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_id")]
        [System.Text.Json.Serialization.JsonPropertyName("application_id")]
        public long ApplicationId { get; set; }

        /// <summary>
        /// 获取或设置号段开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_start")]
        [System.Text.Json.Serialization.JsonPropertyName("code_start")]
        public long CodeStart { get; set; }

        /// <summary>
        /// 获取或设置号段结束位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_end")]
        [System.Text.Json.Serialization.JsonPropertyName("code_end")]
        public long CodeEnd { get; set; }
    }
}
