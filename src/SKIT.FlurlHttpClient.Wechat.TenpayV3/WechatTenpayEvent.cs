using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    /// <summary>
    /// 表示微信支付 API 回调通知事件的基类。
    /// </summary>
    [Serializable]
    public class WechatTenpayEvent
    {
        public static class Types
        {
            public class Resource
            {
                /// <summary>
                /// 获取或设置加密算法类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("algorithm")]
                [System.Text.Json.Serialization.JsonPropertyName("algorithm")]
                public string Algorithm { get; set; } = default!;

                /// <summary>
                /// 获取或设置加密前的对象类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("original_type")]
                [System.Text.Json.Serialization.JsonPropertyName("original_type")]
                public string? OriginalType { get; set; }

                /// <summary>
                /// 获取或设置加密使用的附加数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("associated_data")]
                [System.Text.Json.Serialization.JsonPropertyName("associated_data")]
                public string? AssociatedData { get; set; }

                /// <summary>
                /// 获取或设置加密使用的随机串初始化向量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nonce")]
                [System.Text.Json.Serialization.JsonPropertyName("nonce")]
                public string Nonce { get; set; } = default!;

                /// <summary>
                /// 获取或设置 Base64 编码后的密文。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ciphertext")]
                [System.Text.Json.Serialization.JsonPropertyName("ciphertext")]
                public string CipherText { get; set; } = default!;
            }

            public interface IDecryptedResource
            {
            }
        }

        /// <summary>
        /// 获取或设置通知 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 获取或设置通知类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event_type")]
        [System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = default!;

        /// <summary>
        /// 获取或设置通知简要说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("summary")]
        [System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 获取或设置通知数据类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resource_type")]
        [System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        public string ResourceType { get; set; } = default!;

        /// <summary>
        /// 获取或设置通知数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resource")]
        [System.Text.Json.Serialization.JsonPropertyName("resource")]
        public Types.Resource Resource { get; set; } = default!;

        /// <summary>
        /// 获取或设置通知创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }
    }
}
