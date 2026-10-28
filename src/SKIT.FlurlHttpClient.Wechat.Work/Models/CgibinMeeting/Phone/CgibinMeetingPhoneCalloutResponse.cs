namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/phone/callout 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingPhoneCalloutResponse : WechatWorkResponse
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
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
                public string? AreaCode { get; set; }

                /// <summary>
                /// 获取或设置电话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                public string? PhoneNumber { get; set; }

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
                public string? Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置成功的外呼列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_numbers")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_numbers")]
        public List<Types.Callout>? SuccessfulCalloutList { get; set; }

        /// <summary>
        /// 获取或设置不合法的外呼列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_phone_numbers")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_phone_numbers")]
        public List<Types.Callout>? InvalidCalloutList { get; set; }
    }
}
