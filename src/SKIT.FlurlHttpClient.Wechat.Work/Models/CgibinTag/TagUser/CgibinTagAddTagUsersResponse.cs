namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/tag/addtagusers 接口的响应。</para>
    /// </summary>
    public class CgibinTagAddTagUsersResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置无效的成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalidlist")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.SeparatedByVBarStringArrayConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("invalidlist")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.SeparatedByVBarStringArrayConverter))]
        public string[]? InvalidUserIdList { get; set; }

        /// <summary>
        /// 获取或设置无效的部门 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalidparty")]
        [System.Text.Json.Serialization.JsonPropertyName("invalidparty")]
        public int[]? InvalidDepartmentIdList { get; set; }
    }
}
