namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/promoter/open_account/add_customize_info 接口的请求。</para>
    /// </summary>
    public class UnionPromoterOpenAccountAddCustomizeInfoRequest : WechatApiRequest, IMapResponse<UnionPromoterOpenAccountAddCustomizeInfoRequest, UnionPromoterOpenAccountAddCustomizeInfoResponse>
    {
        /// <summary>
        /// 获取或设置开放平台 UnionID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string UnionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置自定义参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customizeInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("customizeInfo")]
        public string CustomizeInfo { get; set; } = string.Empty;
    }
}
