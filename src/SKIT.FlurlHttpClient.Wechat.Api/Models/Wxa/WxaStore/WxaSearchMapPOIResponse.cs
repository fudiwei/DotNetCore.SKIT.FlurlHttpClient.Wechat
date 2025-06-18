namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/search_map_poi 接口的响应。</para>
    /// </summary>
    public class WxaSearchMapPOIResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class POI
                    {
                        /// <summary>
                        /// 获取或设置腾讯地图的位置点 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sosomap_poi_uid")]
                        [System.Text.Json.Serialization.JsonPropertyName("sosomap_poi_uid")]
                        public string MapPOIId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分店名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("branch_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("branch_name")]
                        public string BranchName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置门店分类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category")]
                        [System.Text.Json.Serialization.JsonPropertyName("category")]
                        public string Category { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置门店详细地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string Address { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置门店电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("telephone")]
                        [System.Text.Json.Serialization.JsonPropertyName("telephone")]
                        public string Telephone { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置门店位置经度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("longitude")]
                        [System.Text.Json.Serialization.JsonPropertyName("longitude")]
                        public decimal Longitude { get; set; }

                        /// <summary>
                        /// 获取或设置门店位置纬度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("latitude")]
                        [System.Text.Json.Serialization.JsonPropertyName("latitude")]
                        public decimal Latitude { get; set; }

                        /// <summary>
                        /// 获取或设置门店图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pic_urls")]
                        [System.Text.Json.Serialization.JsonPropertyName("pic_urls")]
                        public string[]? PictureUrlList { get; set; }

                        /// <summary>
                        /// 获取或设置卡券 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("card_id_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("card_id_list")]
                        public string[]? CardIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置门店列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item")]
                [System.Text.Json.Serialization.JsonPropertyName("item")]
                public Types.POI[] POIList { get; set; } = default!;
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
