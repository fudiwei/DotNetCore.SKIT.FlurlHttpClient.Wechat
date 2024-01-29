namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/getmedia 接口的请求。</para>
    /// </summary>
    public class WxaSecVodGetMediaRequest : WechatApiRequest, IInferable<WxaSecVodGetMediaRequest, WxaSecVodGetMediaResponse>
    {
        /// <summary>
        /// 获取或设置媒资文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public long MediaId { get; set; }
    }
}
