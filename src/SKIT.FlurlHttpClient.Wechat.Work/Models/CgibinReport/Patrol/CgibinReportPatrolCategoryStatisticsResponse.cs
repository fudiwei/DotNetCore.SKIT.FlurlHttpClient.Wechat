namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/patrol/category_statistic 接口的响应。</para>
    /// </summary>
    public class CgibinReportPatrolCategoryStatisticsResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                public string CategoryId { get; set; } = default!;

                /// <summary>
                /// 获取或设置分类名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_name")]
                [System.Text.Json.Serialization.JsonPropertyName("category_name")]
                public string CategoryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置分类层级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_level")]
                [System.Text.Json.Serialization.JsonPropertyName("category_level")]
                public int CategoryLevel { get; set; }

                /// <summary>
                /// 获取或设置分类类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_type")]
                [System.Text.Json.Serialization.JsonPropertyName("category_type")]
                public int CategoryType { get; set; }

                /// <summary>
                /// 获取或设置累计上报数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_case")]
                [System.Text.Json.Serialization.JsonPropertyName("total_case")]
                public int TotalAddedCount { get; set; }

                /// <summary>
                /// 获取或设置累计办结数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_solved")]
                [System.Text.Json.Serialization.JsonPropertyName("total_solved")]
                public int TotalSolvedCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dashboard_list")]
        [System.Text.Json.Serialization.JsonPropertyName("dashboard_list")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
