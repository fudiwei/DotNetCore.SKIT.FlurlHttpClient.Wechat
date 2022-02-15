using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/getorderlist 接口的请求。</para>
    /// </summary>
    public class NontaxGetOrderListRequest : WechatApiRequest, IMapResponse<NontaxGetOrderListRequest, NontaxGetOrderListResponse>
    {
        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置订单外部编号。与字段 <see cref="PaymentNoticeNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("order_no")]
        public string? OrderOutId { get; set; }

        /// <summary>
        /// 获取或设置缴费通知书编号。与字段 <see cref="OrderOutId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_notice_no")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_notice_no")]
        public string? PaymentNoticeNumber { get; set; }

        /// <summary>
        /// 获取或设置执收单位编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("department_code")]
        [System.Text.Json.Serialization.JsonPropertyName("department_code")]
        public string DepartmentCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置行政区划代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region_code")]
        [System.Text.Json.Serialization.JsonPropertyName("region_code")]
        public string RegionCode { get; set; } = string.Empty;
    }
}
