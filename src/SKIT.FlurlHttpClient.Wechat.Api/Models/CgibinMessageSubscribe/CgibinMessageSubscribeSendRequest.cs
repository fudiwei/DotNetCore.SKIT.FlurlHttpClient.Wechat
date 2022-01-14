using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/subscribe/send 接口的请求。</para>
    /// </summary>
    public class CgibinMessageSubscribeSendRequest : WechatApiRequest
    {
        public static class Types
        {
            public class DataItem
            {
                /// <summary>
                /// 获取或设置消息内容文本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置接收消息的用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("touser")]
        [System.Text.Json.Serialization.JsonPropertyName("touser")]
        public string ToUserOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订阅消息模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public string? MiniProgramPagePath { get; set; }

        /// <summary>
        /// 获取或设置小程序类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram_state")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram_state")]
        public string? MiniProgramState { get; set; }

        /// <summary>
        /// 获取或设置消息正文。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public IDictionary<string, Types.DataItem> Data { get; set; } = new Dictionary<string, Types.DataItem>();

        /// <summary>
        /// 获取或设置进入小程序的语言类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lang")]
        [System.Text.Json.Serialization.JsonPropertyName("lang")]
        public string? Language { get; set; }
    }
}
