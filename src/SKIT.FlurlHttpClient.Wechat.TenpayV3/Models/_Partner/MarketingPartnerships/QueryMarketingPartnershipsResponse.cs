using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/partnerships 接口的响应。</para>
    /// </summary>
    public class QueryMarketingPartnershipsResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Partnership
            {
                public static class Types
                {
                    public class Partner
                    {
                        /// <summary>
                        /// 获取或设置合作方类别。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置合作方 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string? AppId { get; set; }

                        /// <summary>
                        /// 获取或设置合作方商户号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_id")]
                        public string? MerchantId { get; set; }
                    }

                    public class AuthorizedData
                    {
                        /// <summary>
                        /// 获取或设置授权业务类别。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("business_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("business_type")]
                        public string BusinessType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置授权场景列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scenarios")]
                        [System.Text.Json.Serialization.JsonPropertyName("scenarios")]
                        public string[]? Scenarios { get; set; }

                        /// <summary>
                        /// 获取或设置授权批次 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stock_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
                        public string? StockId { get; set; }
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
                /// 获取或设置终止合作关系时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("terminate_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("terminate_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset? TerminateTime { get; set; }

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

        /// <summary>
        /// 获取或设置服务人员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Partnership[] PartnershipList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置合作关系总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }
    }
}
