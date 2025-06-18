namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /capital/capitallhh/areas/provinces 接口的响应。</para>
    /// </summary>
    public class QueryCapitalAreasProvincesResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Province
            {
                /// <summary>
                /// 获取或设置省份名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province_name")]
                [System.Text.Json.Serialization.JsonPropertyName("province_name")]
                public string ProvinceName { get; set; } = default!;

                /// <summary>
                /// 获取或设置省份编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province_code")]
                [System.Text.Json.Serialization.JsonPropertyName("province_code")]
                public int ProvinceCode { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置省份列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Province[] ProvinceList { get; set; } = default!;

        /// <summary>
        /// 获取或设置数据总条数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
