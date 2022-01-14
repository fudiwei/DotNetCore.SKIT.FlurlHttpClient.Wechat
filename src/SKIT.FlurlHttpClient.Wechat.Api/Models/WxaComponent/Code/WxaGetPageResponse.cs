namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/get_page 接口的响应。</para>
    /// </summary>
    public class WxaGetPageResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置页面列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_list")]
        [System.Text.Json.Serialization.JsonPropertyName("page_list")]
        public string[] PageList { get; set; } = default!;
    }
}
