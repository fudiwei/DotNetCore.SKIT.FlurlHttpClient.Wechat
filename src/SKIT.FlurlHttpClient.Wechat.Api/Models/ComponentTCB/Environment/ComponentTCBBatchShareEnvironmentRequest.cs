namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/batchshareenv 接口的请求。</para>
    /// </summary>
    public class ComponentTCBBatchShareEnvironmentRequest : WechatApiRequest, IInferable<ComponentTCBBatchShareEnvironmentRequest, ComponentTCBBatchShareEnvironmentResponse>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置环境 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("env")]
                [System.Text.Json.Serialization.JsonPropertyName("env")]
                public string? EnvironmentId { get; set; }

                /// <summary>
                /// 获取或设置 AppId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appids")]
                [System.Text.Json.Serialization.JsonPropertyName("appids")]
                public List<string>? AppIdList { get; set; }
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
    }
}
