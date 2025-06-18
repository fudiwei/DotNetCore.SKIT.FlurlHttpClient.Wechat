using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/partnerships/build 接口的响应。</para>
    /// </summary>
    public class BuildMarketingPartnershipResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Partner : QueryMarketingPartnershipsResponse.Types.Partnership.Types.Partner
            {
            }

            public class AuthorizedData : QueryMarketingPartnershipsResponse.Types.Partnership.Types.AuthorizedData
            {
            }
        }

        /// <summary>
        /// 获取或设置合作方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner")]
        [System.Text.Json.Serialization.JsonPropertyName("partner")]
        public Types.Partner Partner { get; set; } = default!;

        /// <summary>
        /// 获取或设置被授权数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorized_data")]
        [System.Text.Json.Serialization.JsonPropertyName("authorized_data")]
        public Types.AuthorizedData AuthorizedData { get; set; } = default!;

        /// <summary>
        /// 获取或设置合作状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置建立合作关系时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("build_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("build_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset BuildTime { get; set; }

        /// <summary>
        /// 获取或设置创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset UpdateTime { get; set; }
    }
}
