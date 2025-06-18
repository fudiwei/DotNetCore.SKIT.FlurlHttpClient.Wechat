namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/get_customer_short_url 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingGetCustomerShortUrlResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Data : CgibinMeetingCreateCustomerShortUrlResponse.Types.Data
            {
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meeting_short_url_customer_data_list")]
        [System.Text.Json.Serialization.JsonPropertyName("meeting_short_url_customer_data_list")]
        public Types.Data[] Data { get; set; } = default!;
    }
}
