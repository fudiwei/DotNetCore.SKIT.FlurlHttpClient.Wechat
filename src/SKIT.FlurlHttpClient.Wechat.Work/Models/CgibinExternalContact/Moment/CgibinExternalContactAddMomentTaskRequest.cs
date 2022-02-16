using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/add_moment_task 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactAddMomentTaskRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Text
            {
                /// <summary>
                /// 获取或设置文本消息内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = string.Empty;
            }

            public class Attachment
            {
                public static class Types
                {
                    public class Image
                    {
                        /// <summary>
                        /// 获取或设置图片 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public string MediaId { get; set; } = string.Empty;
                    }

                    public class Link
                    {
                        /// <summary>
                        /// 获取或设置图文消息标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置图文消息 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string Url { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置图文消息封面 MediaId。。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public string? PictureMediaId { get; set; }
                    }

                    public class Video
                    {
                        /// <summary>
                        /// 获取或设置视频 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public string MediaId { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置附件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgtype")]
                [System.Text.Json.Serialization.JsonPropertyName("msgtype")]
                public string Type { get; set; } = string.Empty;

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
            }

            public class VisibleRange
            {
                public static class Types
                {
                    public class Sender
                    {
                        /// <summary>
                        /// 获取或设置发表任务的执行者用户 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_list")]
                        public IList<string>? UserIdList { get; set; }

                        /// <summary>
                        /// 获取或设置发表任务的执行者部门 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("department_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("department_list")]
                        public IList<long>? DepartmentIdList { get; set; }
                    }

                    public class ExternalContact
                    {
                        /// <summary>
                        /// 获取或设置可见到该朋友圈的客户标签 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tag_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("tag_list")]
                        public IList<int>? TagIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置发表任务的执行者信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sender_list")]
                [System.Text.Json.Serialization.JsonPropertyName("sender_list")]
                public Types.Sender? Sender { get; set; }

                /// <summary>
                /// 获取或设置可见到该朋友圈的客户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_contact_list")]
                [System.Text.Json.Serialization.JsonPropertyName("external_contact_list")]
                public Types.ExternalContact? ExternalContact { get; set; }
            }
        }

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

        /// <summary>
        /// 获取或设置发表范围信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("visible_range")]
        [System.Text.Json.Serialization.JsonPropertyName("visible_range")]
        public Types.VisibleRange? VisibleRange { get; set; }
    }
}
