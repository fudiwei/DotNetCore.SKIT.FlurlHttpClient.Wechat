namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/wxopen/employeerelationmsg/send 接口的请求。</para>
    /// </summary>
    public class CgibinMessageWxopenEmployeeRelationMessageSendRequest : WechatApiRequest, IInferable<CgibinMessageWxopenEmployeeRelationMessageSendRequest, CgibinMessageWxopenEmployeeRelationMessageSendResponse>
    {
        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置接收消息的用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("touser")]
        [System.Text.Json.Serialization.JsonPropertyName("touser")]
        public string ToUserOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public string PagePath { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置推送数据 JSON 字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? DataJson { get; set; }
    }
}
