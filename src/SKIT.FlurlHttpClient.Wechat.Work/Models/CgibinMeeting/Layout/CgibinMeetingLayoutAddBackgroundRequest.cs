using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/layout/add_background 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingLayoutAddBackgroundRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class BackgroundImage
            {
                /// <summary>
                /// 获取或设置背景图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_url")]
                [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                public string ImageUrl { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置背景图片 MD5 值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_md5")]
                [System.Text.Json.Serialization.JsonPropertyName("image_md5")]
                public string ImageMd5 { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置背景图片列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_list")]
        [System.Text.Json.Serialization.JsonPropertyName("image_list")]
        public IList<Types.BackgroundImage> BackgroundImageList { get; set; } = new List<Types.BackgroundImage>();

        /// <summary>
        /// 获取或设置默认背景图片序号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("default_image_order")]
        [System.Text.Json.Serialization.JsonPropertyName("default_image_order")]
        public int? DefaultBackgroundOrder { get; set; }
    }
}
