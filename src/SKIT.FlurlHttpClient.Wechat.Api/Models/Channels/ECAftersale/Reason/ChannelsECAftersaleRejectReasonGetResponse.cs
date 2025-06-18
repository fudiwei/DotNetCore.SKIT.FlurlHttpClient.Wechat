namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/rejectreason/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECAftersaleRejectReasonGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class RejectReason
            {
                /// <summary>
                /// 获取或设置售后拒绝原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reject_reason_type")]
                [System.Text.Json.Serialization.JsonPropertyName("reject_reason_type")]
                public int RejectReasonType { get; set; }

                /// <summary>
                /// 获取或设置售后拒绝原因说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reject_reason_type_text")]
                [System.Text.Json.Serialization.JsonPropertyName("reject_reason_type_text")]
                public string RejectReasonText { get; set; } = default!;

                /// <summary>
                /// 获取或设置售后拒绝原因默认描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reject_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                public string? RejectReasonDescription { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置售后拒绝原因列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason_list")]
        [System.Text.Json.Serialization.JsonPropertyName("reason_list")]
        public Types.RejectReason[] RejectReasonList { get; set; } = default!;
    }
}
