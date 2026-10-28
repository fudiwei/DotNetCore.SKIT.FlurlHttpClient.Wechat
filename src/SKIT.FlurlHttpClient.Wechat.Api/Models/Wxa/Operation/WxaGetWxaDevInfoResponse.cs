namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/getwxadevinfo 接口的响应。</para>
    /// </summary>
    public class WxaGetWxaDevInfoResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置 Request 合法域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestdomain")]
        [System.Text.Json.Serialization.JsonPropertyName("requestdomain")]
        public List<string>? RequestDomainList { get; set; }

        /// <summary>
        /// 获取或设置 Socket 合法域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wsrequestdomain")]
        [System.Text.Json.Serialization.JsonPropertyName("wsrequestdomain")]
        public List<string>? WebSocketDomainList { get; set; }

        /// <summary>
        /// 获取或设置 UploadFile 合法域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uploaddomain")]
        [System.Text.Json.Serialization.JsonPropertyName("uploaddomain")]
        public List<string>? UploadDomainList { get; set; }

        /// <summary>
        /// 获取或设置 DownloadFile 合法域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("downloaddomain")]
        [System.Text.Json.Serialization.JsonPropertyName("downloaddomain")]
        public List<string>? DownloadDomainList { get; set; }

        /// <summary>
        /// 获取或设置 UDP 合法域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("udpdomain")]
        [System.Text.Json.Serialization.JsonPropertyName("udpdomain")]
        public List<string>? UdpDomainList { get; set; }

        /// <summary>
        /// 获取或设置业务域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bizdomain")]
        [System.Text.Json.Serialization.JsonPropertyName("bizdomain")]
        public List<string>? BusinessDomainList { get; set; }
    }
}
