namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/phone/get_tmp_openid 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingPhoneGetTempOpenIdResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Callout
            {
                /// <summary>
                /// 获取或设置国家地区代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("area")]
                [System.Text.Json.Serialization.JsonPropertyName("area")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string AreaCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置电话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                public string PhoneNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置分机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extension_number")]
                [System.Text.Json.Serialization.JsonPropertyName("extension_number")]
                public string? ExtensionNumber { get; set; }

                /// <summary>
                /// 获取或设置会议的成员临时 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tmp_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("tmp_openid")]
                public string TempOpenId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置外呼列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tmp_openid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("tmp_openid_list")]
        public Types.Callout[] CalloutList { get; set; } = default!;
    }
}
