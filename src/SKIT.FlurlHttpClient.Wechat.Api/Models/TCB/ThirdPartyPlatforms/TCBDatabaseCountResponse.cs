namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/databasecount 接口的响应。</para>
    /// </summary>
    public class TCBDatabaseCountResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置记录数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int RecordCount { get; set; }
    }
}
