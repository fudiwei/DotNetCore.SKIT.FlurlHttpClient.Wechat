namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/shop/sale/profile/data/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECCompassShopSaleProfileDataGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Field
                    {
                        public static class Types
                        {
                            public class Dimension
                            {
                                /// <summary>
                                /// 获取或设置维度指标名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("dim_key")]
                                [System.Text.Json.Serialization.JsonPropertyName("dim_key")]
                                public string Key { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置维度指标值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("dim_value")]
                                [System.Text.Json.Serialization.JsonPropertyName("dim_value")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public decimal Value { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置维度类别名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("field_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("field_name")]
                        public string FieldName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置维度指标列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("data_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("data_list")]
                        public Types.Dimension[] DimensionList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置维度类别列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("field_list")]
                public Types.Field[] FieldList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
