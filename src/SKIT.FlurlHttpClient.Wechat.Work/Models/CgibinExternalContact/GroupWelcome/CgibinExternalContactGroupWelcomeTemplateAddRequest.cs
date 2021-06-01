using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/group_welcome_template/add 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGroupWelcomeTemplateAddRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Text : CgibinExternalContactSendWelcomeMessageRequest.Types.Text
            {
            }

            public class Image : CgibinExternalContactSendWelcomeMessageRequest.Types.Attachment.Types.Image
            {
            }

            public class Link : CgibinExternalContactSendWelcomeMessageRequest.Types.Attachment.Types.Link
            {
            }

            public class Video : CgibinExternalContactSendWelcomeMessageRequest.Types.Attachment.Types.Video
            {
            }

            public class MiniProgram : CgibinExternalContactSendWelcomeMessageRequest.Types.Attachment.Types.MiniProgram
            {
            }
        }

        /// <summary>
        /// 获取或设置文本消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public Types.Text? Text { get; set; }

        /// <summary>
        /// 获取或设置图片消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image")]
        [System.Text.Json.Serialization.JsonPropertyName("image")]
        public Types.Image? Image { get; set; }

        /// <summary>
        /// 获取或设置图文消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link")]
        [System.Text.Json.Serialization.JsonPropertyName("link")]
        public Types.Link? Link { get; set; }

        /// <summary>
        /// 获取或设置视频消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video")]
        [System.Text.Json.Serialization.JsonPropertyName("video")]
        public Types.Video? Video { get; set; }

        /// <summary>
        /// 获取或设置小程序消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
        public Types.MiniProgram? MiniProgram { get; set; }

        /// <summary>
        /// 获取或设置是否通知成员将这条入群欢迎语应用到客户群中。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("notify")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedNullableBooleanConverter))]
        public bool? RequireNotify { get; set; }

        /// <summary>
        /// 获取或设置授权方安装的应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }
    }
}
