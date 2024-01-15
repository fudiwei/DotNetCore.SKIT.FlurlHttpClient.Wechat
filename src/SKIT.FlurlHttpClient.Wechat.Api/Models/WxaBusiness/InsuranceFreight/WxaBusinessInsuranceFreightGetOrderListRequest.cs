using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/insurance_freight/getorderlist 接口的请求。</para>
    /// </summary>
    public class WxaBusinessInsuranceFreightGetOrderListRequest : WechatApiRequest, IInferable<WxaBusinessInsuranceFreightGetOrderListRequest, WxaBusinessInsuranceFreightGetOrderListResponse>
    {
        /// <summary>
        /// 获取或设置买家用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置微信支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("order_no")]
        public string? OrderNumber { get; set; }

        /// <summary>
        /// 获取或设置保单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_no")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_no")]
        public string? PolicyNumber { get; set; }

        /// <summary>
        /// 获取或设置理赔报案号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("report_no")]
        [System.Text.Json.Serialization.JsonPropertyName("report_no")]
        public string? ReportNumber { get; set; }

        /// <summary>
        /// 获取或设置发货运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_no")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_no")]
        public string? DeliveryNumber { get; set; }

        /// <summary>
        /// 获取或设置退款运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_delivery_no")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_delivery_no")]
        public string? RefundDeliveryNumber { get; set; }

        /// <summary>
        /// 获取或设置查询开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        public long? BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置查询结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置保单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_list")]
        [System.Text.Json.Serialization.JsonPropertyName("status_list")]
        public IList<int>? StatusList { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 获取或设置排序方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort_direct")]
        [System.Text.Json.Serialization.JsonPropertyName("sort_direct")]
        public int? SortDirectionType { get; set; }
    }
}
