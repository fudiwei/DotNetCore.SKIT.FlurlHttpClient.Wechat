namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/add_contact_way 接口的响应。</para>
    /// </summary>
    public class CgibinKfAddContactWayResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置客服链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string OpenKfId { get; set; } = default!;
    }
}
