namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/get_district 接口的响应。</para>
    /// </summary>
    public class WxaGetDistrictResponse : WechatApiResponse
    {
        public static class Types
        {
            public class District
            {
                public static class Types
                {
                    public class Location
                    {
                        /// <summary>
                        /// 获取或设置经度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lng")]
                        [System.Text.Json.Serialization.JsonPropertyName("lng")]
                        public double Longitude { get; set; }

                        /// <summary>
                        /// 获取或设置纬度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lat")]
                        [System.Text.Json.Serialization.JsonPropertyName("lat")]
                        public double Latitude { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置区域 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int DistrictId { get; set; }

                /// <summary>
                /// 获取或设置区域名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置区域全称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fullname")]
                [System.Text.Json.Serialization.JsonPropertyName("fullname")]
                public string FullName { get; set; } = default!;

                /// <summary>
                /// 获取或设置区域经纬度信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("location")]
                [System.Text.Json.Serialization.JsonPropertyName("location")]
                public Types.Location? Location { get; set; }

                /// <summary>
                /// 获取或设置区域拼音。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pinyin")]
                [System.Text.Json.Serialization.JsonPropertyName("pinyin")]
                public string[]? Pinyin { get; set; }

                /// <summary>
                /// 获取或设置下属城市区域 ID 列表
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cidx")]
                [System.Text.Json.Serialization.JsonPropertyName("cidx")]
                public int[]? CityIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置数据版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_version")]
        [System.Text.Json.Serialization.JsonPropertyName("data_version")]
        public string DataVersion { get; set; } = default!;

        /// <summary>
        /// 获取或设置区域列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.District[][] DistrictList { get; set; } = default!;
    }
}
