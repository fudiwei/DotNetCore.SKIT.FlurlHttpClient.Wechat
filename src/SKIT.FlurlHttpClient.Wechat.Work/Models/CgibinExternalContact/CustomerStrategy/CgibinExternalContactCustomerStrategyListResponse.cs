namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/customer_strategy/list 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactCustomerStrategyListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Strategy
            {
                /// <summary>
                /// 获取或设置规则组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("strategy_id")]
                [System.Text.Json.Serialization.JsonPropertyName("strategy_id")]
                public int StrategyId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置规则组列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("strategy")]
        [System.Text.Json.Serialization.JsonPropertyName("strategy")]
        public Types.Strategy[] StrategyList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
