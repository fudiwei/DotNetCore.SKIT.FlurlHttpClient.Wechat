namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/describeenvs 接口的响应。</para>
    /// </summary>
    public class ComponentTCBDescribeEnvironmentsResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Environment : TCBGetEnvironmentInfoResponse.Types.Environment
            {
                /// <summary>
                /// 获取或设置数据库实例 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dbinstance_id")]
                [System.Text.Json.Serialization.JsonPropertyName("dbinstance_id")]
                public string? DbInstanceId { get; set; }

                /// <summary>
                /// 获取或设置静态存储桶 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bucket_id")]
                [System.Text.Json.Serialization.JsonPropertyName("bucket_id")]
                public string? BucketId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置环境列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("info_list")]
        public List<Types.Environment>? EnvironmentList { get; set; }
    }
}
