using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/dbindex 接口的请求。</para>
    /// </summary>
    public class ComponentTcbDbIndexRequest : WechatApiRequest, IMapResponse<ComponentTcbDbIndexRequest, ComponentTcbDbIndexResponse>
    {
        public static class Types
        {
            public class Index
            {
                public static class Types
                {
                    public class Field
                    {
                        /// <summary>
                        /// 获取或设置字段名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置字段排序。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("direction")]
                        [System.Text.Json.Serialization.JsonPropertyName("direction")]
                        public string? Direction { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置索引名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string IndexName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("keys")]
                [System.Text.Json.Serialization.JsonPropertyName("keys")]
                public IList<Types.Field>? FieldList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置集合名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collection_name")]
        [System.Text.Json.Serialization.JsonPropertyName("collection_name")]
        public string CollectionName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置索引列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("indexes")]
        [System.Text.Json.Serialization.JsonPropertyName("indexes")]
        public IList<Types.Index>? IndexList { get; set; }
    }
}
