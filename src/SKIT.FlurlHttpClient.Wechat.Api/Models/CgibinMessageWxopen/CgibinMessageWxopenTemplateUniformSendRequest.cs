using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/wxopen/template/uniform_send 接口的请求。</para>
    /// </summary>
    public class CgibinMessageWxopenTemplateUniformSendRequest : WechatApiRequest, IInferable<CgibinMessageWxopenTemplateUniformSendRequest, CgibinMessageWxopenTemplateUniformSendResponse>
    {
        public static class Types
        {
            public class MpTemplateMessage
            {
                public static class Types
                {
                    public class MiniProgram : CgibinMessageTemplateSendRequest.Types.MiniProgram
                    {
                    }

                    public class DataItem : CgibinMessageTemplateSendRequest.Types.DataItem
                    {
                    }
                }

                /// <summary>
                /// 获取或设置公众号 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置模板 ID。
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
            }
        }

        /// <summary>
        /// 获取或设置接收消息的用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("touser")]
        [System.Text.Json.Serialization.JsonPropertyName("touser")]
        public string ToUserOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公众号模板消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mp_template_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("mp_template_msg")]
        public Types.MpTemplateMessage? MpTemplateMessage { get; set; }
    }
}
