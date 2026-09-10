namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/partner/product-coupon/image-generation-tasks/{task_id} 接口的请求。</para>
    /// </summary>
    public class GetMarketingPartnerProductCouponImageGenerationTaskByTaskIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置图片生成任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string TaskId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置图片生成类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ImageGenerationType { get; set; } = string.Empty;
    }
}
