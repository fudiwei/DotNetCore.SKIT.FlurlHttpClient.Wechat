namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/listpackages 接口的响应。</para>
    /// </summary>
    public class WxaSecVodListPackagesResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Package
            {
                /// <summary>
                /// 获取或设置流量包 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_id")]
                [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                public string? PackageId { get; set; }

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
                public string? OrderId { get; set; }

                /// <summary>
                /// 获取或设置有效期开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置有效期结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置流量包状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置已消耗流量（单位：兆字节）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("used")]
                [System.Text.Json.Serialization.JsonPropertyName("used")]
                public long UsedValue { get; set; }

                /// <summary>
                /// 获取或设置总流量（单位：兆字节）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("all")]
                [System.Text.Json.Serialization.JsonPropertyName("all")]
                public long TotalValue { get; set; }

                /// <summary>
                /// 获取或设置是否已删除。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_deleted")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_deleted")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
                public bool IsDeleted { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置流量包列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_list")]
        [System.Text.Json.Serialization.JsonPropertyName("package_list")]
        public List<Types.Package>? PackageList { get; set; }

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
