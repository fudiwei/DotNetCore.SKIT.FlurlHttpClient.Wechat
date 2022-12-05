using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/update_template_card 接口的请求。</para>
    /// </summary>
    public class CgibinMessageUpdateTemplateCardRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Button
            {
                /// <summary>
                /// 获取或设置任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                public string TaskId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置替换文案。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("replace_name")]
                [System.Text.Json.Serialization.JsonPropertyName("replace_name")]
                public string ReplacementText { get; set; } = string.Empty;
            }

            public class TemplateCardMessage : CgibinMessageSendRequest.Types.TemplateCardMessage
            {
                /// <summary>
                /// 获取或设置按钮替换文案。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("replace_text")]
                [System.Text.Json.Serialization.JsonPropertyName("replace_text")]
                public string? ReplacementText { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置应用 ID。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.AgentId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }

        /// <summary>
        /// 获取或设置成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userids")]
        [System.Text.Json.Serialization.JsonPropertyName("userids")]
        public IList<string>? UserIdList { get; set; }

        /// <summary>
        /// 获取或设置部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partyids")]
        [System.Text.Json.Serialization.JsonPropertyName("partyids")]
        public IList<long>? DepartmentIdList { get; set; }

        /// <summary>
        /// 获取或设置标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tagids")]
        [System.Text.Json.Serialization.JsonPropertyName("tagids")]
        public IList<int>? TagIdList { get; set; }

        /// <summary>
        /// 获取或设置是否更新整个任务接收人员。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atall")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("atall")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsAtAll { get; set; }

        /// <summary>
        /// 获取或设置更新卡片所需要消费的 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("response_code")]
        [System.Text.Json.Serialization.JsonPropertyName("response_code")]
        public string ResponseCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置原始卡片的任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("original_task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("original_task_id")]
        public string? OriginalTaskId { get; set; }

        /// <summary>
        /// 获取或设置按钮信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("button")]
        [System.Text.Json.Serialization.JsonPropertyName("button")]
        public Types.Button? Button { get; set; }

        /// <summary>
        /// 获取或设置模板卡片信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_card")]
        [System.Text.Json.Serialization.JsonPropertyName("template_card")]
        public Types.TemplateCardMessage? TemplateCard { get; set; }
    }
}
