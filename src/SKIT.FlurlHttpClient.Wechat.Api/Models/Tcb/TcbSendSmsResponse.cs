namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/sendsms 接口的响应。</para>
    /// </summary>
    public class TcbSendSmsResponse : WechatApiResponse
    {
        public static class Types
        {
            public class SendStatus
            {
                /// <summary>
                /// 获取或设置发送流水号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("serial_no")]
                [System.Text.Json.Serialization.JsonPropertyName("serial_no")]
                public string SerialNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone_number")]
                [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
                public string MobileNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置短信请求错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public string ErrorCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置短信请求错误码描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("message")]
                [System.Text.Json.Serialization.JsonPropertyName("message")]
                public string? ErrorMessage { get; set; }

                /// <summary>
                /// 获取或设置国家码或地区码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("iso_code")]
                [System.Text.Json.Serialization.JsonPropertyName("iso_code")]
                public string? ISOCode { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置发送状态列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_status_list")]
        [System.Text.Json.Serialization.JsonPropertyName("send_status_list")]
        public Types.SendStatus[]? SendStatusList { get; set; }
    }
}
