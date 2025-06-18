namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/promoter/promotion/add 接口的响应。</para>
    /// </summary>
    public class UnionPromoterPromotionAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置推广位 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pid")]
        [System.Text.Json.Serialization.JsonPropertyName("pid")]
        public string PromotionId { get; set; } = default!;
    }
}
