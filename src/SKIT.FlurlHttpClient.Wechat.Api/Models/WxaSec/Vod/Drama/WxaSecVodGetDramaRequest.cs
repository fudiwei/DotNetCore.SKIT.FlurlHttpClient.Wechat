namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/getdrama 接口的请求。</para>
    /// </summary>
    public class WxaSecVodGetDramaRequest : WechatApiRequest, IInferable<WxaSecVodGetDramaRequest, WxaSecVodGetDramaResponse>
    {
        /// <summary>
        /// 获取或设置剧目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("drama_id")]
        [System.Text.Json.Serialization.JsonPropertyName("drama_id")]
        public long DramaId { get; set; }
    }
}
