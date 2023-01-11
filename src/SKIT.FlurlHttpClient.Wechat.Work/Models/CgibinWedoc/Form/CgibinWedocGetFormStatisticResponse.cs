namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/get_form_statistic 接口的响应。</para>
    /// </summary>
    public class CgibinWedocGetFormStatisticResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class FillUser
            {
                /// <summary>
                /// 获取或设置用户成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置外部联系人临时 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tmp_external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("tmp_external_userid")]
                public string? TempExternalUserId { get; set; }

                /// <summary>
                /// 获取或设置用户名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_name")]
                [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                public string UserName { get; set; } = default!;

                /// <summary>
                /// 获取或设置答案 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("answer_id")]
                [System.Text.Json.Serialization.JsonPropertyName("answer_id")]
                public long AnswerId { get; set; }

                /// <summary>
                /// 获取或设置提交时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("submit_time")]
                [System.Text.Json.Serialization.JsonPropertyName("submit_time")]
                public long SubmitTimestamp { get; set; }
            }

            public class UnfillUser
            {
                /// <summary>
                /// 获取或设置用户成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_name")]
                [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                public string UserName { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置已填写次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fill_cnt")]
        [System.Text.Json.Serialization.JsonPropertyName("fill_cnt")]
        public int FillCount { get; set; }

        /// <summary>
        /// 获取或设置已填写人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fill_user_cnt")]
        [System.Text.Json.Serialization.JsonPropertyName("fill_user_cnt")]
        public int FillUserCount { get; set; }

        /// <summary>
        /// 获取或设置未填写人数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unfill_user_cnt")]
        [System.Text.Json.Serialization.JsonPropertyName("unfill_user_cnt")]
        public int UnfillUserCount { get; set; }

        /// <summary>
        /// 获取或设置已填写人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("submit_users")]
        [System.Text.Json.Serialization.JsonPropertyName("submit_users")]
        public Types.FillUser[]? FillUserList { get; set; }

        /// <summary>
        /// 获取或设置未填写人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unfill_users")]
        [System.Text.Json.Serialization.JsonPropertyName("unfill_users")]
        public Types.UnfillUser[]? UnfillUserList { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public int? NextCursor { get; set; }
    }
}
