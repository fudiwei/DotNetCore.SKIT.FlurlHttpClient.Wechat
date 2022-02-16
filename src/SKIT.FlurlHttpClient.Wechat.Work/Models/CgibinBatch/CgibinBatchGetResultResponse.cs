namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/batch/getresult 接口的响应。</para>
    /// </summary>
    public class CgibinBatchGetResultResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string? ErrorMessage { get; set; }

                /// <summary>
                /// 获取或设置操作类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("action")]
                [System.Text.Json.Serialization.JsonPropertyName("action")]
                public int? Action { get; set; }

                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置部门 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("partyid")]
                [System.Text.Json.Serialization.JsonPropertyName("partyid")]
                public long? DepartmentId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置任务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 获取或设置任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置任务运行总条数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置目前运行百分比。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("percentage")]
        [System.Text.Json.Serialization.JsonPropertyName("percentage")]
        public int Percentage { get; set; }

        /// <summary>
        /// 获取或设置处理结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
