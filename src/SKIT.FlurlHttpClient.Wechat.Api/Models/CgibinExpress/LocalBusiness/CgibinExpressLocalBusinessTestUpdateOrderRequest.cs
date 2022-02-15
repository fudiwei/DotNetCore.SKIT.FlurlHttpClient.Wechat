using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/local/business/test_update_order 接口的请求。</para>
    /// </summary>
    public class CgibinExpressLocalBusinessTestUpdateOrderRequest : CgibinExpressLocalBusinessRequestBase, IMapResponse<CgibinExpressLocalBusinessTestUpdateOrderRequest, CgibinExpressLocalBusinessTestUpdateOrderResponse>
    {
        /// <summary>
        /// 获取或设置配送状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
        public int OrderStatus { get; set; }

        /// <summary>
        /// 获取或设置状态变更时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_time")]
        [System.Text.Json.Serialization.JsonPropertyName("action_time")]
        public long ActionTimestamp { get; set; }

        /// <summary>
        /// 获取或设置附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("action_msg")]
        public string? ActionMessage { get; set; }
    }
}
