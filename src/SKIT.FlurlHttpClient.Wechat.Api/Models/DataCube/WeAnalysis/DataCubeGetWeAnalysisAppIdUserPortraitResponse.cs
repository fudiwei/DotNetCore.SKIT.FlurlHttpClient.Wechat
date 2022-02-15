namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getweanalysisappiduserportrait 接口的响应。</para>
    /// </summary>
    public class DataCubeGetWeAnalysisAppIdUserPortraitResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class NamedValue
                    {
                        /// <summary>
                        /// 获取或设置属性值 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public int? Id { get; set; }

                        /// <summary>
                        /// 获取或设置属性值名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置该属性访问 UV。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public int Value { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置省份分布列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public Types.NamedValue[] ProvinceDataList { get; set; } = default!;

                /// <summary>
                /// 获取或设置城市分布列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public Types.NamedValue[] CityDataList { get; set; } = default!;

                /// <summary>
                /// 获取或设置性别分布列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("genders")]
                [System.Text.Json.Serialization.JsonPropertyName("genders")]
                public Types.NamedValue[] GenderDataList { get; set; } = default!;

                /// <summary>
                /// 获取或设置终端分布列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("platforms")]
                [System.Text.Json.Serialization.JsonPropertyName("platforms")]
                public Types.NamedValue[] PlatformDataList { get; set; } = default!;

                /// <summary>
                /// 获取或设置设备分布列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("devices")]
                [System.Text.Json.Serialization.JsonPropertyName("devices")]
                public Types.NamedValue[] DeviceDataList { get; set; } = default!;

                /// <summary>
                /// 获取或设置年龄分布列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ages")]
                [System.Text.Json.Serialization.JsonPropertyName("ages")]
                public Types.NamedValue[] AgeDataList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置数据的日期（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ref_date")]
        [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
        public virtual string RefDateString { get; set; } = default!;

        /// <summary>
        /// 获取或设置新增用户画像数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("visit_uv_new")]
        [System.Text.Json.Serialization.JsonPropertyName("visit_uv_new")]
        public Types.Data NewVisitUVData { get; set; } = default!;

        /// <summary>
        /// 获取或设置活跃用户画像数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("visit_uv")]
        [System.Text.Json.Serialization.JsonPropertyName("visit_uv")]
        public Types.Data VisitUVData { get; set; } = default!;
    }
}
