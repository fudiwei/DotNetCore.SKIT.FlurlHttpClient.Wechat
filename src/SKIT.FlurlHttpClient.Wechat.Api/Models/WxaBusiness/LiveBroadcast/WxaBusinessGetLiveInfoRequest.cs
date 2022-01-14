namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/getliveinfo 接口的请求。</para>
    /// </summary>
    public class WxaBusinessGetLiveInfoRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start")]
        [System.Text.Json.Serialization.JsonPropertyName("start")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; } = 10;
    }
}
