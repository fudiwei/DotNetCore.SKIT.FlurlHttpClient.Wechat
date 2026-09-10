namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/partner/product-coupon/image-generation-tasks 接口的响应。</para>
    /// </summary>
    public class CreateMarketingPartnerProductCouponImageGenerationTaskResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = default!;

        /// <summary>
        /// 获取或设置图片生成任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string TaskId { get; set; } = default!;
    }
}
