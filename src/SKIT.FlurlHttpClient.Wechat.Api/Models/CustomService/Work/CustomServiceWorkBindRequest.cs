namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /customservice/work/bind 接口的请求。</para>
    /// </summary>
    public class CustomServiceWorkBindRequest : WechatApiRequest, IInferable<CustomServiceWorkBindRequest, CustomServiceWorkBindResponse>
    {
        /// <summary>
        /// 获取或设置企业 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("corpid")]
        public string CorpId { get; set; } = string.Empty;
    }
}
