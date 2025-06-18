using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/searchguaranteeorder 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleSearchGuaranteeOrderRequest : WechatApiRequest, IInferable<ChannelsECAftersaleSearchGuaranteeOrderRequest, ChannelsECAftersaleSearchGuaranteeOrderResponse>
    {
        /// <summary>
        /// 获取或设置保障单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guarantee_order_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("guarantee_order_id_list")]
        public IList<long>? GuaranteeOrderIdList { get; set; }

        /// <summary>
        /// 获取或设置订单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id_list")]
        public IList<long>? OrderIdList { get; set; }

        /// <summary>
        /// 获取或设置保障单类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// 获取或设置保障单申请开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        public long BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置保障单申请结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置保障单状态列表。
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
    }
}
