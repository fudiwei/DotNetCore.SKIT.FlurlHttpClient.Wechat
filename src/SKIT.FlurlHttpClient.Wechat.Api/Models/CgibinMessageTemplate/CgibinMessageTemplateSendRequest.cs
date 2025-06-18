using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/template/send 接口的请求。</para>
    /// </summary>
    public class CgibinMessageTemplateSendRequest : WechatApiRequest, IInferable<CgibinMessageTemplateSendRequest, CgibinMessageTemplateSendResponse>
    {
        public static class Types
        {
            public class MiniProgram
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pagepath")]
                [System.Text.Json.Serialization.JsonPropertyName("pagepath")]
                public string PagePath { get; set; } = string.Empty;
            }

            public class DataItem
            {
                /// <summary>
                /// 获取或设置消息内容文本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置消息字体颜色（格式：#RRGGBB）。
                /// </summary>
                [Obsolete("相关接口或字段于 2023-05-04 下线。")]
                [Newtonsoft.Json.JsonProperty("color")]
                [System.Text.Json.Serialization.JsonPropertyName("color")]
                public string? Color { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置接收消息的用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("touser")]
        [System.Text.Json.Serialization.JsonPropertyName("touser")]
        public string ToUserOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置消息模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置点击消息跳转的链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 获取或设置点击消息跳转的小程序信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
        public Types.MiniProgram? MiniProgram { get; set; }

        /// <summary>
        /// 获取或设置消息正文。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public IDictionary<string, Types.DataItem>? Data { get; set; }

        /// <summary>
        /// 获取或设置调用方请求的唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("client_msg_id")]
        public string? ClientMessageId { get; set; }
    }
}
