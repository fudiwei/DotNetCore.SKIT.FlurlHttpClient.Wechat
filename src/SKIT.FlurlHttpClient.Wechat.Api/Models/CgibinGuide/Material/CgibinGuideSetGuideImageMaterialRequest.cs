namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/setguideimagematerial 接口的请求。</para>
    /// </summary>
    public class CgibinGuideSetGuideImageMaterialRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置图片素材媒体文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string MediaId { get; set; } = string.Empty;
    }
}
