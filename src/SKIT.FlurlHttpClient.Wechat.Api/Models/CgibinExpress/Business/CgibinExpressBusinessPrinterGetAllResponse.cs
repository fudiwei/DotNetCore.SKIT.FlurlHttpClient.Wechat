namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/express/business/printer/getall 接口的响应。</para>
    /// </summary>
    public class CgibinExpressBusinessPrinterGetAllResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置打印员用户 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string[] PrinterOpenIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置打印员面单打印权限列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tagid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("tagid_list")]
        public int[] TagIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置打印员数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int Count { get; set; }
    }
}
