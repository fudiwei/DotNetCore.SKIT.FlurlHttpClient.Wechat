namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/corp/get_chain_group 接口的响应。</para>
    /// </summary>
    public class CgibinCorpGroupCropGetChainGroupResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Group
            {
                /// <summary>
                /// 获取或设置分组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("groupid")]
                [System.Text.Json.Serialization.JsonPropertyName("groupid")]
                public int GroupId { get; set; }

                /// <summary>
                /// 获取或设置分组名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_name")]
                [System.Text.Json.Serialization.JsonPropertyName("group_name")]
                public string GroupName { get; set; } = default!;

                /// <summary>
                /// 获取或设置上级分组名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parentid")]
                [System.Text.Json.Serialization.JsonPropertyName("parentid")]
                public int ParentGroupId { get; set; }

                /// <summary>
                /// 获取或设置在上级分组中的次序值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order")]
                [System.Text.Json.Serialization.JsonPropertyName("order")]
                public long GroupOrder { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置企业上下游通讯录分组列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groups")]
        [System.Text.Json.Serialization.JsonPropertyName("groups")]
        public Types.Group[] GroupList { get; set; } = default!;
    }
}
