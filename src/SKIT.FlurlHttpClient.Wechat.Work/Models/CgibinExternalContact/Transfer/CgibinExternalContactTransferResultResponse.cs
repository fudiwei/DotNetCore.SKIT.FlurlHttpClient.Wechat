namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/transfer_result 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactTransferResultResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置接替状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置外部联系人账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
                public string ExternalUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置接替时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("takeover_time")]
                [System.Text.Json.Serialization.JsonPropertyName("takeover_time")]
                public long? TakeoverTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置客户转交结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customer")]
        [System.Text.Json.Serialization.JsonPropertyName("customer")]
        public Types.Result[] ResultList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
