namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/update_taskcard 接口的响应。</para>
    /// </summary>
    public class CgibinMessageUpdateTaskCardResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置无效的成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invaliduser")]
        [System.Text.Json.Serialization.JsonPropertyName("invaliduser")]
        public string[]? InvalidUserIdList { get; set; }
    }
}
