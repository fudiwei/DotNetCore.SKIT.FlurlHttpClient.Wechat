namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/phone/get_callout_status 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingPhoneGetCalloutStatusResponse : WechatWorkResponse
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
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
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
                /// 获取或设置外呼状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

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
        [Newtonsoft.Json.JsonProperty("phone_numbers")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_numbers")]
        public Types.Callout[] CalloutList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
