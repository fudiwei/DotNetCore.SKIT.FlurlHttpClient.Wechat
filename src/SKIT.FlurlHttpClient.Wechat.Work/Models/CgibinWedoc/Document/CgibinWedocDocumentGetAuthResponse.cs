namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/doc_get_auth 接口的响应。</para>
    /// </summary>
    public class CgibinWedocDocumentGetAuthResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class AccessRule
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

                /// <summary>
                /// 获取或设置是否禁止分享到企业外部。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ban_share_external")]
                [System.Text.Json.Serialization.JsonPropertyName("ban_share_external")]
                public bool IsBanShareExternal { get; set; }
            }

            public class SecureSettings
            {
                public static class Types
                {
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
                    }
                }

                /// <summary>
                /// 获取或设置是否开启只读备份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_readonly_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_readonly_copy")]
                public bool EnableReadonlyCopy { get; set; }

                /// <summary>
                /// 获取或设置是否开启只读评论。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable_readonly_comment")]
                [System.Text.Json.Serialization.JsonPropertyName("enable_readonly_comment")]
                public bool EnableReadonlyComment { get; set; }

                /// <summary>
                /// 获取或设置水印信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("watermark")]
                [System.Text.Json.Serialization.JsonPropertyName("watermark")]
                public Types.Watermark? Watermark { get; set; }
            }

            public class Authority
            {
                /// <summary>
                /// 获取或设置类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置成员账号。
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
                /// 获取或设置部门 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("departmentid")]
                [System.Text.Json.Serialization.JsonPropertyName("departmentid")]
                public long? DepartmentId { get; set; }

                /// <summary>
                /// 获取或设置权限类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth")]
                [System.Text.Json.Serialization.JsonPropertyName("auth")]
                public int AuthType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置文档访问规则。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("access_rule")]
        public Types.AccessRule AccessRule { get; set; } = default!;

        /// <summary>
        /// 获取或设置安全配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("secure_setting")]
        [System.Text.Json.Serialization.JsonPropertyName("secure_setting")]
        public Types.SecureSettings SecureSettings { get; set; } = default!;

        /// <summary>
        /// 获取或设置文档成员授权信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("doc_member_list")]
        [System.Text.Json.Serialization.JsonPropertyName("doc_member_list")]
        public Types.Authority[]? DocumentMemberAuthorityList { get; set; }

        /// <summary>
        /// 获取或设置文档查看者授权信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("co_auth_list")]
        [System.Text.Json.Serialization.JsonPropertyName("co_auth_list")]
        public Types.Authority[]? DocumentCollaboratorAuthorityList { get; set; }
    }
}
