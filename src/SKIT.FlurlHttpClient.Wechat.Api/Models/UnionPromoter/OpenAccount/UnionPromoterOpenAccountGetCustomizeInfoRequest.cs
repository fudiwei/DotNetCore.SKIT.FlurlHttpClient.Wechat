namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/promoter/open_account/get_customize_info 接口的请求。</para>
    /// </summary>
    public class UnionPromoterOpenAccountGetCustomizeInfoRequest : WechatApiRequest, IMapResponse<UnionPromoterOpenAccountGetCustomizeInfoRequest, UnionPromoterOpenAccountGetCustomizeInfoResponse>
    {
        /// <summary>
        /// 获取或设置开放平台 UnionID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string UnionId { get; set; } = string.Empty;
    }
}
