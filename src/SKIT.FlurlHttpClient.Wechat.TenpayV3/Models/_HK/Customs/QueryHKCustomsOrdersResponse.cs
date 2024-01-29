using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /customs/orders 接口的响应。</para>
    /// </summary>
    public class QueryHKCustomsOrdersResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Record
            {
                /// <summary>
                /// 获取或设置状态码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public string State { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户子订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_order_no")]
                public string? SubOrderNumber { get; set; }

                /// <summary>
                /// 获取或设置微信子订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_order_id")]
                public string? SubOrderId { get; set; }

                /// <summary>
                /// 获取或设置海关。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("customs")]
                [System.Text.Json.Serialization.JsonPropertyName("customs")]
                public string Customs { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户海关备案号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mch_customs_no")]
                [System.Text.Json.Serialization.JsonPropertyName("mch_customs_no")]
                public string MerchantCustomsNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置关税（单位：指定货币的最小单位）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("duty")]
                [System.Text.Json.Serialization.JsonPropertyName("duty")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? Duty { get; set; }

                /// <summary>
                /// 获取或设置币种。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fee_type")]
                [System.Text.Json.Serialization.JsonPropertyName("fee_type")]
                public string? FeeType { get; set; }

                /// <summary>
                /// 获取或设置应付金额（单位：指定货币的最小单位）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("order_fee")]
                public int? OrderFee { get; set; }

                /// <summary>
                /// 获取或设置物流费（单位：指定货币的最小单位）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transport_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("transport_fee")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? TransportFee { get; set; }

                /// <summary>
                /// 获取或设置商品价格（单位：指定货币的最小单位）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("product_fee")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int? ProductFee { get; set; }

                /// <summary>
                /// 获取或设置最后更新时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("modify_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("modify_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset ModifyTime { get; set; }

                /// <summary>
                /// 获取或设置申报结果说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("explanation")]
                [System.Text.Json.Serialization.JsonPropertyName("explanation")]
                public string? Explanation { get; set; }
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
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Record[] RecordList { get; set; } = default!;

        /// <summary>
        /// 获取或设置记录总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置验核机构。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_department")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_department")]
        public string? VerifyDepartment { get; set; }

        /// <summary>
        /// 获取或设置验核机构交易流水号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_department_trade_id")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_department_trade_id")]
        public string? VerifyDepartmentTradeId { get; set; }
    }
}
