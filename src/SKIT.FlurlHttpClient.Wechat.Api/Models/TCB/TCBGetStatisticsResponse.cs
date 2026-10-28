namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getstatistics 接口的响应。</para>
    /// </summary>
    public class TCBGetStatisticsResponse : WechatApiResponse
    {
        public static class Types
        {
            public class DataColumn
            {
                /// <summary>
                /// 获取或设置列 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("col_id")]
                [System.Text.Json.Serialization.JsonPropertyName("col_id")]
                public string? ColumnId { get; set; }

                /// <summary>
                /// 获取或设置列名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("col_name")]
                [System.Text.Json.Serialization.JsonPropertyName("col_name")]
                public string? ColumnName { get; set; }

                /// <summary>
                /// 获取或设置数据类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("col_data_type")]
                [System.Text.Json.Serialization.JsonPropertyName("col_data_type")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringConverter))]
                public string? ColumnDateType { get; set; }
            }

            public class DataValue
            {
                /// <summary>
                /// 获取或设置数据值列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data_value")]
                [System.Text.Json.Serialization.JsonPropertyName("data_value")]
                public List<string>? ValueList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置数据列定义列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_column")]
        [System.Text.Json.Serialization.JsonPropertyName("data_column")]
        public List<Types.DataColumn>? DataColumnList { get; set; }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_value")]
        [System.Text.Json.Serialization.JsonPropertyName("data_value")]
        public List<Types.DataValue>? DataValueList { get; set; }

        /// <summary>
        /// 获取或设置数据总行数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
