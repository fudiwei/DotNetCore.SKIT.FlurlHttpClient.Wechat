using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/business/path/get 接口的响应。</para>
    /// </summary>
    public class CgibinExpressBusinessPathGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class PathItem
            {
                /// <summary>
                /// 获取或设置轨迹节点时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("action_time")]
                [System.Text.Json.Serialization.JsonPropertyName("action_time")]
                public long ActionTimestamp { get; set; }

                /// <summary>
                /// 获取或设置轨迹节点类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("action_type")]
                [System.Text.Json.Serialization.JsonPropertyName("action_type")]
                public int ActionType { get; set; }

                /// <summary>
                /// 获取或设置轨迹节点详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("action_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("action_msg")]
                public string ActionMessage { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置快递公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string DeliveryId { get; set; } = default!;

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = default!;

        /// <summary>
        /// 获取或设置轨迹节点列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path_item_list")]
        [System.Text.Json.Serialization.JsonPropertyName("path_item_list")]
        public Types.PathItem[] PathItemList { get; set; } = default!;

        /// <summary>
        /// 获取或设置轨迹节点数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path_item_num")]
        [System.Text.Json.Serialization.JsonPropertyName("path_item_num")]
        public int PathItemCount { get; set; }
    }
}
