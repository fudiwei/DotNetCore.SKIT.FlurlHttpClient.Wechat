namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/finder/sale/profile/data/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECCompassFinderSaleProfileDataGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Field : ChannelsECCompassShopSaleProfileDataGetResponse.Types.Data.Types.__zz__Field
                    {
                        public static class Types
                        {
                            public class Dimension : ChannelsECCompassShopSaleProfileDataGetResponse.Types.Data.Types.Field.Types.Dimension
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置维度指标列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("data_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("data_list")]
                        public List<Types.Dimension>? DimensionList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置维度类别列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("field_list")]
                public List<Types.Field>? FieldList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data? Data { get; set; }
    }
}
