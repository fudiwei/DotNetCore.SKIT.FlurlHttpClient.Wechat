using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/mod_doc_join_rule 接口的请求。</para>
    /// </summary>
    public class CgibinWedocModifyDocumentJoinRuleRequest : WechatWorkRequest
    {
        public static class Types
        {
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
        /// 获取或设置文档 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docid")]
        [System.Text.Json.Serialization.JsonPropertyName("docid")]
        public string DocumentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否为企业内可访问。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_corp_internal")]
        [System.Text.Json.Serialization.JsonPropertyName("enable_corp_internal")]
        public bool? EnableCorpInternal { get; set; }

        /// <summary>
        /// 获取或设置企业内权限类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corp_internal_auth")]
        [System.Text.Json.Serialization.JsonPropertyName("corp_internal_auth")]
        public int? CorpInternalAuthType { get; set; }

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
        public bool? EnableCorpExternal { get; set; }

        /// <summary>
        /// 获取或设置企业外权限类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("corp_external_auth")]
        [System.Text.Json.Serialization.JsonPropertyName("corp_external_auth")]
        public int? CorpExternalAuthType { get; set; }

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
        public bool? IsBanShareExternal { get; set; }

        /// <summary>
        /// 获取或设置是否更新文档查看者授权信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_co_auth_list")]
        [System.Text.Json.Serialization.JsonPropertyName("update_co_auth_list")]
        public bool? RequireUpdateCollaboratorAuthorityList { get; set; }

        /// <summary>
        /// 获取或设置新的文档查看者授权信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("co_auth_list")]
        [System.Text.Json.Serialization.JsonPropertyName("co_auth_list")]
        public IList<Types.Authority>? DocumentCollaboratorAuthorityList { get; set; }
    }
}
