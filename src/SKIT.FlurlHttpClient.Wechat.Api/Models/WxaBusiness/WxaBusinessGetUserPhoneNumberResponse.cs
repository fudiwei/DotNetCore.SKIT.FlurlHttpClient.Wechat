namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/getuserphonenumber 接口的响应。</para>
    /// </summary>
    public class WxaBusinessGetUserPhoneNumberResponse : WechatApiResponse
    {
        public static class Types
        {
            public class PhoneInfo
            {
                public static class Types
                {
                    public class Watermark
                    {
                        /// <summary>
                        /// 获取或设置小程序 AppId
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户获取手机号操作的时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("timestamp")]
                        [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
                        public long Timestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置用户绑定的手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phoneNumber")]
                [System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
                public string PhoneNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置没有区号的手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("purePhoneNumber")]
                [System.Text.Json.Serialization.JsonPropertyName("purePhoneNumber")]
                public string PurePhoneNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置区号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("countryCode")]
                [System.Text.Json.Serialization.JsonPropertyName("countryCode")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                public string CountryCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置数据水印。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("watermark")]
                [System.Text.Json.Serialization.JsonPropertyName("watermark")]
                public Types.Watermark Watermark { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置用户手机号信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_info")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_info")]
        public Types.PhoneInfo PhoneInfo { get; set; } = default!;
    }
}
