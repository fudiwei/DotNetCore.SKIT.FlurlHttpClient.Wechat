namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_groupmsg_list_v2 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetGroupMessageListV2Response : WechatWorkResponse
    {
        public static class Types
        {
            public class GroupMessage
            {
                public static class Types
                {
                    public class Text : CgibinExternalContactAddMessageTemplateRequest.Types.Text
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
                /// 获取或设置群发消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgid")]
                [System.Text.Json.Serialization.JsonPropertyName("msgid")]
                public string? MessageId { get; set; }

                /// <summary>
                /// 获取或设置创建者成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creator")]
                [System.Text.Json.Serialization.JsonPropertyName("creator")]
                public string? CreatorUserId { get; set; }

                /// <summary>
                /// 获取或设置创建类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_type")]
                [System.Text.Json.Serialization.JsonPropertyName("create_type")]
                public int CreateType { get; set; }

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
                public List<Types.Attachment>? AttachmentList { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置群发消息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_msg_list")]
        [System.Text.Json.Serialization.JsonPropertyName("group_msg_list")]
        public List<Types.GroupMessage>? GroupMessageList { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
