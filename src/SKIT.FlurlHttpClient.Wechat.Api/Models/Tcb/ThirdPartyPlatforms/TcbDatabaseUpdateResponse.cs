namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/databaseupdate 接口的响应。</para>
    /// </summary>
    public class TcbDatabaseUpdateResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置修改记录数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modified")]
        [System.Text.Json.Serialization.JsonPropertyName("modified")]
        public int ModifiedCount { get; set; }

        /// <summary>
        /// 获取或设置匹配记录数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("matched")]
        [System.Text.Json.Serialization.JsonPropertyName("matched")]
        public int MatchedCount { get; set; }

        /// <summary>
        /// 获取或设置新插入记录的 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }
    }
}
