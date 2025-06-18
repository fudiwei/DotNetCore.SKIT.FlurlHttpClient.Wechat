namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getweanalysisappiddailyretaininfo 接口的响应。</para>
    /// </summary>
    public class DataCubeGetWeAnalysisAppIdDailyRetainInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("key")]
                [System.Text.Json.Serialization.JsonPropertyName("key")]
                public int Key { get; set; }

                /// <summary>
                /// 获取或设置值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public int Value { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置数据的日期（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ref_date")]
        [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
        public virtual string RefDateString { get; set; } = default!;

        /// <summary>
        /// 获取或设置新增用户留存数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("visit_uv_new")]
        [System.Text.Json.Serialization.JsonPropertyName("visit_uv_new")]
        public Types.Data[] NewVisitUVDataList { get; set; } = default!;

        /// <summary>
        /// 获取或设置活跃用户留存数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("visit_uv")]
        [System.Text.Json.Serialization.JsonPropertyName("visit_uv")]
        public Types.Data[] VisitUVDataList { get; set; } = default!;
    }
}
