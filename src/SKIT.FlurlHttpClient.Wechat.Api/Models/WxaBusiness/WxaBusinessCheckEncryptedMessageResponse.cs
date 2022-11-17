namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/checkencryptedmsg 接口的响应。</para>
    /// </summary>
    public class WxaBusinessCheckEncryptedMessageResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否是合法的数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vaild")]
        [System.Text.Json.Serialization.JsonPropertyName("vaild")]
        public bool IsValid { get; set; }

        /// <summary>
        /// 获取或设置加密数据生成的时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public long CreateTimestamp { get; set; }
    }
}
