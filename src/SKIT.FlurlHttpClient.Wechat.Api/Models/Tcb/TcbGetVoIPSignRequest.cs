namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getvoipsign 接口的请求。</para>
    /// </summary>
    public class TcbGetVoIPSignRequest : WechatApiRequest, IInferable<TcbGetVoIPSignRequest, TcbGetVoIPSignResponse>
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置游戏房间的标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置随机字符串。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nonce")]
        [System.Text.Json.Serialization.JsonPropertyName("nonce")]
        public string? Nonce { get; set; }

        /// <summary>
        /// 获取或设置时间戳。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp")]
        [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public long? Timestamp { get; set; }
    }
}
