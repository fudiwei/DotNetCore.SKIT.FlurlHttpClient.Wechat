namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getusersummary 接口的响应。</para>
    /// </summary>
    public class DataCubeGetUserSummaryResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置数据的日期（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ref_date")]
                [System.Text.Json.Serialization.JsonPropertyName("ref_date")]
                public string RefDateString { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户的渠道。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_source")]
                [System.Text.Json.Serialization.JsonPropertyName("user_source")]
                public int UserSource { get; set; }

                /// <summary>
                /// 获取或设置新增的用户数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new_user")]
                [System.Text.Json.Serialization.JsonPropertyName("new_user")]
                public int NewUserCount { get; set; }

                /// <summary>
                /// 获取或设置取消关注的用户数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cancel_user")]
                [System.Text.Json.Serialization.JsonPropertyName("cancel_user")]
                public int CancelUserCount { get; set; }
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
