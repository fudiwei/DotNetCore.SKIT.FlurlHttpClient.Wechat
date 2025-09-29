namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/dropship/supplier/search 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderDropshipSupplierSearchRequest : WechatApiRequest, IInferable<ChannelsECOrderDropshipSupplierSearchRequest, ChannelsECOrderDropshipSupplierSearchResponse>
    {
        public static class Types
        {
            public class SearchCondition
            {
                public static class Types
                {
                    public class TimeRange : ChannelsECOrderDropshipSupplierListRequest.Types.TimeRange
                    {
                    }
                }

                /// <summary>
                /// 获取或设置创建时间范围信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time_range")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time_range")]
                public Types.TimeRange? CreateTimeRange { get; set; }

                /// <summary>
                /// 获取或设置商家小店 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
                public string? ShopAppId { get; set; }

                /// <summary>
                /// 获取或设置代发单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int? Status { get; set; }

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string? OrderId { get; set; }

                /// <summary>
                /// 获取或设置运单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("waybill_id")]
                [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
                public string? WaybillId { get; set; }
            }

            public class Pagination : ChannelsECOrderDropshipSupplierListRequest.Types.Pagination
            {
            }
        }

        /// <summary>
        /// 获取或设置搜索条件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("search_condition")]
        [System.Text.Json.Serialization.JsonPropertyName("search_condition")]
        public Types.SearchCondition SearchCondition { get; set; } = new Types.SearchCondition();

        /// <summary>
        /// 获取或设置分页信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_info")]
        [System.Text.Json.Serialization.JsonPropertyName("page_info")]
        public Types.Pagination? Pagination { get; set; }
    }
}
