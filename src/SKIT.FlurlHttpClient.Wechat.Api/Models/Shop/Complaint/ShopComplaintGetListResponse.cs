namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/complaint/get_list 接口的响应。</para>
    /// </summary>
    public class ShopComplaintGetListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class ComplaintOrder
            {
                /// <summary>
                /// 获取或设置关联订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public long OrderId { get; set; }

                /// <summary>
                /// 获取或设置关联售后单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("after_sale_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("after_sale_order_id")]
                public long AftersaleOrderId { get; set; }

                /// <summary>
                /// 获取或设置纠纷单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("complaint_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("complaint_order_id")]
                public long ComplaintOrderId { get; set; }

                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户电话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone_number")]
                [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
                public string PhoneNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public int State { get; set; }

                /// <summary>
                /// 获取或设置类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置申请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置当前状态超时时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expired_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expired_time")]
                public long ExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置判责结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("judge_result")]
                [System.Text.Json.Serialization.JsonPropertyName("judge_result")]
                public int JudgeResult { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置售后单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orders")]
        [System.Text.Json.Serialization.JsonPropertyName("orders")]
        public Types.ComplaintOrder[] ComplaintList { get; set; } = default!;

        /// <summary>
        /// 获取或设置售后单总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }
    }
}
