namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/send_welcome_msg 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactSendWelcomeMessageRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class TextMessage : CgibinExternalContactAddMessageTemplateRequest.Types.Text
            {
            }

            public class Attachment
            {
                public static class Types
                {
                    public class Image : CgibinExternalContactAddMessageTemplateRequest.Types.Attachment.Types.Image
                    {
                    }

                    public class Link : CgibinExternalContactAddMessageTemplateRequest.Types.Attachment.Types.Link
                    {
                    }

                    public class Video : CgibinExternalContactAddMessageTemplateRequest.Types.Attachment.Types.Video
                    {
                    }

                    public class MiniProgram : CgibinExternalContactAddMessageTemplateRequest.Types.Attachment.Types.MiniProgram
                    {
                    }

                    public class File : CgibinExternalContactAddMessageTemplateRequest.Types.Attachment.Types.File
                    {
                    }
                }

                /// <summary>
                /// 获取或设置附件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgtype")]
                [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
                public string? Type { get; set; }

                /// <summary>
                /// 获取或设置图片附件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image")]
                [System.Text.Json.Serialization.JsonPropertyName("image")]
                public Types.Image? Image { get; set; }

                /// <summary>
                /// 获取或设置图文消息附件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("link")]
                [System.Text.Json.Serialization.JsonPropertyName("link")]
                public Types.Link? Link { get; set; }

                /// <summary>
                /// 获取或设置视频附件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video")]
                [System.Text.Json.Serialization.JsonPropertyName("video")]
                public Types.Video? Video { get; set; }

                /// <summary>
                /// 获取或设置小程序附件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("miniprogram")]
                [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
                public Types.MiniProgram? MiniProgram { get; set; }

                /// <summary>
                /// 获取或设置文件附件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file")]
                [System.Text.Json.Serialization.JsonPropertyName("file")]
                public Types.File? File { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置发送欢迎语的凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("welcome_code")]
        [System.Text.Json.Serialization.JsonPropertyName("welcome_code")]
        public string? WelcomeCode { get; set; }

        /// <summary>
        /// 获取或设置文本消息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text")]
        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public Types.TextMessage? Text { get; set; }

        /// <summary>
        /// 获取或设置附件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attachments")]
        [System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public List<Types.Attachment>? AttachmentList { get; set; }
    }
}
