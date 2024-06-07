namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/shop/open/get_commission 接口的响应。</para>
    /// </summary>
    public class UnionShopOpenGetCommissionResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("productId")]
                [System.Text.Json.Serialization.JsonPropertyName("productId")]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置商家自定义商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("outProductId")]
                [System.Text.Json.Serialization.JsonPropertyName("outProductId")]
                public string OutProductId { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否是佣金商品。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("isCommissionProduct")]
                [System.Text.Json.Serialization.JsonPropertyName("isCommissionProduct")]
                public bool IsCommissionProduct { get; set; }

                /// <summary>
                /// 获取或设置佣金率（单位：万分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commissionRatio")]
                [System.Text.Json.Serialization.JsonPropertyName("commissionRatio")]
                public int? CommissionRatio { get; set; }

                /// <summary>
                /// 获取或设置待生效佣金率（单位：万分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nextCommissionRatio")]
                [System.Text.Json.Serialization.JsonPropertyName("nextCommissionRatio")]
                public int? NextCommissionRatio { get; set; }

                /// <summary>
                /// 获取或设置生效时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("effectiveTime")]
                [System.Text.Json.Serialization.JsonPropertyName("effectiveTime")]
                public long? EffectiveTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
