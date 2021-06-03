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
            public class TextMessage : CgibinExternalContactSendWelcomeMessageRequest.Types.TextMessage
            {
            }

            public class ImageMessage : CgibinExternalContactSendWelcomeMessageRequest.Types.Attachment.Types.Image
            {
            }

            public class LinkMessage : CgibinExternalContactSendWelcomeMessageRequest.Types.Attachment.Types.Link
            {
            }

            public class VideoMessage : CgibinExternalContactSendWelcomeMessageRequest.Types.Attachment.Types.Video
            {
            }

            public class MiniProgramMessage : CgibinExternalContactSendWelcomeMessageRequest.Types.Attachment.Types.MiniProgram
            {
            }
        }

        /// <summary>
        /// 获取或设置文本消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public Types.TextMessage? Text { get; set; }

        /// <summary>
        /// 获取或设置图片消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image")]
        [System.Text.Json.Serialization.JsonPropertyName("image")]
        public Types.ImageMessage? Image { get; set; }

        /// <summary>
        /// 获取或设置图文消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link")]
        [System.Text.Json.Serialization.JsonPropertyName("link")]
        public Types.LinkMessage? Link { get; set; }

        /// <summary>
        /// 获取或设置视频消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video")]
        [System.Text.Json.Serialization.JsonPropertyName("video")]
        public Types.VideoMessage? Video { get; set; }

        /// <summary>
        /// 获取或设置小程序消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("miniprogram")]
        [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
        public Types.MiniProgramMessage? MiniProgram { get; set; }

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
