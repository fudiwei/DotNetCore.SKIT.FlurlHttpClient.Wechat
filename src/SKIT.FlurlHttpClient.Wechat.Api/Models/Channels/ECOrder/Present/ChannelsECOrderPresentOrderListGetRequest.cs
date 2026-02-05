using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/presentorderlist/get 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2025-12-08 下线。")]
    public class ChannelsECOrderPresentOrderListGetRequest : WechatApiRequest, IInferable<ChannelsECOrderPresentOrderListGetRequest, ChannelsECOrderPresentOrderListGetResponse>
    {
        public static class Types
        {
            public class TimeRange : ChannelsECOrderListGetRequest.Types.TimeRange
            {
            }
        }

        /// <summary>
        /// 获取或设置合作小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
        public string ShopAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置创建订单时间范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_range")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_range")]
        public Types.TimeRange? CreateTimeRange { get; set; }

        /// <summary>
        /// 获取或设置更新订单时间范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time_range")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time_range")]
        public Types.TimeRange? UpdateTimeRange { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? Cursor { get; set; }
    }
}
