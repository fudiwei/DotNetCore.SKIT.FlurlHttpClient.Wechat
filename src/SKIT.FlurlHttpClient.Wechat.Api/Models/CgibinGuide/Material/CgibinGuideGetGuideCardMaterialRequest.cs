namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguidecardmaterial 接口的请求。</para>
    /// </summary>
    public class CgibinGuideGetGuideCardMaterialRequest : WechatApiRequest, IMapResponse<CgibinGuideGetGuideCardMaterialRequest, CgibinGuideGetGuideCardMaterialResponse>
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }
    }
}
