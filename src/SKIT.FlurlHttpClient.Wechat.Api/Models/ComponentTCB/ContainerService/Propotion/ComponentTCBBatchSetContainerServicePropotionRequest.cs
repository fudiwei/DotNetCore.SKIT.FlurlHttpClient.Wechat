namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/batchsetcspropotion 接口的请求。</para>
    /// </summary>
    public class ComponentTCBBatchSetContainerServicePropotionRequest : WechatApiRequest, IInferable<ComponentTCBBatchSetContainerServicePropotionRequest, ComponentTCBBatchSetContainerServicePropotionResponse>
    {
        public static class Types
        {
            public class ContainerService
            {
                public static class Types
                {
                    public class Version : ComponentTCBSetContainerServicePropotionRequest.Types.Version
                    {
                    }
                }

                /// <summary>
                /// 获取或设置环境 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("env")]
                [System.Text.Json.Serialization.JsonPropertyName("env")]
                public string? EnvironmentId { get; set; }

                /// <summary>
                /// 获取或设置服务名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_name")]
                [System.Text.Json.Serialization.JsonPropertyName("service_name")]
                public string? ServiceName { get; set; }

                /// <summary>
                /// 获取或设置版本列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("items")]
                [System.Text.Json.Serialization.JsonPropertyName("items")]
                public List<Types.Version>? VersionList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAccessToken { get; set; }

        /// <summary>
        /// 获取或设置云托管服务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public List<Types.ContainerService>? ContainerServiceList { get; set; }
    }
}
