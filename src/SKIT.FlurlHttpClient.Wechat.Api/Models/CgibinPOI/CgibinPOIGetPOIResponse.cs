namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/poi/getpoi 接口的响应。</para>
    /// </summary>
    public class CgibinPOIGetPOIResponse : WechatApiResponse
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
                            public class Photo
                            {
                                /// <summary>
                                /// 获取或设置照片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("photo_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("photo_url")]
                                public string PhotoUrl { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置商户门店 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sid")]
                        [System.Text.Json.Serialization.JsonPropertyName("sid")]
                        public string? SID { get; set; }

                        /// <summary>
                        /// 获取或设置门店名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("business_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("business_name")]
                        public string BusinessName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分店名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("branch_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("branch_name")]
                        public string BranchName { get; set; } = default!;

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
                        /// 获取或设置分类列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("categories")]
                        [System.Text.Json.Serialization.JsonPropertyName("categories")]
                        public string[] CategoryList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置坐标类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("offset_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("offset_type")]
                        public int CoordinateType { get; set; }

                        /// <summary>
                        /// 获取或设置坐标经度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("longitude")]
                        [System.Text.Json.Serialization.JsonPropertyName("longitude")]
                        public double Longitude { get; set; }

                        /// <summary>
                        /// 获取或设置坐标纬度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("latitude")]
                        [System.Text.Json.Serialization.JsonPropertyName("latitude")]
                        public double Latitude { get; set; }

                        /// <summary>
                        /// 获取或设置门店照片列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("photo_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("photo_list")]
                        public Types.Photo[]? PhotoList { get; set; }

                        /// <summary>
                        /// 获取或设置推荐品。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("recommend")]
                        [System.Text.Json.Serialization.JsonPropertyName("recommend")]
                        public string? Recommend { get; set; }

                        /// <summary>
                        /// 获取或设置特色服务。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("special")]
                        [System.Text.Json.Serialization.JsonPropertyName("special")]
                        public string? Special { get; set; }

                        /// <summary>
                        /// 获取或设置商户简介。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("introduction")]
                        [System.Text.Json.Serialization.JsonPropertyName("introduction")]
                        public string? Introduction { get; set; }

                        /// <summary>
                        /// 获取或设置营业时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_time")]
                        public string? OpenTime { get; set; }

                        /// <summary>
                        /// 获取或设置人均价格（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("avg_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("avg_price")]
                        public double? AveragePrice { get; set; }

                        /// <summary>
                        /// 获取或设置门店可用状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("available_state")]
                        [System.Text.Json.Serialization.JsonPropertyName("available_state")]
                        public int AvailableStatus { get; set; }

                        /// <summary>
                        /// 获取或设置字段更新状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_status")]
                        public int UpdateStatus { get; set; }
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
