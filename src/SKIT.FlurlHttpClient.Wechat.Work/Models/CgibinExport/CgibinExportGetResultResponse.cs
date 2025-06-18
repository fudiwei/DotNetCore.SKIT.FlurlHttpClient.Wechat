namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/export/get_result 接口的响应。</para>
    /// </summary>
    public class CgibinExportGetResultResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置任务状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = default!;

                /// <summary>
                /// 获取或设置数据大小（单位：字节）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("size")]
                [System.Text.Json.Serialization.JsonPropertyName("size")]
                public int Size { get; set; }

                /// <summary>
                /// 获取或设置数据哈希值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("md5")]
                [System.Text.Json.Serialization.JsonPropertyName("md5")]
                public string Hash { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_list")]
        [System.Text.Json.Serialization.JsonPropertyName("data_list")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
