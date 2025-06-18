using System;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_order_list 接口的响应。</para>
    /// </summary>
    public class CgibinServiceGetOrderListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Order
            {
                public static class Types
                {
                    public class DealerCorp : CgibinServiceGetAuthInfoResponse.Types.DealerCorp
                    {
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orderid")]
                [System.Text.Json.Serialization.JsonPropertyName("orderid")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                public int OrderStatus { get; set; }

                /// <summary>
                /// 获取或设置订单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_type")]
                [System.Text.Json.Serialization.JsonPropertyName("order_type")]
                public int OrderType { get; set; }

                /// <summary>
                /// 获取或设置购买方 CorpId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paid_corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("paid_corpid")]
                public string PayerCorpId { get; set; } = default!;

                /// <summary>
                /// 获取或设置下单方 CorpId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operator_corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("operator_corpid")]
                public string? OperatorCorpId { get; set; }

                /// <summary>
                /// 获取或设置操作员 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operator_id")]
                [System.Text.Json.Serialization.JsonPropertyName("operator_id")]
                public string? OperatorId { get; set; }

                /// <summary>
                /// 获取或设置第三方应用 SuiteId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("suiteid")]
                [System.Text.Json.Serialization.JsonPropertyName("suiteid")]
                public string? SuiteId { get; set; }

                /// <summary>
                /// 获取或设置第三方套件应用 ID。
                /// </summary>
                [Obsolete("相关接口或字段于 2020-01-13 下线。")]
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public int AppId { get; set; }

                /// <summary>
                /// 获取或设置版本 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("edition_id")]
                [System.Text.Json.Serialization.JsonPropertyName("edition_id")]
                public string EditionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置版本名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("edition_name")]
                [System.Text.Json.Serialization.JsonPropertyName("edition_name")]
                public string EditionName { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public int Price { get; set; }

                /// <summary>
                /// 获取或设置购买的人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_count")]
                [System.Text.Json.Serialization.JsonPropertyName("user_count")]
                public int PaidUserCount { get; set; }

                /// <summary>
                /// 获取或设置购买的天数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_period")]
                [System.Text.Json.Serialization.JsonPropertyName("order_period")]
                public int PaidDayCount { get; set; }

                /// <summary>
                /// 获取或设置下单时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_time")]
                [System.Text.Json.Serialization.JsonPropertyName("order_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置付款时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paid_time")]
                [System.Text.Json.Serialization.JsonPropertyName("paid_time")]
                public long PayTimestamp { get; set; }

                /// <summary>
                /// 获取或设置购买生效期的开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                public long BeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置购买生效期的结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置下单来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_from")]
                [System.Text.Json.Serialization.JsonPropertyName("order_from")]
                public int? OrderFrom { get; set; }

                /// <summary>
                /// 获取或设置服务商分成金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_share_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("service_share_amount")]
                public int? ServiceShareAmount { get; set; }

                /// <summary>
                /// 获取或设置平台分成金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("platform_share_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("platform_share_amount")]
                public int? PlatformShareAmount { get; set; }

                /// <summary>
                /// 获取或设置代理商分成金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dealer_share_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("dealer_share_amount")]
                public int? DealerShareAmount { get; set; }

                /// <summary>
                /// 获取或设置代理服务商企业信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dealer_corp_info")]
                [System.Text.Json.Serialization.JsonPropertyName("dealer_corp_info")]
                public Types.DealerCorp? DealerCorp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_list")]
        public Types.Order[] OrderList { get; set; } = default!;
    }
}
