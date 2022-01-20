namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/delguideimagematerial 接口的请求。</para>
    /// </summary>
    public class CgibinGuideDeleteGuideImageMaterialRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置图片素材 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("picurl")]
        [System.Text.Json.Serialization.JsonPropertyName("picurl")]
        public string PictureUrl { get; set; } = string.Empty;
    }
}
