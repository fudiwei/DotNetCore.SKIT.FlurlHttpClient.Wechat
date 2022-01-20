namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/databasedelete 接口的响应。</para>
    /// </summary>
    public class TcbDatabaseDeleteResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置删除数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deleted")]
        [System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public int DeletedCount { get; set; }
    }
}
