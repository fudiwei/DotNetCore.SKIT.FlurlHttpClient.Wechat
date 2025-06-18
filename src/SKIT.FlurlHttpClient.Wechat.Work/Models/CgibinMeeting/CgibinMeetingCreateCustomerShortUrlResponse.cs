namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/create_customer_short_url 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingCreateCustomerShortUrlResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置用户专属参会链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("meeting_short_url")]
                [System.Text.Json.Serialization.JsonPropertyName("meeting_short_url")]
                public string MeetingShortUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户自定义数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("customer_data")]
                [System.Text.Json.Serialization.JsonPropertyName("customer_data")]
                public string CustomData { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_short_url_customer_data")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_short_url_customer_data")]
        public Types.Data Data { get; set; } = default!;
    }
}
