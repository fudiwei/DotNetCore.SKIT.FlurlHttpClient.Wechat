namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wxverify/checkwxverifynickname 接口的请求。</para>
    /// </summary>
    public class CgibinWxverifyCheckWxverifyNicknameRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置小程序昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nick_name")]
        [System.Text.Json.Serialization.JsonPropertyName("nick_name")]
        public string Nickname { get; set; } = string.Empty;
    }
}
