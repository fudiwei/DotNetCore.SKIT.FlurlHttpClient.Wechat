namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/mass/get 接口的请求。</para>
    /// </summary>
    public class CgibinMessageMassGetRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置群发消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
        public long MessageId { get; set; }
    }
}
