namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/marketcode/applycode 接口的响应。</para>
    /// </summary>
    public class IntpMarketCodeApplyCodeResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("application_id")]
        [System.Text.Json.Serialization.JsonPropertyName("application_id")]
        public long ApplicationId { get; set; }
    }
}
