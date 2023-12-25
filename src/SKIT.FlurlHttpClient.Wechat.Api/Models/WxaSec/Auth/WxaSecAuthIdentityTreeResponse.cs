namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/authidentitytree 接口的响应。</para>
    /// </summary>
    public class WxaSecAuthIdentityTreeResponse : WechatApiResponse
    {
        public static class Types
        {
            public class IdentityTreeNode
            {
                public static class Types
                {
                    public class RootInfo
                    {
                        /// <summary>
                        /// 获取或设置类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }
                    }

                    public class LeafInfo
                    {
                        /// <summary>
                        /// 获取或设置需求。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("requirement")]
                        [System.Text.Json.Serialization.JsonPropertyName("requirement")]
                        public string? Requirement { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置节点 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("node_id")]
                [System.Text.Json.Serialization.JsonPropertyName("node_id")]
                public int NodeId { get; set; }

                /// <summary>
                /// 获取或设置节点名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string NodeName { get; set; } = default!;

                /// <summary>
                /// 获取或设置子节点列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("node_list")]
                [System.Text.Json.Serialization.JsonPropertyName("node_list")]
                public IdentityTreeNode[]? NodeList { get; set; }

                /// <summary>
                /// 获取或设置根节点信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("root_info")]
                [System.Text.Json.Serialization.JsonPropertyName("root_info")]
                public Types.RootInfo? RootInfo { get; set; }

                /// <summary>
                /// 获取或设置叶子节点信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("leaf_info")]
                [System.Text.Json.Serialization.JsonPropertyName("leaf_info")]
                public Types.LeafInfo? LeafInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置职业树节点列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("identity_tree_list")]
        [System.Text.Json.Serialization.JsonPropertyName("identity_tree_list")]
        public Types.IdentityTreeNode[] IdentityTreeList { get; set; } = default!;
    }
}
