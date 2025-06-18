using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/sendmsg 接口的请求。</para>
    /// </summary>
    public class PromoterSendMessageRequest : PublisherStatSettlementRequest, IInferable<PromoterSendMessageRequest, PromoterSendMessageResponse>
    {
        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_type")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_type")]
        public int MessageType { get; set; }

        /// <summary>
        /// 获取或设置消息内容 JSON 字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string ContentJson { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置小程序跳转路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? PagePath { get; set; }

        /// <summary>
        /// 获取或设置下发类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list_type")]
        [System.Text.Json.Serialization.JsonPropertyName("list_type")]
        public int ListType { get; set; }

        /// <summary>
        /// 获取或设置角色 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role_id")]
        [System.Text.Json.Serialization.JsonPropertyName("role_id")]
        public IList<int>? RoleIdList { get; set; }

        /// <summary>
        /// 获取或设置门店 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retail_id")]
        [System.Text.Json.Serialization.JsonPropertyName("retail_id")]
        public IList<string>? RetailIdList { get; set; }

        /// <summary>
        /// 获取或设置推广员 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public IList<string>? PromoterIdList { get; set; }
    }
}
