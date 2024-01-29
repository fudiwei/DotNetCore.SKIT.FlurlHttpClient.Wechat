using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/phone/callout 接口的请求。</para>
    /// </summary>
    public class CgibinMeetingPhoneCalloutRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Callout
            {
                /// <summary>
                /// 获取或设置国家地区代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("area")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalStringConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("area")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
                public string AreaCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置电话号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                public string PhoneNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置分机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extension_number")]
                [System.Text.Json.Serialization.JsonPropertyName("extension_number")]
                public string? ExtensionNumber { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会议 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meetingid")]
        [System.Text.Json.Serialization.JsonPropertyName("meetingid")]
        public string MeetingId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置外呼列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_numbers")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_numbers")]
        public IList<Types.Callout> Calloutist { get; set; } = new List<Types.Callout>();
    }
}
