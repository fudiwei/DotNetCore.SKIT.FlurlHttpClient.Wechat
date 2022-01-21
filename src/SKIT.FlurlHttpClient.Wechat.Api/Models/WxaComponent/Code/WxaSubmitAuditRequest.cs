using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/submit_audit 接口的请求。</para>
    /// </summary>
    public class WxaSubmitAuditRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Page
            {
                /// <summary>
                /// 获取或设置页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string PagePath { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置页面标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置标签，使用空格分隔。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag")]
                [System.Text.Json.Serialization.JsonPropertyName("tag")]
                public string? Tag { get; set; }

                /// <summary>
                /// 获取或设置一级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_id")]
                [System.Text.Json.Serialization.JsonPropertyName("first_id")]
                public int? FirstCategoryId { get; set; }

                /// <summary>
                /// 获取或设置一级类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_class")]
                [System.Text.Json.Serialization.JsonPropertyName("first_class")]
                public string? FirstCategoryName { get; set; }

                /// <summary>
                /// 获取或设置二级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_id")]
                [System.Text.Json.Serialization.JsonPropertyName("second_id")]
                public int? SecondCategoryId { get; set; }

                /// <summary>
                /// 获取或设置二级类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_class")]
                [System.Text.Json.Serialization.JsonPropertyName("second_class")]
                public string? SecondCategoryName { get; set; }

                /// <summary>
                /// 获取或设置三级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_id")]
                [System.Text.Json.Serialization.JsonPropertyName("third_id")]
                public int? ThirdCategoryId { get; set; }

                /// <summary>
                /// 获取或设置三级类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_class")]
                [System.Text.Json.Serialization.JsonPropertyName("third_class")]
                public string? ThirdCategoryName { get; set; }
            }

            public class Preview
            {
                /// <summary>
                /// 获取或设置录屏视频 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_id_list")]
                [System.Text.Json.Serialization.JsonPropertyName("video_id_list")]
                public IList<string>? VideoMediaIdList { get; set; }

                /// <summary>
                /// 获取或设置屏幕截图 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pic_id_list")]
                [System.Text.Json.Serialization.JsonPropertyName("pic_id_list")]
                public IList<string>? PictureMediaIdList { get; set; }
            }

            public class UGCDeclaration
            {
                /// <summary>
                /// 获取或设置场景值列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene")]
                [System.Text.Json.Serialization.JsonPropertyName("scene")]
                public IList<int>? SceneLsit { get; set; }

                /// <summary>
                /// 获取或设置其他场景说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("other_scene_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("other_scene_desc")]
                public string? OtherSceneDescription { get; set; }

                /// <summary>
                /// 获取或设置审核机制列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("method")]
                [System.Text.Json.Serialization.JsonPropertyName("method")]
                public IList<int>? AuditMethodList { get; set; }

                /// <summary>
                /// 获取或设置是否有审核团队。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_audit_team")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("has_audit_team")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? HasAuditTeam { get; set; }

                /// <summary>
                /// 获取或设置审核机制说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_desc")]
                public string? AuditDescription { get; set; }

            }
        }

        /// <summary>
        /// 获取或设置审核页面列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_list")]
        [System.Text.Json.Serialization.JsonPropertyName("item_list")]
        public IList<Types.Page> PageList { get; set; } = new List<Types.Page>();

        /// <summary>
        /// 获取或设置预览信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("preview_info")]
        [System.Text.Json.Serialization.JsonPropertyName("preview_info")]
        public Types.Preview? Preview { get; set; }

        /// <summary>
        /// 获取或设置版本说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("version_desc")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// 获取或设置反馈内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feedback_info")]
        [System.Text.Json.Serialization.JsonPropertyName("feedback_info")]
        public string? Feedback { get; set; }

        /// <summary>
        /// 获取或设置反馈附件 MediaId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feedback_stuff")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithPipeSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("feedback_stuff")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithPipeSplitConverter))]
        public IList<string>? FeedbackStuffMediaIdList { get; set; }

        /// <summary>
        /// 获取或设置 UGC 声明信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ugc_declare")]
        [System.Text.Json.Serialization.JsonPropertyName("ugc_declare")]
        public Types.UGCDeclaration? UGCDeclaration { get; set; }
    }
}
