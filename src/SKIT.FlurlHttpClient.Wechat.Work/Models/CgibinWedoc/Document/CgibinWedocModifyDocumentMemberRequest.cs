using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/mod_doc_member 接口的请求。</para>
    /// </summary>
    public class CgibinWedocModifyDocumentMemberRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Authority : CgibinWedocModifyDocumentJoinRuleRequest.Types.Authority
            {
            }
        }

        /// <summary>
        /// 获取或设置文档 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docid")]
        [System.Text.Json.Serialization.JsonPropertyName("docid")]
        public string DocumentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置新增的文档成员授权信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_file_member_list")]
        [System.Text.Json.Serialization.JsonPropertyName("update_file_member_list")]
        public IList<Types.Authority>? AddedMemberAuthorityList { get; set; }

        /// <summary>
        /// 获取或设置删除的文档成员授权信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("del_file_member_list")]
        [System.Text.Json.Serialization.JsonPropertyName("del_file_member_list")]
        public IList<Types.Authority>? DeletedMemberAuthorityList { get; set; }
    }
}
