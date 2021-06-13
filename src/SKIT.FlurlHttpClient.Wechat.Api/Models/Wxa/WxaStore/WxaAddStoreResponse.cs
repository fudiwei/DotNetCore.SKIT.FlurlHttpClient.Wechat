namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/add_store 接口的响应。</para>
    /// </summary>
    public class WxaAddStoreResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置审核单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_id")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
                public int AuditId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
