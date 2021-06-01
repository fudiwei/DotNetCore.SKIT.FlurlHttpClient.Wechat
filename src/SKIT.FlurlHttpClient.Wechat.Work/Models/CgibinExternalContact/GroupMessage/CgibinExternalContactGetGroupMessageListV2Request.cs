using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_groupmsg_list_v2 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGetGroupMessageListV2Request : WechatWorkRequest
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
                        /// 获取或设置图片 MediaId。与字段 <see cref="PictureUrl"/> 二选一。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                        public string? MediaId { get; set; }

                        /// <summary>
                        /// 获取或设置图片 URL。与字段 <see cref="MediaId"/> 二选一。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pic_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("pic_url")]
                        public string? PictureUrl { get; set; }
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
                        /// 获取或设置图文消息描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string? Description { get; set; }

                        /// <summary>
                        /// 获取或设置图文消息 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string Url { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置图文消息封面 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("picurl")]
                        [System.Text.Json.Serialization.JsonPropertyName("picurl")]
                        public string? PictureUrl { get; set; }
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
                        [Newtonsoft.Json.JsonProperty("page")]
                        [System.Text.Json.Serialization.JsonPropertyName("page")]
                        public string PagePath { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置小程序标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置小程序封面 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pic_media_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("pic_media_id")]
                        public string? PictureMediaId { get; set; }
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

                /// <summary>
                /// 获取或设置小程序附件信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("miniprogram")]
                [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
                public Types.MiniProgram? MiniProgram { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置指定群发任务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chat_type")]
        [System.Text.Json.Serialization.JsonPropertyName("chat_type")]
        public string ChatType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置指定开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置指定结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置指定创建者成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("creator")]
        [System.Text.Json.Serialization.JsonPropertyName("creator")]
        public string? CreatorUserId { get; set; }

        /// <summary>
        /// 获取或设置指定创建类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filter_type")]
        [System.Text.Json.Serialization.JsonPropertyName("filter_type")]
        public int? CreateType { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? NextCursor { get; set; }
    }
}
