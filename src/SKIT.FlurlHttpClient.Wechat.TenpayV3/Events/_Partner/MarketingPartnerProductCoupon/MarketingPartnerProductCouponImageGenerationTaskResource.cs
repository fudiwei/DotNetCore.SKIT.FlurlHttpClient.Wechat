using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 PRODUCT_COUPON_SP.SEND 通知的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4017327744 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4017327759 ]]>
    /// </para>
    /// </summary>
    public class MarketingPartnerProductCouponImageGenerationTaskResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        public static class Types
        {
            public class CombineImageResult : Models.GetMarketingPartnerProductCouponImageGenerationTaskByTaskIdResponse.Types.CombineImageResult
            {
            }

            public class CutOutResult : Models.GetMarketingPartnerProductCouponImageGenerationTaskByTaskIdResponse.Types.CutOutResult
            {
            }
        }

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

        /// <summary>
        /// 获取或设置图片生成任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_state")]
        [System.Text.Json.Serialization.JsonPropertyName("task_state")]
        public string TaskState { get; set; } = default!;

        /// <summary>
        /// 获取或设置图片生成类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_generation_type")]
        [System.Text.Json.Serialization.JsonPropertyName("image_generation_type")]
        public string ImageGenerationType { get; set; } = default!;

        /// <summary>
        /// 获取或设置拼图结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_image_result")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_image_result")]
        public Types.CombineImageResult? CombineImageResult { get; set; }

        /// <summary>
        /// 获取或设置抠图结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cut_out_result")]
        [System.Text.Json.Serialization.JsonPropertyName("cut_out_result")]
        public Types.CutOutResult? CutOutResult { get; set; }
    }
}
