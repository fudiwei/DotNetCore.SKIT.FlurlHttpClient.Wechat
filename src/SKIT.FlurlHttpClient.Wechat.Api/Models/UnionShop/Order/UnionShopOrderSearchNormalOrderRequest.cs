using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/shop/order/search_normal_order 接口的请求。</para>
    /// </summary>
    public class UnionShopOrderSearchNormalOrderRequest : WechatApiRequest, IInferable<UnionShopOrderSearchNormalOrderRequest, UnionShopOrderSearchNormalOrderResponse>
    {
        /// <summary>
        /// 获取或设置分页起始位置。
        /// <para>默认值：0</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置关键词。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Query { get; set; }

        /// <summary>
        /// 获取或设置推客 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? AllianceAppId { get; set; }

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long? OrderId { get; set; }

        /// <summary>
        /// 获取或设置商家自定义订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? OutOrderId { get; set; }

        /// <summary>
        /// 获取或设置商家自定义订单号列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string>? OutOrderIdList { get; set; }

        /// <summary>
        /// 获取或设置微信支付交易单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 获取或设置微信支付交易单号列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string>? TransactionIdList { get; set; }

        /// <summary>
        /// 获取或设置支付时间起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long? StartPayTimestamp { get; set; }

        /// <summary>
        /// 获取或设置支付时间结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long? EndPayTimestamp { get; set; }

        /// <summary>
        /// 获取或设置分佣状态。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? CommissionStatus { get; set; }

        /// <summary>
        /// 获取或设置订单状态更新时间起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long? StartStatusUpdateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置订单状态更新时间结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public long? EndStatusUpdateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置排序字段。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SortBy { get; set; }

        /// <summary>
        /// 获取或设置排序方式。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SortOrder { get; set; }
    }
}
