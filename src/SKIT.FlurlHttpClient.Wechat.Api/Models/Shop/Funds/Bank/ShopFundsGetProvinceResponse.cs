namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/funds/getprovince 接口的响应。</para>
    /// </summary>
    public class ShopFundsGetProvinceResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Province
            {
                /// <summary>
                /// 获取或设置省份编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province_code")]
                [System.Text.Json.Serialization.JsonPropertyName("province_code")]
                public int ProvinceCode { get; set; }

                /// <summary>
                /// 获取或设置省份名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province_name")]
                [System.Text.Json.Serialization.JsonPropertyName("province_name")]
                public string ProvinceName { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置省份列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Province[] ProvinceList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
