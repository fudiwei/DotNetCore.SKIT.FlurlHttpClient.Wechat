using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /payscore/serviceorder 接口的响应。</para>
    /// </summary>
    public class GetPayScoreServiceOrderByOutOrderNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Payment
            {
                /// <summary>
                /// 获取或设置付费项目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置付费说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置付费金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置付费数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int Count { get; set; }
            }

            public class Discount
            {
                /// <summary>
                /// 获取或设置优惠名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置优惠说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置优惠金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置优惠数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int Count { get; set; }
            }

            public class TimeRange
            {
                /// <summary>
                /// 获取或设置服务开始时间字符串（格式：yyyyMMddHHmmss / yyyyMMdd / "OnAccept"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public string? StartTimeString { get; set; }

                /// <summary>
                /// 获取或设置服务开始时间备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time_remark")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time_remark")]
                public string? StartTimeRemark { get; set; }

                /// <summary>
                /// 获取或设置服务结束时间字符串（格式：yyyyMMddHHmmss / yyyyMMdd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public string? EndTimeString { get; set; }

                /// <summary>
                /// 获取或设置服务结束时间备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time_remark")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time_remark")]
                public string? EndTimeRemark { get; set; }
            }

            public class Location
            {
                /// <summary>
                /// 获取或设置服务开始地点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_location")]
                [System.Text.Json.Serialization.JsonPropertyName("start_location")]
                public string? StartLocation { get; set; }

                /// <summary>
                /// 获取或设置服务结束地点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_location")]
                [System.Text.Json.Serialization.JsonPropertyName("end_location")]
                public string? EndLocation { get; set; }
            }

            public class RiskFund
            {
                /// <summary>
                /// 获取或设置风险金名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置风险金说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置风险金金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }
            }

            public class Collection
            {
                public static class Types
                {
                    public class CollectionDetail
                    {
                        /// <summary>
                        /// 获取或设置收款序号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seq")]
                        [System.Text.Json.Serialization.JsonPropertyName("seq")]
                        public int Sequence { get; set; }

                        /// <summary>
                        /// 获取或设置单笔收款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public int Amount { get; set; }

                        /// <summary>
                        /// 获取或设置收款成功渠道。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("paid_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("paid_type")]
                        public string? PaidType { get; set; }

                        /// <summary>
                        /// 获取或设置收款成功时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("paid_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("paid_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.PureDigitalTextNullableDateTimeOffsetConverter))]
                        public DateTimeOffset? PaidTime { get; set; }

                        /// <summary>
                        /// 获取或设置微信支付交易单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                        public string? TransactionId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置收款状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public string State { get; set; } = default!;

                /// <summary>
                /// 获取或设置总收款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                public int TotalAmount { get; set; }

                /// <summary>
                /// 获取或设置待收金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paying_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("paying_amount")]
                public int PayingAmount { get; set; }

                /// <summary>
                /// 获取或设置已收金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paid_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("paid_amount")]
                public int PaidAmount { get; set; }

                /// <summary>
                /// 获取或设置收款明细列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("details")]
                [System.Text.Json.Serialization.JsonPropertyName("details")]
                public Types.CollectionDetail[] DetailList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public virtual string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public virtual string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户服务订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string OutOrderNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付服务订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string ServiceId { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_introduction")]
        [System.Text.Json.Serialization.JsonPropertyName("service_introduction")]
        public string ServiceIntroduction { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务订单状态说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state_description")]
        [System.Text.Json.Serialization.JsonPropertyName("state_description")]
        public string? StateDescription { get; set; }

        /// <summary>
        /// 获取或设置商户收款总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        public int? TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public virtual string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置付费项目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_payments")]
        [System.Text.Json.Serialization.JsonPropertyName("post_payments")]
        public Types.Payment[]? PostPaymentList { get; set; }

        /// <summary>
        /// 获取或设置商户优惠列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_discounts")]
        [System.Text.Json.Serialization.JsonPropertyName("post_discounts")]
        public Types.Discount[]? PostDiscountList { get; set; }

        /// <summary>
        /// 获取或设置服务时间段信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_range")]
        [System.Text.Json.Serialization.JsonPropertyName("time_range")]
        public Types.TimeRange? TimeRange { get; set; }

        /// <summary>
        /// 获取或设置服务位置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location")]
        [System.Text.Json.Serialization.JsonPropertyName("location")]
        public Types.Location? Location { get; set; }

        /// <summary>
        /// 获取或设置订单风险金信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_fund")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_fund")]
        public Types.RiskFund? RiskFund { get; set; }

        /// <summary>
        /// 获取或设置通知回调地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置是否需要收款。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_collection")]
        [System.Text.Json.Serialization.JsonPropertyName("need_collection")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualNullableBooleanConverter))]
        public bool? RequireCollection { get; set; }

        /// <summary>
        /// 获取或设置收款信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collection")]
        [System.Text.Json.Serialization.JsonPropertyName("collection")]
        public Types.Collection? Collection { get; set; }
    }
}
