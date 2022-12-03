using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/create_doc 接口的请求。</para>
    /// </summary>
    public class CgibinWedocCreateDocumentRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置空间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spaceid")]
        [System.Text.Json.Serialization.JsonPropertyName("spaceid")]
        public string? SpaceId { get; set; }

        /// <summary>
        /// 获取或设置上级文件 ID 或空间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fatherid")]
        [System.Text.Json.Serialization.JsonPropertyName("fatherid")]
        public string? ParentFileOrSpaceId { get; set; }

        /// <summary>
        /// 获取或设置文档类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("doc_type")]
        [System.Text.Json.Serialization.JsonPropertyName("doc_type")]
        public int DocumentType { get; set; }

        /// <summary>
        /// 获取或设置文档名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("doc_name")]
        [System.Text.Json.Serialization.JsonPropertyName("doc_name")]
        public string DocumentName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置管理员成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admin_users")]
        [System.Text.Json.Serialization.JsonPropertyName("admin_users")]
        public IList<string>? AdminUserIdList { get; set; }
    }
}
