namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxaapi/log/get_performance 接口的响应。</para>
    /// </summary>
    public class WxaApiLogGetPerformanceResponse : WechatApiResponse
    {
        public static class Types
        {
            public class DefaultTimeData
            {
                public static class Types
                {
                    public class Data
                    {
                        /// <summary>
                        /// 获取或设置数据的日期（格式：yyyyMMdd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ref_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
                        public string RefDateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置耗时类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cost_time_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("cost_time_type")]
                        public int CostTimeType { get; set; }

                        /// <summary>
                        /// 获取或设置耗时（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cost_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("cost_time")]
                        public int CostTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Data[] DataList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置查询数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("default_time_data")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("default_time_data")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public Types.DefaultTimeData? DefaultTimeData { get; set; }

        /// <summary>
        /// 获取或设置比较数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("compare_time_data")]
        [System.Text.Json.Serialization.JsonPropertyName("compare_time_data")]
        public string? CompareTimeData { get; set; }
    }
}
