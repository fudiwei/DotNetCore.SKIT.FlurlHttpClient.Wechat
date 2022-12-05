namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/get_file_permission 接口的响应。</para>
    /// </summary>
    public class CgibinWedriveGetFilePermissionResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class ShareRange
            {
                /// <summary>
                /// 获取或设置是否为企业内可访问。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_corp_internal")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_corp_internal")]
                public bool EnableCorpInternal { get; set; }

                /// <summary>
                /// 获取或设置企业内权限类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_internal_auth")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_internal_auth")]
                public int CorpInternalAuthType { get; set; }

                /// <summary>
                /// 获取或设置是否开启企业内管理员审批。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_internal_approve_only_by_admin")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_internal_approve_only_by_admin")]
                public bool? IsCorpInternalApproveOnlyByAdmin { get; set; }

                /// <summary>
                /// 获取或设置是否为企业外可访问。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_corp_external")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_corp_external")]
                public bool EnableCorpExternal { get; set; }

                /// <summary>
                /// 获取或设置企业外权限类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_external_auth")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_external_auth")]
                public int CorpExternalAuthType { get; set; }

                /// <summary>
                /// 获取或设置是否开启企业外管理员审批。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corp_external_approve_only_by_admin")]
                [System.Text.Json.Serialization.JsonPropertyName("corp_external_approve_only_by_admin")]
                public bool? IsCorpExternalApproveOnlyByAdmin { get; set; }
            }

            public class SecureSettings
            {
                /// <summary>
                /// 获取或设置是否开启只读备份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_readonly_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_readonly_copy")]
                public bool EnableReadonlyCopy { get; set; }

                /// <summary>
                /// 获取或设置是否只允许管理员进行修改。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("modify_only_by_admin")]
                [System.Text.Json.Serialization.JsonPropertyName("modify_only_by_admin")]
                public bool IsModifyOnlyByAdmin { get; set; }

                /// <summary>
                /// 获取或设置是否开启只读评论。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_readonly_comment")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_readonly_comment")]
                public bool EnableReadonlyComment { get; set; }

                /// <summary>
                /// 获取或设置是否禁止分享到企业外部。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ban_share_external")]
                [System.Text.Json.Serialization.JsonPropertyName("ban_share_external")]
                public bool IsBanShareExternal { get; set; }
            }

            public class ACL
            {
                /// <summary>
                /// 获取或设置文件授权信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_list")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_list")]
                public Types.Authority[] AuthorityList { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否开启父路径权限继承。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inherit")]
                [System.Text.Json.Serialization.JsonPropertyName("inherit")]
                public bool IsInherit { get; set; }
            }

            public class Authority : CgibinWedriveSpaceInfoResponse.Types.Space.Types.Authority
            {
            }

            public class Watermark
            {
                /// <summary>
                /// 获取或设置水印文字。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public string Text { get; set; } = default!;

                /// <summary>
                /// 获取或设置水印类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("margin_type")]
                [System.Text.Json.Serialization.JsonPropertyName("margin_type")]
                public int MarginType { get; set; }

                /// <summary>
                /// 获取或设置是否开启水印文本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("show_text")]
                [System.Text.Json.Serialization.JsonPropertyName("show_text")]
                public bool EnableShowText { get; set; }

                /// <summary>
                /// 获取或设置是否开启水印访问人名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("show_visitor_name")]
                [System.Text.Json.Serialization.JsonPropertyName("show_visitor_name")]
                public bool EnableShowVisitorName { get; set; }

                /// <summary>
                /// 获取或设置管理员是否强制要求使用水印。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("force_by_admin")]
                [System.Text.Json.Serialization.JsonPropertyName("force_by_admin")]
                public bool IsForceByAdmin { get; set; }

                /// <summary>
                /// 获取或设置空间管理员是否强制要求使用水印。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("force_by_space_admin")]
                [System.Text.Json.Serialization.JsonPropertyName("force_by_space_admin")]
                public bool IsForceBySpaceAdmin { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置文件分享设置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("share_range")]
        [System.Text.Json.Serialization.JsonPropertyName("share_range")]
        public Types.ShareRange ShareRange { get; set; } = default!;

        /// <summary>
        /// 获取或设置安全配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("secure_setting")]
        [System.Text.Json.Serialization.JsonPropertyName("secure_setting")]
        public Types.SecureSettings SecureSettings { get; set; } = default!;

        /// <summary>
        /// 获取或设置从文件父路径继承的权限信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inherit_father_auth")]
        [System.Text.Json.Serialization.JsonPropertyName("inherit_father_auth")]
        public Types.ACL FatherACL { get; set; } = default!;

        /// <summary>
        /// 获取或设置文件成员授权信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_member_list")]
        [System.Text.Json.Serialization.JsonPropertyName("file_member_list")]
        public Types.Authority[]? FileMemberAuthorityList { get; set; }

        /// <summary>
        /// 获取或设置文件查看者授权信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("co_auth_list")]
        [System.Text.Json.Serialization.JsonPropertyName("co_auth_list")]
        public Types.Authority[]? FileCollaboratorAuthorityList { get; set; }

        /// <summary>
        /// 获取或设置水印信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("watermark")]
        [System.Text.Json.Serialization.JsonPropertyName("watermark")]
        public Types.Watermark? Watermark { get; set; }
    }
}
