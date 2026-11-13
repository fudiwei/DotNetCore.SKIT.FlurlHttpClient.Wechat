namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/getcdnusagedata 接口的响应。</para>
    /// </summary>
    public class WxaSecVodGetCdnUsageDataResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置数据所在时间区间的开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time")]
                [System.Text.Json.Serialization.JsonPropertyName("time")]
                public long Timestamp { get; set; }

                /// <summary>
                /// 获取或设置数据大小（单位：字节）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public long Value { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置时间粒度（单位：分钟）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_interval")]
        [System.Text.Json.Serialization.JsonPropertyName("data_interval")]
        public int DataInterval { get; set; }

        /// <summary>
        /// 获取或设置 CDN 统计数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_list")]
        [System.Text.Json.Serialization.JsonPropertyName("item_list")]
        public List<Types.Data>? DataList { get; set; }
    }
}
