namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.wxa_comment_bad_score 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/guarantee/comment.html#_4-1%E5%B7%AE%E8%AF%84%E9%80%9A%E7%9F%A5CallBack ]]>
    /// </para>
    /// </summary>
    public class WxaCommentBadScoreEvent : WechatApiEvent
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置评价 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("comment_id")]
                [System.Text.Json.Serialization.JsonPropertyName("comment_id")]
                [System.Xml.Serialization.XmlElement("comment_id")]
                public string CommentId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置评价结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        [System.Xml.Serialization.XmlElement("result")]
        public Types.Result Result { get; set; } = default!;
    }
}
