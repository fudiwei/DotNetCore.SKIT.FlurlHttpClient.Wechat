namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/databasequery 接口的响应。</para>
    /// </summary>
    public class TCBDatabaseQueryResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Pagination : TCBDatabaseCollectionGetResponse.Types.Pagination
            {
            }
        }

        /// <summary>
        /// 获取或设置查询数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public string[] Data { get; set; } = default!;

        /// <summary>
        /// 获取或设置查询分页信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pager")]
        [System.Text.Json.Serialization.JsonPropertyName("pager")]
        public Types.Pagination Pagination { get; set; } = default!;
    }
}
