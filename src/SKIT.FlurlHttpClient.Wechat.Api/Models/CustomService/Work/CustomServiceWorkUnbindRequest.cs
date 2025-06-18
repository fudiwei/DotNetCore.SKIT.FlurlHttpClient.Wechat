namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /customservice/work/unbind 接口的请求。</para>
    /// </summary>
    public class CustomServiceWorkUnbindRequest : WechatApiRequest, IInferable<CustomServiceWorkUnbindRequest, CustomServiceWorkUnbindResponse>
    {
        /// <summary>
        /// 获取或设置企业 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("corpid")]
        public string CorpId { get; set; } = string.Empty;
    }
}
