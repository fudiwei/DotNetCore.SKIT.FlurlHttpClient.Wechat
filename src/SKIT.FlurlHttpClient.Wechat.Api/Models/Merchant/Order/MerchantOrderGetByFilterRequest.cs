using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/order/getbyfilter 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2020-10-01 下线。")]
    public class MerchantOrderGetByFilterRequest : WechatApiRequest, IInferable<MerchantOrderGetByFilterRequest, MerchantOrderGetByFilterResponse>
    {
        /// <summary>
        /// 获取或设置指定订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// 获取或设置指定订单创建时间起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begintime")]
        [System.Text.Json.Serialization.JsonPropertyName("begintime")]
        public long? BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置指定订单创建时间终止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endtime")]
        [System.Text.Json.Serialization.JsonPropertyName("endtime")]
        public long? EndTimestamp { get; set; }
    }
}
