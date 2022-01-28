using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/agent/set_scope 接口的请求。</para>
    /// </summary>
    public class CgibinAgentSetScopeRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置通讯录迁移凭证。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置应用 ID。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.AgentId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }

        /// <summary>
        /// 获取或设置可见成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_user")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_user")]
        public IList<string>? AllowedUserIdList { get; set; }

        /// <summary>
        /// 获取或设置可见部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_party")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_party")]
        public IList<long>? AllowedDepartmentIdList { get; set; }

        /// <summary>
        /// 获取或设置可见标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_tag")]
        public IList<int>? AllowedTagIdList { get; set; }
    }
}
