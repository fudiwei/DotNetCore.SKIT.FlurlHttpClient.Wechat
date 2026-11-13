namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/wxopen/chattoolmsg/send 接口的请求。</para>
    /// </summary>
    public class CgibinMessageWxopenChatToolMessageSendRequest : WechatApiRequest, IInferable<CgibinMessageWxopenChatToolMessageSendRequest, CgibinMessageWxopenChatToolMessageSendResponse>
    {
        public static class Types
        {
            public class ParticipatorInfo
            {
                /// <summary>
                /// 获取或设置聊天室用户的 GroupOpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("group_openid")]
                public string? GroupOpenId { get; set; }

                /// <summary>
                /// 获取或设置用户对卡片事件的完成状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public int State { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置动态消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public string? ActivityId { get; set; }

        /// <summary>
        /// 获取或设置修改后的状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target_state")]
        [System.Text.Json.Serialization.JsonPropertyName("target_state")]
        public int TargetState { get; set; }

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// 获取或设置聊天室成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("participator_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("participator_info_list")]
        public List<Types.ParticipatorInfo>? ParticipatorInfoList { get; set; }

        /// <summary>
        /// 获取或设置版本类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version_type")]
        [System.Text.Json.Serialization.JsonPropertyName("version_type")]
        public int VersionType { get; set; }
    }
}
