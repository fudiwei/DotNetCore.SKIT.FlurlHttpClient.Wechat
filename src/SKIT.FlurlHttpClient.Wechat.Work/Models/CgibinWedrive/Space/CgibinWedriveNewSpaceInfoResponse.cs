namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/new_space_info 接口的响应。</para>
    /// </summary>
    public class CgibinWedriveNewSpaceInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Space : CgibinWedriveSpaceInfoResponse.Types.Space
            {
                public static new class Types
                {
                    public class ACL : CgibinWedriveSpaceInfoResponse.Types.Space.Types.ACL
                    {
                    }

                    public class Authority  : CgibinWedriveSpaceInfoResponse.Types.Space.Types.Authority
                    {
                    }

                    public class SecureSettings
                    {
                        /// <summary>
                        /// 获取或设置是否启用水印。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("enable_watermark")]
                        [System.Text.Json.Serialization.JsonPropertyName("enable_watermark")]
                        public bool EnableWatermark { get; set; }

                        /// <summary>
                        /// 获取或设置是否启用保密模式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("enable_confidential_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("enable_confidential_mode")]
                        public bool EnableConfidentialMode { get; set; }

                        /// <summary>
                        /// 获取或设置是否通过链接加入空间无需审批。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_url_no_approve")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_url_no_approve")]
                        public bool IsShareUrlNoApprove { get; set; }

                        /// <summary>
                        /// 获取或设置邀请链接默认权限类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_url_no_approve_default_auth")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_url_no_approve_default_auth")]
                        public int ShareUrlNoApproveDefaultAuthType { get; set; }

                        /// <summary>
                        /// 获取或设置文件默认可查看范围。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("default_file_scope")]
                        [System.Text.Json.Serialization.JsonPropertyName("default_file_scope")]
                        public int DefaultFileScope { get; set; }

                        /// <summary>
                        /// 获取或设置是否禁止文件分享到企业外。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ban_share_external")]
                        [System.Text.Json.Serialization.JsonPropertyName("ban_share_external")]
                        public bool IsBanShareExternal { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置访问控制信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_list")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_list")]
                public new Types.ACL ACL { get; set; } = default!;

                /// <summary>
                /// 获取或设置安全设置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("secure_setting")]
                [System.Text.Json.Serialization.JsonPropertyName("secure_setting")]
                public Types.SecureSettings SecureSettings { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置空间信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("space_info")]
        [System.Text.Json.Serialization.JsonPropertyName("space_info")]
        public Types.Space Space { get; set; } = default!;
    }
}
