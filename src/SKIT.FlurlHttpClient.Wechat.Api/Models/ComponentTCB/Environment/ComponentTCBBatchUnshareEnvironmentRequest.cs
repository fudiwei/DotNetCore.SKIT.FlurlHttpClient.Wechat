namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/batchunshareenv 接口的请求。</para>
    /// </summary>
    public class ComponentTCBBatchUnshareEnvironmentRequest : WechatApiRequest, IInferable<ComponentTCBBatchUnshareEnvironmentRequest, ComponentTCBBatchUnshareEnvironmentResponse>
    {
        public static class Types
        {
            public class Data : ComponentTCBBatchShareEnvironmentRequest.Types.Data
            {
            }
        }

        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAccessToken { get; set; }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public List<Types.Data>? DataList { get; set; }

        /// <summary>
        /// 获取或设置请求环境源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_type")]
        [System.Text.Json.Serialization.JsonPropertyName("source_type")]
        public int? SourceType { get; set; }
    }
}
