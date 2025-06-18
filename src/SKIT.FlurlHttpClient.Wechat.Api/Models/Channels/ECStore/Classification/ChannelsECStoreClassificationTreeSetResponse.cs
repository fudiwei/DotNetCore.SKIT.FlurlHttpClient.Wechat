namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/store/classification/tree/set 接口的响应。</para>
    /// </summary>
    public class ChannelsECStoreClassificationTreeSetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class AuditResult
                    {
                        /// <summary>
                        /// 获取或设置分类 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("level_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("level_id")]
                        public long ClassificationId { get; set; }

                        /// <summary>
                        /// 获取或设置审核结果。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("result_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("result_code")]
                        public int ResultCode { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置版本号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("version")]
                [System.Text.Json.Serialization.JsonPropertyName("version")]
                public int Version { get; set; }

                /// <summary>
                /// 获取或设置审核结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_results")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_results")]
                public Types.AuditResult[] AuditResultList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置响应数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resp")]
        [System.Text.Json.Serialization.JsonPropertyName("resp")]
        public Types.Data Data { get; set; } = default!;
    }
}
