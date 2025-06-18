namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/insurance_freight/getorderlist 接口的响应。</para>
    /// </summary>
    public class WxaBusinessInsuranceFreightGetOrderListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order
            {
                /// <summary>
                /// 获取或设置微信支付单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("order_no")]
                public string OrderNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置保单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("policy_no")]
                [System.Text.Json.Serialization.JsonPropertyName("policy_no")]
                public string PolicyNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置理赔报案号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("report_no")]
                [System.Text.Json.Serialization.JsonPropertyName("report_no")]
                public string ReportNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置发货运单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_no")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_no")]
                public string DeliveryNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款运单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_delivery_no")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_delivery_no")]
                public string RefundDeliveryNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置保单截止日期时间戳（单位：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("insurance_end_date")]
                [System.Text.Json.Serialization.JsonPropertyName("insurance_end_date")]
                public string InsuranceEndDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置预估理赔金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("estimate_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("estimate_amount")]
                public int EstimateAmount { get; set; }

                /// <summary>
                /// 获取或设置保费金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("premium")]
                [System.Text.Json.Serialization.JsonPropertyName("premium")]
                public int PremiumAmount { get; set; }

                /// <summary>
                /// 获取或设置保单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置理赔打款失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_fail_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_fail_reason")]
                public string? PayFailReason { get; set; }

                /// <summary>
                /// 获取或设置支付成功时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_finish_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_finish_time")]
                public long? PayFinishTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置保单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Order[] OrderList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }
    }
}
