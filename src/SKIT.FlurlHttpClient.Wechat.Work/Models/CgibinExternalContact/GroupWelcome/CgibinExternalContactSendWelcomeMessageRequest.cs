using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/send_welcome_msg 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactSendWelcomeMessageRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Text : CgibinExternalContactAddMessageTemplateRequest.Types.Text
            {
            }

            public class Attachment : CgibinExternalContactAddMessageTemplateRequest.Types.Attachment
            {
            }
        }

        /// <summary>
        /// 获取或设置发送欢迎语的凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("welcome_code")]
        [System.Text.Json.Serialization.JsonPropertyName("welcome_code")]
        public string WelcomeCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文本消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public Types.Text? Text { get; set; }

        /// <summary>
        /// 获取或设置附件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attachments")]
        [System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public IList<Types.Attachment>? AttachmentList { get; set; }
    }
}
