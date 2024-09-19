using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/freshinspect/submit 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderFreshInspectSubmitRequest : WechatApiRequest, IInferable<ChannelsECOrderFreshInspectSubmitRequest, ChannelsECOrderFreshInspectSubmitResponse>
    {
        public static class Types
        {
            public class AuditItem
            {
                /// <summary>
                /// 获取或设置审核项名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_name")]
                [System.Text.Json.Serialization.JsonPropertyName("item_name")]
                public string ItemName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置审核项值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_value")]
                [System.Text.Json.Serialization.JsonPropertyName("item_value")]
                public string ItemValue { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置审核项列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_items")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_items")]
        public IList<Types.AuditItem> AuditItemList { get; set; } = new List<Types.AuditItem>();
    }
}
