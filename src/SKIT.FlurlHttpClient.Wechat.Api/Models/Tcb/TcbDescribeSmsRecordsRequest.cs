namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/describesmsrecords 接口的请求。</para>
    /// </summary>
    public class TcbDescribeSmsRecordsRequest : WechatApiRequest, IMapResponse<TcbDescribeSmsRecordsRequest, TcbDescribeSmsRecordsResponse>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置环境 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("EnvId")]
                [System.Text.Json.Serialization.JsonPropertyName("EnvId")]
                public string EnvironmentId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置开始日期（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("StartDate")]
                [System.Text.Json.Serialization.JsonPropertyName("StartDate")]
                public string StartDateString { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置结束日期（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("EndDate")]
                [System.Text.Json.Serialization.JsonPropertyName("EndDate")]
                public string EndDateString { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("Mobile")]
                public string? MobileNumber { get; set; }

                /// <summary>
                /// 获取或设置查询 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("QueryId")]
                [System.Text.Json.Serialization.JsonPropertyName("QueryId")]
                public string? QueryId { get; set; }

                /// <summary>
                /// 获取或设置分页页码（从 1 开始）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("PageNumber")]
                [System.Text.Json.Serialization.JsonPropertyName("PageNumber")]
                public int? Page { get; set; }

                /// <summary>
                /// 获取或设置分页每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("PageSize")]
                [System.Text.Json.Serialization.JsonPropertyName("PageSize")]
                public int? Limit { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置上传数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PostData")]
        [System.Text.Json.Serialization.JsonPropertyName("PostData")]
        public Types.Data Data { get; set; } = new Types.Data();
    }
}
