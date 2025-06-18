namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/corp/get_chain_corpinfo_list 接口的响应。</para>
    /// </summary>
    public class CgibinCorpGroupCorpGetChainCorpInfoListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class GroupCorp
            {
                /// <summary>
                /// 获取或设置分组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("groupid")]
                [System.Text.Json.Serialization.JsonPropertyName("groupid")]
                public int GroupId { get; set; }

                /// <summary>
                /// 获取或设置企业 CorpId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("corpid")]
                public string? CorpId { get; set; }

                /// <summary>
                /// 获取或设置未加入的企业 CorpId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pending_corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("pending_corpid")]
                public string? PendingCorpId { get; set; }

                /// <summary>
                /// 获取或设置企业名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_name")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_name")]
                public string CorpName { get; set; } = default!;

                /// <summary>
                /// 获取或设置自定义 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_id")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_id")]
                public string? CustomId { get; set; }

                /// <summary>
                /// 获取或设置该上下游的邀请人的 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invite_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("invite_userid")]
                public string? InviteUserId { get; set; }

                /// <summary>
                /// 获取或设置企业是否已加入。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_joined")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_joined")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool IsJoined { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置企业上下游通讯录分组下的企业详情列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_corps")]
        [System.Text.Json.Serialization.JsonPropertyName("group_corps")]
        public Types.GroupCorp[] GroupCorpList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
