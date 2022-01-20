namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/getcallbackip 接口的响应。</para>
    /// </summary>
    public class CgibinGetCallbackIpResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置微信服务器 IP 地址列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip_list")]
        [System.Text.Json.Serialization.JsonPropertyName("ip_list")]
        public string[] IPList { get; set; } = default!;
    }
}
