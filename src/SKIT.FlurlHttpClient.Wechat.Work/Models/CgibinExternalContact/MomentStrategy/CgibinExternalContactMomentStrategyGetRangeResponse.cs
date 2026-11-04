namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/moment_strategy/get_range 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactMomentStrategyGetRangeResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Range : CgibinExternalContactMomentStrategyCreateRequest.Types.Range
            {
            }
        }

        /// <summary>
        /// 获取或设置规则组范围列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("range")]
        [System.Text.Json.Serialization.JsonPropertyName("range")]
        public List<Types.Range>? RangeList { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
