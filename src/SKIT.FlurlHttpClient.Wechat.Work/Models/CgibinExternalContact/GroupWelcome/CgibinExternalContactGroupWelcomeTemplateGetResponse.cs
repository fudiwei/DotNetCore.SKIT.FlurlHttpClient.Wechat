namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/group_welcome_template/get 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGroupWelcomeTemplateGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class TextMessage : CgibinExternalContactGroupWelcomeTemplateAddRequest.Types.TextMessage
            {
            }

            public class ImageMessage : CgibinExternalContactGroupWelcomeTemplateAddRequest.Types.ImageMessage
            {
            }

            public class LinkMessage : CgibinExternalContactGroupWelcomeTemplateAddRequest.Types.LinkMessage
            {
            }

            public class VideoMessage : CgibinExternalContactGroupWelcomeTemplateAddRequest.Types.VideoMessage
            {
            }

            public class MiniProgramMessage : CgibinExternalContactGroupWelcomeTemplateAddRequest.Types.MiniProgramMessage
            {
            }

            public class FileMessage : CgibinExternalContactSendWelcomeMessageRequest.Types.Attachment.Types.File
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
        /// 获取或设置图文链接消息信息。
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
        /// 获取或设置文件消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file")]
        [System.Text.Json.Serialization.JsonPropertyName("file")]
        public Types.FileMessage? File { get; set; }

        /// <summary>
        /// 获取或设置授权方安装的应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }
    }
}
