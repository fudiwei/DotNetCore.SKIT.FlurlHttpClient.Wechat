namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/freepublish/get 接口的请求。</para>
    /// </summary>
    public class CgibinFreePublishGetRequest : WechatApiRequest, IMapResponse<CgibinFreePublishGetRequest, CgibinFreePublishGetResponse>
    {
        /// <summary>
        /// 获取或设置发布任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publish_id")]
        [System.Text.Json.Serialization.JsonPropertyName("publish_id")]
        public string PublishId { get; set; } = string.Empty;
    }
}
