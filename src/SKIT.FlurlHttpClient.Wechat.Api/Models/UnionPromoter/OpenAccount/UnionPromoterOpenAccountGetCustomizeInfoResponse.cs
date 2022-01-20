namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/promoter/open_account/get_customize_info 接口的响应。</para>
    /// </summary>
    public class UnionPromoterOpenAccountGetCustomizeInfoResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置自定义参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customizeInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("customizeInfo")]
        public string CustomizeInfo { get; set; } = default!;
    }
}
