using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/update_taskcard 接口的请求。</para>
    /// </summary>
    public class CgibinMessageUpdateTaskCardRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userids")]
        [System.Text.Json.Serialization.JsonPropertyName("userids")]
        public IList<string>? UserIdList { get; set; }

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string TaskId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置应用 ID。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.AgentId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }

        /// <summary>
        /// 获取或设置替换文案。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("replace_name")]
        [System.Text.Json.Serialization.JsonPropertyName("replace_name")]
        public string ReplacementText { get; set; } = string.Empty;
    }
}
