namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/reason/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECAftersaleReasonGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Reason
            {
                /// <summary>
                /// 获取或设置售后原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                public string ReasonType { get; set; } = default!;

                /// <summary>
                /// 获取或设置售后原因说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason_text")]
                [System.Text.Json.Serialization.JsonPropertyName("reason_text")]
                public string ReasonText { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置售后原因列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason_list")]
        [System.Text.Json.Serialization.JsonPropertyName("reason_list")]
        public Types.Reason[] ReasonList { get; set; } = default!;
    }
}
