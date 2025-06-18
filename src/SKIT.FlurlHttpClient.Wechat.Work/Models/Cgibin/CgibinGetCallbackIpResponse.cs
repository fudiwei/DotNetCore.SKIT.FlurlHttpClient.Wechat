namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/getcallbackip 接口的响应。</para>
    /// </summary>
    public class CgibinGetCallbackIpResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置企业微信回调的 IP 段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip_list")]
        [System.Text.Json.Serialization.JsonPropertyName("ip_list")]
        public string[] IPList { get; set; } = default!;
    }
}
