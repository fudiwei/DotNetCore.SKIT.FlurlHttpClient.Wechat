using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/service/get_list 接口的响应。</para>
    /// </summary>
    public class ProductServiceGetListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Service
            {
                /// <summary>
                /// 获取或设置服务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_id")]
                [System.Text.Json.Serialization.JsonPropertyName("service_id")]
                public int ServiceId { get; set; }

                /// <summary>
                /// 获取或设置服务类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_type")]
                [System.Text.Json.Serialization.JsonPropertyName("service_type")]
                public int ServiceType { get; set; }

                /// <summary>
                /// 获取或设置服务名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_name")]
                [System.Text.Json.Serialization.JsonPropertyName("service_name")]
                public string ServiceName { get; set; } = default!;

                /// <summary>
                /// 获取或设置过期时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset ExpireTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_list")]
        [System.Text.Json.Serialization.JsonPropertyName("service_list")]
        public Types.Service[] ServiceList { get; set; } = default!;
    }
}
