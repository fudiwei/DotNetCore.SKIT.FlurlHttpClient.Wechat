namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/getcomplaintorder 接口的响应。</para>
    /// </summary>
    public class ChannelsECAftersaleGetComplaintOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class ComplaintHistory
            {
                /// <summary>
                /// 获取或设置历史操作类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_type")]
                [System.Text.Json.Serialization.JsonPropertyName("item_type")]
                public int ItemType { get; set; }

                /// <summary>
                /// 获取或设置时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time")]
                [System.Text.Json.Serialization.JsonPropertyName("time")]
                public long Timestamp { get; set; }

                /// <summary>
                /// 获取或设置内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string? Content { get; set; }

                /// <summary>
                /// 获取或设置图片 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id_list")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id_list")]
                public string[]? MediaIdList { get; set; }

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone_number")]
                [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
                public string? PhoneNumber { get; set; }

                /// <summary>
                /// 获取或设置纠纷类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complaint_type")]
                [System.Text.Json.Serialization.JsonPropertyName("complaint_type")]
                public int? ComplaintType { get; set; }

                /// <summary>
                /// 获取或设置售后类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("after_sale_type")]
                [System.Text.Json.Serialization.JsonPropertyName("after_sale_type")]
                public int? AftersaleType { get; set; }

                /// <summary>
                /// 获取或设置售后原因类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("after_sale_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("after_sale_reason")]
                public int? AftersaleReasonType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_order_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
        public string AftersaleOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置纠纷历史列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("history")]
        [System.Text.Json.Serialization.JsonPropertyName("history")]
        public Types.ComplaintHistory[] ComplaintHistoryList { get; set; } = default!;

        /// <summary>
        /// 获取或设置纠纷单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
