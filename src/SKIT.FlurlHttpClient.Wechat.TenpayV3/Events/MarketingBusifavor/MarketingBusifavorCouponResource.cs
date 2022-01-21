using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 COUPON.SEND 通知的数据。</para>
    /// </summary>
    public class MarketingBusifavorCouponResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        public static class Types
        {
            public class Attachment
            {
                /// <summary>
                /// 获取或设置交易订单编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_id")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                public string? TransactionId { get; set; }

                /// <summary>
                /// 获取或设置支付有礼活动编号或营销馆活动 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("act_code")]
                [System.Text.Json.Serialization.JsonPropertyName("act_code")]
                public string? ActivityCode { get; set; }

                /// <summary>
                /// 获取或设置营销馆 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hall_code")]
                [System.Text.Json.Serialization.JsonPropertyName("hall_code")]
                public string? HallCode { get; set; }

                /// <summary>
                /// 获取或设置营销馆所属商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hall_belong_mch_id")]
                [System.Text.Json.Serialization.JsonPropertyName("hall_belong_mch_id")]
                public string? HallbelongMerchantId { get; set; }

                /// <summary>
                /// 获取或设置会员卡 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_id")]
                [System.Text.Json.Serialization.JsonPropertyName("card_id")]
                public string? CardId { get; set; }

                /// <summary>
                /// 获取或设置会员卡 Code。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public string? CardCode { get; set; }

                /// <summary>
                /// 获取或设置会员活动 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_id")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
                public string? ActivityId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event_type")]
        [System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = default!;

        /// <summary>
        /// 获取或设置商家券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_code")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_code")]
        public string CouponCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string StockId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置用户统一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string? UnionId { get; set; }

        /// <summary>
        /// 获取或设置发放时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("send_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset SendTime { get; set; }

        /// <summary>
        /// 获取或设置发券商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_channel")]
        [System.Text.Json.Serialization.JsonPropertyName("send_channel")]
        public string SendChannel { get; set; } = default!;

        /// <summary>
        /// 获取或设置发券商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_merchant")]
        [System.Text.Json.Serialization.JsonPropertyName("send_merchant")]
        public string SendMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置发券附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach_info")]
        [System.Text.Json.Serialization.JsonPropertyName("attach_info")]
        public Types.Attachment? Attachment { get; set; }
    }
}
