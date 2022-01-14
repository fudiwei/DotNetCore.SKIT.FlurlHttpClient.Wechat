namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguideimagematerial 接口的请求。</para>
    /// </summary>
    public class CgibinGuideGetGuideImageMaterialRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start")]
        [System.Text.Json.Serialization.JsonPropertyName("start")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("num")]
        [System.Text.Json.Serialization.JsonPropertyName("num")]
        public int Limit { get; set; } = 10;
    }
}
