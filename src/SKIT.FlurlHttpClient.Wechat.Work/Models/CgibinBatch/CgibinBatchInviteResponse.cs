namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/batch/invite 接口的响应。</para>
    /// </summary>
    public class CgibinBatchInviteResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置无效的成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invaliduser")]
        [System.Text.Json.Serialization.JsonPropertyName("invaliduser")]
        public string[]? InvalidUserIdList { get; set; }

        /// <summary>
        /// 获取或设置无效的部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalidparty")]
        [System.Text.Json.Serialization.JsonPropertyName("invalidparty")]
        public int[]? InvalidDepartmentIdList { get; set; }

        /// <summary>
        /// 获取或设置无效的标签 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalidtag")]
        [System.Text.Json.Serialization.JsonPropertyName("invalidtag")]
        public int[]? InvalidTagIdList { get; set; }
    }
}
