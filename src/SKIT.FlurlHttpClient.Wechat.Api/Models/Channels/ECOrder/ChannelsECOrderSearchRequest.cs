namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/search 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderSearchRequest : WechatApiRequest, IInferable<ChannelsECOrderSearchRequest, ChannelsECOrderSearchResponse>
    {
        public static class Types
        {
            public class SearchCondition
            {
                /// <summary>
                /// 获取或设置商品标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置商品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_code")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_code")]
                public string? SKUCode { get; set; }

                /// <summary>
                /// 获取或设置收件人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_name")]
                [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                public string? UserName { get; set; }

                /// <summary>
                /// 获取或设置收件人电话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tel_number")]
                [System.Text.Json.Serialization.JsonPropertyName("tel_number")]
                public string? TeleNumber { get; set; }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string? OrderId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置搜索条件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_condition")]
        [System.Text.Json.Serialization.JsonPropertyName("search_condition")]
        public Types.SearchCondition SearchCondition { get; set; } = new Types.SearchCondition();

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 获取或设置售后订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("on_aftersale_order_exist")]
        [System.Text.Json.Serialization.JsonPropertyName("on_aftersale_order_exist")]
        public int? OnAftersaleOrderStatus { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;
    }
}
