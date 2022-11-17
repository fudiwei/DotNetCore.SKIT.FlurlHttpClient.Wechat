namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/get_active_info_by_code 接口的响应。</para>
    /// </summary>
    public class CgibinLicenseGetActiveInfoByCodeResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class ActiveInfo
            {
                public static class Types
                {
                    public class MergeInfo
                    {
                        /// <summary>
                        /// 获取或设置新激活码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("to_active_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("to_active_code")]
                        public string ToActiveCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置原激活码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("from_active_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("from_active_code")]
                        public string FromActiveCode { get; set; } = default!;
                    }

                    public class ShareInfo
                    {
                        /// <summary>
                        /// 获取或设置新企业 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("to_corpid")]
                        [System.Text.Json.Serialization.JsonPropertyName("to_corpid")]
                        public string ToCorpId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置原企业 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("from_corpid")]
                        [System.Text.Json.Serialization.JsonPropertyName("from_corpid")]
                        public string FromCorpId { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置账号激活码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("active_code")]
                [System.Text.Json.Serialization.JsonPropertyName("active_code")]
                public string ActiveCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置账号类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置账号状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置激活的成员 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置激活时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("active_time")]
                [System.Text.Json.Serialization.JsonPropertyName("active_time")]
                public long? ActiveTimestamp { get; set; }

                /// <summary>
                /// 获取或设置过期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public long? ExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置合并信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merge_info")]
                [System.Text.Json.Serialization.JsonPropertyName("merge_info")]
                public Types.MergeInfo? MergeInfo { get; set; }

                /// <summary>
                /// 获取或设置分享信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_info")]
                [System.Text.Json.Serialization.JsonPropertyName("share_info")]
                public Types.ShareInfo? ShareInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置账号激活信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("active_info")]
        [System.Text.Json.Serialization.JsonPropertyName("active_info")]
        public Types.ActiveInfo ActiveInfo { get; set; } = default!;
    }
}
