namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/promoter/open_account/del_customize_info 接口的请求。</para>
    /// </summary>
    public class UnionPromoterOpenAccountDeleteCustomizeInfoRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置开放平台 UnionID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string UnionId { get; set; } = string.Empty;
    }
}
