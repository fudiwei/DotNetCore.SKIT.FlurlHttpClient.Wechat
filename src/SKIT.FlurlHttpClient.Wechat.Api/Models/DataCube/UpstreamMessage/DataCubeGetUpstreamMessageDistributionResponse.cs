namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getupstreammsgdist 接口的响应。</para>
    /// </summary>
    public class DataCubeGetUpstreamMessageDistributionResponse : WechatApiResponse
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
                /// 获取或设置当日发送消息量分布的区间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count_interval")]
                [System.Text.Json.Serialization.JsonPropertyName("count_interval")]
                public int CountInterval { get; set; }

                /// <summary>
                /// 获取或设置上行发送了消息的用户数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_user")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_user")]
                public int MessageUserCount { get; set; }
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
