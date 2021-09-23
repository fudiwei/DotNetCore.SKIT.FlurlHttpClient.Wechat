namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_moment_comments 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGetMomentCommentsResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Interaction
            {
                /// <summary>
                /// 获取或设置互动的外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置互动的外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string? ExternalUserId { get; set; }

                /// <summary>
                /// 获取或设置互动时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置评论列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment_list")]
        [System.Text.Json.Serialization.JsonPropertyName("comment_list")]
        public Types.Interaction[] CommentList { get; set; } = default!;

        /// <summary>
        /// 获取或设置点赞列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("like_list")]
        [System.Text.Json.Serialization.JsonPropertyName("like_list")]
        public Types.Interaction[] LikeList { get; set; } = default!;
    }
}
