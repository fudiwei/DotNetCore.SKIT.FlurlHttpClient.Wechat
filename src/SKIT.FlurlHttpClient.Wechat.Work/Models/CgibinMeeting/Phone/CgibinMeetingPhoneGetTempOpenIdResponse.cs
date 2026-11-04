namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/phone/get_tmp_openid 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingPhoneGetTempOpenIdResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Callout : CgibinMeetingPhoneCalloutResponse.Types.Callout
            {
                /// <summary>
                /// 获取或设置会议的成员临时 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tmp_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("tmp_openid")]
                public string? TempOpenId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置外呼列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tmp_openid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("tmp_openid_list")]
        public List<Types.Callout>? CalloutList { get; set; }
    }
}
