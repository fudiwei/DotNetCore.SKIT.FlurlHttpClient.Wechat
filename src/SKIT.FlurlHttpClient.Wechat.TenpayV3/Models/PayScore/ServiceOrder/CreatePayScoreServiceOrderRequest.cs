using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/serviceorder 接口的请求。</para>
    /// </summary>
    public class CreatePayScoreServiceOrderRequest : WechatTenpayRequest
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
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置付费说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置付费金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int? Amount { get; set; }

                /// <summary>
                /// 获取或设置付费数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int? Count { get; set; }
            }

            public class Discount
            {
                /// <summary>
                /// 获取或设置优惠名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置优惠说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置优惠金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int? Amount { get; set; }

                /// <summary>
                /// 获取或设置优惠数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int? Count { get; set; }
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
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置风险金说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置风险金金额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public virtual string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户服务订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string OutOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string ServiceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_introduction")]
        [System.Text.Json.Serialization.JsonPropertyName("service_introduction")]
        public string ServiceInstruction { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public virtual string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置是否需要用户确认。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_user_confirm")]
        [System.Text.Json.Serialization.JsonPropertyName("need_user_confirm")]
        public bool? RequireUserConfirm { get; set; }

        /// <summary>
        /// 获取或设置付费项目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_payments")]
        [System.Text.Json.Serialization.JsonPropertyName("post_payments")]
        public IList<Types.Payment> PostPaymentList { get; set; } = new List<Types.Payment>();

        /// <summary>
        /// 获取或设置商户优惠列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_discounts")]
        [System.Text.Json.Serialization.JsonPropertyName("post_discounts")]
        public IList<Types.Discount>? PostDiscountList { get; set; }

        /// <summary>
        /// 获取或设置服务时间段信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_range")]
        [System.Text.Json.Serialization.JsonPropertyName("time_range")]
        public Types.TimeRange TimeRange { get; set; } = new Types.TimeRange();

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
        public Types.RiskFund RiskFund { get; set; } = new Types.RiskFund();
    }
}
