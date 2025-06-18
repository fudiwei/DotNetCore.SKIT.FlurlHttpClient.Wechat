using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 DISCOUNT_CARD.USER_ACCEPTED 通知的数据。</para>
    /// <para>表示 DISCOUNT_CARD.AGREEMENT_ENDED 通知的数据。</para>
    /// <para>表示 DISCOUNT_CARD.USER_PAID 通知的数据。</para>
    /// </summary>
    public class DiscountCardResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        public static class Types
        {
            public class TimeRange : Models.GetDiscountCardByOutCardCodeResponse.Types.TimeRange
            {
            }

            public class Payment : Models.GetDiscountCardByOutCardCodeResponse.Types.Payment
            {
            }

            public class Objective : Models.GetDiscountCardByOutCardCodeResponse.Types.Objective
            {
            }

            public class Reward : Models.GetDiscountCardByOutCardCodeResponse.Types.Reward
            {
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户领卡号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_card_code")]
        [System.Text.Json.Serialization.JsonPropertyName("out_card_code")]
        public string OutCardCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置先享卡模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_template_id")]
        public string CardTemplateId { get; set; } = default!;

        /// <summary>
        /// 获取或设置先享卡 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置约定时间期限信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_range")]
        [System.Text.Json.Serialization.JsonPropertyName("time_range")]
        public Types.TimeRange? TimeRange { get; set; }

        /// <summary>
        /// 获取或设置状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置未完成约定原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unfinished_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("unfinished_reason")]
        public string? UnfinishedReason { get; set; }

        /// <summary>
        /// 获取或设置享受优惠总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        public int? TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置用户退回优惠的付款信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_information")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_information")]
        public Types.Payment? Payment { get; set; }

        /// <summary>
        /// 获取或设置目标列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("objectives")]
        [System.Text.Json.Serialization.JsonPropertyName("objectives")]
        public Types.Objective[]? Objectives { get; set; }

        /// <summary>
        /// 获取或设置优惠列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rewards")]
        [System.Text.Json.Serialization.JsonPropertyName("rewards")]
        public Types.Reward[]? Rewards { get; set; }

        /// <summary>
        /// 获取或设置邀请者用户标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_openid")]
        public string? SharerOpenId { get; set; }

        /// <summary>
        /// 获取或设置创卡时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? CreateTime { get; set; }
    }
}
