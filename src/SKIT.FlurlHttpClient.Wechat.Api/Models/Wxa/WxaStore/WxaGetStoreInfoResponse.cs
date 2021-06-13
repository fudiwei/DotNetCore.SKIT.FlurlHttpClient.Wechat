namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/get_store_info 接口的响应。</para>
    /// </summary>
    public class WxaGetStoreInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class POI
            {
                public static class Types
                {
                    public class Base
                    {
                        public static class Types
                        {
                            public class Picture
                            {
                                /// <summary>
                                /// 获取或设置图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("photo_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("photo_url")]
                                public string PictureUrl { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置门店 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                        public string POIId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置门店名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("business_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("business_name")]
                        public string BusinessName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置省份。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("province")]
                        [System.Text.Json.Serialization.JsonPropertyName("province")]
                        public string Province { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置城市。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city")]
                        [System.Text.Json.Serialization.JsonPropertyName("city")]
                        public string City { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置区县。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("district")]
                        [System.Text.Json.Serialization.JsonPropertyName("district")]
                        public string District { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置详细地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string Address { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置联系电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("telephone")]
                        [System.Text.Json.Serialization.JsonPropertyName("telephone")]
                        public string Telephone { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置经度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("longitude")]
                        [System.Text.Json.Serialization.JsonPropertyName("longitude")]
                        public double Longitude { get; set; }

                        /// <summary>
                        /// 获取或设置纬度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("latitude")]
                        [System.Text.Json.Serialization.JsonPropertyName("latitude")]
                        public double Latitude { get; set; }

                        /// <summary>
                        /// 获取或设置营业时间（格式：HHmm-HHmm）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_time")]
                        public string BusinessHours { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置门店图片列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("photo_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("photo_list")]
                        public Types.Picture[]? PictureList { get; set; }

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置门店基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.Base Base { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置门店信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business")]
        [System.Text.Json.Serialization.JsonPropertyName("business")]
        public Types.POI POI { get; set; } = default!;
    }
}
