namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/space_info 接口的响应。</para>
    /// </summary>
    public class CgibinWedriveSpaceInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Space
            {
                public static class Types
                {
                    public class ACL
                    {
                        /// <summary>
                        /// 获取或设置空间授权信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("auth_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("auth_info")]
                        public List<Authority>? AuthorityList { get; set; }

                        /// <summary>
                        /// 获取或设置空间无权限成员列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quit_userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("quit_userid")]
                        public List<string>? QuitUserIdList { get; set; }
                    }

                    public class Authority : CgibinWedriveSpaceCreateRequest.Types.Authority
                    {
                    }
                }

                /// <summary>
                /// 获取或设置空间 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spaceid")]
                [System.Text.Json.Serialization.JsonPropertyName("spaceid")]
                public string? SpaceId { get; set; }

                /// <summary>
                /// 获取或设置空间标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("space_name")]
                [System.Text.Json.Serialization.JsonPropertyName("space_name")]
                public string? SpaceName { get; set; }

                /// <summary>
                /// 获取或设置访问控制信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_list")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_list")]
                public Types.ACL? ACL { get; set; }

                /// <summary>
                /// 获取或设置空间类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("space_sub_type")]
                [System.Text.Json.Serialization.JsonPropertyName("space_sub_type")]
                public int SpaceSubType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置空间信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("space_info")]
        [System.Text.Json.Serialization.JsonPropertyName("space_info")]
        public Types.Space? Space { get; set; }
    }
}
