namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/vip/user/score/flowrecord/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECVipUserScoreFlowRecordGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class FlowRecord
            {
                /// <summary>
                /// 获取或设置积分值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("score")]
                [System.Text.Json.Serialization.JsonPropertyName("score")]
                public int Score { get; set; }

                /// <summary>
                /// 获取或设置流水来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public int Source { get; set; }

                /// <summary>
                /// 获取或设置流水记录。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置积分流水列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.FlowRecord[] FlowRecordList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
