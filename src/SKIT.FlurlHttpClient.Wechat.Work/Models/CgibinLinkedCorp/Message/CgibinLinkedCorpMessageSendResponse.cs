namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/linkedcorp/message/send 接口的响应。</para>
    /// </summary>
    public class CgibinLinkedCorpMessageSendResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置无效的互联企业成员账号（格式："CorpId/UserId"）列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invaliduser")]
        [System.Text.Json.Serialization.JsonPropertyName("invaliduser")]
        public string[]? InvalidCorpUserIdList { get; set; }

        /// <summary>
        /// 获取或设置无效的互联企业部门 ID（格式："LinkedId/DepartmentId"）列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalidparty")]
        [System.Text.Json.Serialization.JsonPropertyName("invalidparty")]
        public string[]? InvalidLinkedDepartmentIdList { get; set; }

        /// <summary>
        /// 获取或设置无效的标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalidtag")]
        [System.Text.Json.Serialization.JsonPropertyName("invalidtag")]
        public int[]? InvalidTagIdList { get; set; }
    }
}
