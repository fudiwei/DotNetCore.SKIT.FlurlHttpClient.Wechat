namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/service/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillServiceGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Service
            {
                public static class Types
                {
                    public class Attachment
                    {
                        /// <summary>
                        /// 获取或设置附件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置附件 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string? Url { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置服务类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_type")]
                [System.Text.Json.Serialization.JsonPropertyName("service_type")]
                public string? ServiceType { get; set; }

                /// <summary>
                /// 获取或设置服务类型名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_name")]
                [System.Text.Json.Serialization.JsonPropertyName("service_name")]
                public string? ServiceName { get; set; }

                /// <summary>
                /// 获取或设置服务参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_value")]
                [System.Text.Json.Serialization.JsonPropertyName("service_value")]
                public string? ServiceValue { get; set; }

                /// <summary>
                /// 获取或设置服务状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_status")]
                [System.Text.Json.Serialization.JsonPropertyName("service_status")]
                public int ServiceStatus { get; set; }

                /// <summary>
                /// 获取或设置附件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attach_list")]
                [System.Text.Json.Serialization.JsonPropertyName("attach_list")]
                public List<Types.Attachment>? AttachmentList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_list")]
        [System.Text.Json.Serialization.JsonPropertyName("service_list")]
        public List<Types.Service>? ServiceList { get; set; }
    }
}
