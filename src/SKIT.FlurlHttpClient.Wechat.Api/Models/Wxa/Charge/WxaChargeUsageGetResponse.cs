namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/charge/usage/get 接口的响应。</para>
    /// </summary>
    public class WxaChargeUsageGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Detail
            {
                /// <summary>
                /// 获取或设置资源包 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pkgId")]
                [System.Text.Json.Serialization.JsonPropertyName("pkgId")]
                public string PackageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置额度来源的商品 SPU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spuId")]
                [System.Text.Json.Serialization.JsonPropertyName("spuId")]
                public string SPUId { get; set; } = default!;

                /// <summary>
                /// 获取或设置额度来源的商品 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skuId")]
                [System.Text.Json.Serialization.JsonPropertyName("skuId")]
                public string? SKUId { get; set; }

                /// <summary>
                /// 获取或设置资源包状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置额度有效期开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("startTime")]
                [System.Text.Json.Serialization.JsonPropertyName("startTime")]
                public long StartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置额度有效期结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("endTime")]
                [System.Text.Json.Serialization.JsonPropertyName("endTime")]
                public long EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置额度容量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("all")]
                [System.Text.Json.Serialization.JsonPropertyName("all")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long AllQuota { get; set; }

                /// <summary>
                /// 获取或设置使用额度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("used")]
                [System.Text.Json.Serialization.JsonPropertyName("used")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long UsedQuota { get; set; }

                /// <summary>
                /// 获取或设置额度来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public int? Source { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置资源可用总量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("all")]
        [System.Text.Json.Serialization.JsonPropertyName("all")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long AllQuota { get; set; }

        /// <summary>
        /// 获取或设置资源总量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effectiveAll")]
        [System.Text.Json.Serialization.JsonPropertyName("effectiveAll")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long EffectiveAllQuota { get; set; }

        /// <summary>
        /// 获取或设置累计用量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effectiveUse")]
        [System.Text.Json.Serialization.JsonPropertyName("effectiveUse")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long EffectiveUsedQuota { get; set; }

        /// <summary>
        /// 获取或设置订阅开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startServiceTime")]
        [System.Text.Json.Serialization.JsonPropertyName("startServiceTime")]
        public long StartServiceTime { get; set; }

        /// <summary>
        /// 获取或设置订阅结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endServiceTime")]
        [System.Text.Json.Serialization.JsonPropertyName("endServiceTime")]
        public long EndServiceTime { get; set; }

        /// <summary>
        /// 获取或设置用量详情列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detailList")]
        [System.Text.Json.Serialization.JsonPropertyName("detailList")]
        public Types.Detail[] DetailList { get; set; } = default!;

        /// <summary>
        /// 获取或设置用量详情总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }
    }
}
