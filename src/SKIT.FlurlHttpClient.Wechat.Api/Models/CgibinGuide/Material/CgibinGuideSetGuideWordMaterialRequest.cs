namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/setguidewordmaterial 接口的请求。</para>
    /// </summary>
    public class CgibinGuideSetGuideWordMaterialRequest : WechatApiRequest, IMapResponse<CgibinGuideSetGuideWordMaterialRequest, CgibinGuideSetGuideWordMaterialResponse>
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置文字素材内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("word")]
        [System.Text.Json.Serialization.JsonPropertyName("word")]
        public string Word { get; set; } = string.Empty;
    }
}
