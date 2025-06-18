namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/comment/commentinfo/get 接口的响应。</para>
    /// </summary>
    public class WxaApiCommentInfoGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Comment : WxaApiCommentMpCommentListGetResponse.Types.Comment
                    {
                    }
                }

                /// <summary>
                /// 获取或设置评价信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public Types.Comment Comment { get; set; } = default!;
            }

            public class Process
            {
                public static class Types
                {
                    public class ActionInfo
                    {
                        /// <summary>
                        /// 获取或设置进度类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("updateTime")]
                        [System.Text.Json.Serialization.JsonPropertyName("updateTime")]
                        public long? UpdateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置评价 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commentId")]
                [System.Text.Json.Serialization.JsonPropertyName("commentId")]
                public string CommentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置进度信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("actionList")]
                [System.Text.Json.Serialization.JsonPropertyName("actionList")]
                public Types.ActionInfo[] ActionList { get; set; } = default!;
            }

            public class OldComment
            {
                public static class Types
                {
                    public class ContentInfo : Data.Types.Comment.Types.ContentInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置评价 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commentId")]
                [System.Text.Json.Serialization.JsonPropertyName("commentId")]
                public string CommentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("createTime")]
                [System.Text.Json.Serialization.JsonPropertyName("createTime")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置评价分数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("score")]
                [System.Text.Json.Serialization.JsonPropertyName("score")]
                public int Score { get; set; }

                /// <summary>
                /// 获取或设置评价内容信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public Types.ContentInfo ContentInfo { get; set; } = default!;
            }

        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.Data Data { get; set; } = default!;

        /// <summary>
        /// 获取或设置处理进度信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("processInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("processInfo")]
        public Types.Process? Process { get; set; }

        /// <summary>
        /// 获取或设置旧评价信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("oldComment")]
        [System.Text.Json.Serialization.JsonPropertyName("oldComment")]
        public Types.OldComment? OldComment { get; set; }
    }
}
